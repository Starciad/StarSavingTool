using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StarSavingTool.Console
{
    public enum VersionType
    {
        None = 0,
        Unknown = 1,

        Alpha = 10,
        OpenAlpha = 11,
        CloseAlpha = 12,

        Beta = 20,
        OpenBeta = 21,
        ClosedBeta = 22,

        Release = 30,
        PreRelease = 31,
        TestRelease = 32,
        OfficialRelease = 33,

        Demo = 40,

        Official = 50,
    }

    public enum VersionStore
    {
        Unknown = 0,

        ItchIo = 10,
        GameJolt = 20,
        Steam = 30,
        EpicGames = 40,
        Microsoft = 50,
    }

    public struct SaveInformations
    {
        //Version
        public string Version;
        public string VersionId;
        public string EngineVersion;
        public string GameVersion;

        public bool IncompatibleVersion;
        public bool ExperimentsVersion;
        public bool InsecureVersion;
        public bool DeveloperVersion;
        public bool OpenVersion;
        public bool OldVersion;

        public VersionType VersionType;
        public VersionStore VersionStore;

        //Date Times
        public DateTime CreationTimestamp;
        public DateTime UpdateTimestamp;

        //States
        public bool IsCorrupted;
        public bool IsEdited;
        public bool IsCloned;
        public bool IsOriginal;
        public bool IsCompatible;
        public bool IsDeleted;
        public bool IsFavorited;

        //Store
        public bool IsRegistered;
        public bool HaveLicense;
        public bool VeracityConfirmation;

        //Clound
        public bool CloundSaving;
        public string CloundUrlAPI;
        public string CloundUrlSecret;
        public string CloundUrlClient;
    }
}
