using System.Xml.Serialization;


namespace SESaveEditor.Models
{
    public class MyObjectBuilder_Checkpoint
    {
        public CurrentSector CurrentSector { get; set; }
        public string ElapsedGameTime { get; set; }
        public string SessionName { get; set; }
        public SpectatorPosition SpectatorPosition { get; set; }
        public SpectatorSpeed SpectatorSpeed { get; set; }
        public string SpectatorIsLightOn { get; set; }
        public string CameraController { get; set; }
        public string CameraEntity { get; set; }
        public string ControlledObject { get; set; }
        public string Password { get; set; }
        public Description Description { get; set; }
        public string LastSaveTime { get; set; }
        public string SpectatorDistance { get; set; }
        public CharacterToolbar CharacterToolbar { get; set; }
        public ControlledEntities ControlledEntities { get; set; }
        public Settings Settings { get; set; }
        public ScriptManagerData LastSaScriptManagerDataveTime { get; set; }
        public string AppVersion { get; set; }
        public Factions Factions { get; set; }
        public Mods Mods { get; set; }
        public PromotedUsers PromotedUsers { get; set; }
        public CreativeTools CreativeTools { get; set; }
        public Scenario Scenario { get; set; }
        public RespawnCooldowns RespawnCooldowns { get; set; }
        public Identities Identities { get; set; }
        public string PreviousEnvironmentHostility { get; set; }
        public AllPlayersData AllPlayersData { get; set; }
        public AllPlayersColors AllPlayersColors { get; set; }
        public ChatHistory ChatHistory { get; set; }
        public FactionChatHistory FactionChatHistory { get; set; }
        public NonPlayerIdentities NonPlayerIdentities { get; set; }
        public Gps Gps { get; set; }
        public SessionComponents SessionComponents { get; set; }
        public GameDefinition GameDefinition { get; set; }
        public SessionComponentEnabled SessionComponentEnabled { get; set; }
        public SessionComponentDisabled SessionComponentDisabled { get; set; }
        public string InGameTime { get; set; }
        public MissionTriggers MissionTriggers { get; set; }
        public CustomSkybox CustomSkybox { get; set; }
        public VicinityModelsCache VicinityModelsCache { get; set; }
        public VicinityArmorModelsCache VicinityArmorModelsCache { get; set; }
        public VicinityVoxelCache VicinityVoxelCache { get; set; }
        public RemoteAdminSettings RemoteAdminSettings { get; set; }
    }

    public class RemoteAdminSettings
    {
    }

    public class VicinityVoxelCache
    {
    }

    public class VicinityArmorModelsCache
    {
    }

    public class VicinityModelsCache
    {
    }

    public class CustomSkybox
    {
    }

    public class MissionTriggers
    {
    }

    public class SessionComponentDisabled
    {
    }

    public class SessionComponentEnabled
    {
    }

    public class GameDefinition
    {
    }

    public class SessionComponents
    {
    }

    public class Gps
    {
    }

    public class NonPlayerIdentities
    {
    }

    public class FactionChatHistory
    {
    }

    public class ChatHistory
    {
    }

    public class AllPlayersColors
    {
    }

    public class AllPlayersData
    {
    }

    public class Identities
    {
    }

    public class RespawnCooldowns
    {
    }

    public class Scenario
    {
    }

    public class CreativeTools
    {
    }

    public class PromotedUsers
    {
    }

    public class Mods
    {
    }

    public class Factions
    {
    }

    public class ScriptManagerData
    {
    }

    public class Settings
    {
    }

    public class ControlledEntities
    {
    }

    public class CharacterToolbar
    {
    }

    public class Description
    {
    }

    public class SpectatorSpeed
    {
    }

    public class SpectatorPosition
    {
    }

    public class CurrentSector
    {
    }
}