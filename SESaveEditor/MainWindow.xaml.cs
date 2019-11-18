using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Configuration;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.XPath;
using System.Text.RegularExpressions;
using LiquidTechnologies.GeneratedLx.Ns;

namespace SESaveEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string FileName = "";

        private static XmlSerializerNamespaces getAllNamespaces(XmlDocument xDoc)
        {
            XmlSerializerNamespaces result = new XmlSerializerNamespaces();

            IDictionary<string, string> localNamespaces = null;
            XPathNavigator xNav = xDoc.CreateNavigator();
            while (xNav.MoveToFollowing(XPathNodeType.Element))
            {
                localNamespaces = xNav.GetNamespacesInScope(XmlNamespaceScope.Local);
                foreach (var localNamespace in localNamespaces)
                {
                    string prefix = localNamespace.Key;
                    if (string.IsNullOrEmpty(prefix))
                        prefix = "";

                    result.Add(prefix, localNamespace.Value);
                }
            }

            return result;
        }

        public static string RemoveTypeTagFromXml(string xml)
        {
            if (!string.IsNullOrEmpty(xml) && xml.Contains("xsi:type"))
            {
                xml = Regex.Replace(xml, @"\s+xsi:type=""\w+""", "");
            }
            return xml;
        }

        private static T Deserialize<T>(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlReaderSettings settings = new XmlReaderSettings();
            using (StringReader textReader = new StringReader(RemoveTypeTagFromXml(xml)))
            {
                using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
                {
                    
                    return (T)serializer.Deserialize(xmlReader);
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Load_File(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                FileName = dialog.FileName;
                var editFilePath = System.IO.Path.Combine(ConfigurationManager.AppSettings["edited_files_path"], dialog.FileName.Split('/').Last() + "_edited");
                if (!File.Exists(editFilePath))
                    File.Copy(dialog.FileName, editFilePath);
                MyObjectBuilder_CheckpointElm checkpoint;
                XmlSerializerNamespaces fileNameSpaces;
                var content = "";
                using (FileStream fs = File.OpenRead(editFilePath))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        content = sr.ReadToEnd();
                        var xmldoc = new XmlDocument();
                        xmldoc.LoadXml(content);
                        fileNameSpaces = getAllNamespaces(xmldoc);
                    }
                }
                checkpoint = Deserialize<MyObjectBuilder_CheckpointElm>(content);
                
                using (var fsv = File.Create(System.IO.Path.Combine(ConfigurationManager.AppSettings["edited_files_path"], dialog.FileName.Split('/').Last() + "_edited1")))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(MyObjectBuilder_CheckpointElm));
                    ser.Serialize(new StreamWriter(fsv), checkpoint, fileNameSpaces);
                }
                
            }
        }
    }
}
