using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MixerIntegration.Config
{
    public class ChatColor
    {
        public float red;
        public float green;
        public float blue;

        public ChatColor()
        {
            this.red = 1;
            this.green = 1;
            this.blue = 1;
        }

        public ChatColor(float red, float green, float blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public ChatColor(int red, int green, int blue)
        {
            float mod = (1 / 255);
            this.red = (mod * red);
            this.green = (mod * green);
            this.blue = (mod * blue);
        }

        public ChatColor(Color color)
        {
            this.red = color.r;
            this.green = color.g;
            this.blue = color.b;
        }

        public Color GetColor()
        {
            return new Color(red, green, blue);
        }

        public void SetColor(float red, float green, float blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public void SetColor(int red, int green, int blue)
        {
            float mod = (1 / 255);
            this.red = (mod * red);
            this.green = (mod * green);
            this.blue = (mod * blue);
        }

        public void SetColor(Color color)
        {
            this.red = color.r;
            this.green = color.g;
            this.blue = color.b;
        }

        public static ChatColor DefaultStreamerColor = new ChatColor(255, 255, 255);
        public static ChatColor DefaultFounderColor = new ChatColor(228, 45, 45);
        public static ChatColor DefaultGuardianColor = new ChatColor(236, 191, 55);
        public static ChatColor DefaultStaffColor = new ChatColor(236, 191, 55);
        public static ChatColor DefaultGlobalModColor = new ChatColor(7, 253, 198);
        public static ChatColor DefaultModeratorColor = new ChatColor(55, 237, 59);
        public static ChatColor DefaultProColor = new ChatColor(198, 66, 234);
        public static ChatColor DefaultEditorColor = new ChatColor(55, 170, 213);
        public static ChatColor DefaultSubscriberColor = new ChatColor(55, 170, 213);
        public static ChatColor DefaultViewerColor = new ChatColor(55, 170, 213);


        public enum RoleColorOrder
        {
            Streamer = 9,
            Founder = 8,
            Guardian = 7,
            Staff = 6,
            GlobalMod = 5,
            Moderator = 4,
            Pro = 3,
            Editor = 2,
            Subscriber = 1,
            Viewer = 0
        }

    }
}
