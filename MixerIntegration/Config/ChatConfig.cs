using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MixerIntegration.Config
{

    public class ChatConfig
    {

        private string FilePath = Path.Combine(Environment.CurrentDirectory, "UserData", "Mixer", "settings.cfg");

        public string FontName = "Segoe UI";
        
        public float ChatScale = 1.1f;
        public float ChatWidth = 160;
        public float LineSpacing = 2.0f;
        public int MaxChatLines = 30;

        public float PositionX = 0;
        public float PositionY = 2.6f;
        public float PositionZ = 2.3f;

        public float RotationX = -30;
        public float RotationY = 0;
        public float RotationZ = 0;

        public float TextColorR = 1;
        public float TextColorG = 1;
        public float TextColorB = 1;

        public float BackgroundColorR = 0;
        public float BackgroundColorG = 0;
        public float BackgroundColorB = 0;
        public float BackgroundColorA = 0.6f;
        public float BackgroundPadding = 4;
        
        public bool ClearChatEnabled = true;
        public bool ShowTimeOutMessage = true;
        public bool ShowBannedMessage = true;
        public bool ShowDeletedMessages = false;
        public bool DrawShadows = false;
        public bool LockChatPosition = false;
        public bool ReverseChatOrder = false;
        public bool ShowEmotes = true;
        public bool ShowGifs = true;
        public bool ShowSubBadge = false;

        public bool FilterCommandMessages = false;
        public bool FilterBroadcasterMessages = false;
        public bool FilterIgnoredUserMessages = false;

        public List<string> ignoredUsers = new List<string>();

        public ChatColor StreamerColor = ChatColor.DefaultStreamerColor;
        public ChatColor FounderColor = ChatColor.DefaultFounderColor;
        public ChatColor GuardianColor = ChatColor.DefaultGuardianColor;
        public ChatColor StaffColor = ChatColor.DefaultStaffColor;
        public ChatColor GlobalModColor = ChatColor.DefaultGlobalModColor;
        public ChatColor ModeratorColor = ChatColor.DefaultModeratorColor;
        public ChatColor ProColor = ChatColor.DefaultProColor;
        public ChatColor EditorColor = ChatColor.DefaultEditorColor;
        public ChatColor SubscriberColor = ChatColor.DefaultSubscriberColor;
        public ChatColor ViewerColor = ChatColor.DefaultViewerColor;


        private bool _saving;

        private static ChatConfig _instance = null;
        public static ChatConfig Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ChatConfig();
                return _instance;
            }

            private set
            {
                _instance = value;
            }
        }

        public Color TextColor
        {
            get
            {
                return new Color(TextColorR, TextColorG, TextColorB);
            }
            set
            {
                TextColorR = value.r;
                TextColorG = value.g;
                TextColorB = value.b;
            }
        }

        public Color BackgroundColor
        {
            get
            {
                return new Color(BackgroundColorR, BackgroundColorG, BackgroundColorB, BackgroundColorA);
            }
            set
            {
                BackgroundColorR = value.r;
                BackgroundColorG = value.g;
                BackgroundColorB = value.b;
                BackgroundColorA = value.a;
            }
        }

        public Vector3 ChatPosition
        {
            get
            {
                return new Vector3(PositionX, PositionY, PositionZ);
            }
            set
            {
                PositionX = value.x;
                PositionY = value.y;
                PositionZ = value.z;
            }
        }

        public Vector3 ChatRotation
        {
            get { return new Vector3(RotationX, RotationY, RotationZ); }
            set
            {
                RotationX = value.x;
                RotationY = value.y;
                RotationZ = value.z;
            }
        }

    }
}
