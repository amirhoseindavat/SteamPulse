#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1 
// last Edit: 2/16/23 V2.1
#endregion

using System.Drawing;

namespace SteamPulse.GlobalVariables
{
    public struct Names
    {
        public static string MSFS => "Microsoft Loading Simulator";
    }
    public struct Images
    {
        public struct Header
        {
            public static string MSFS => "https://cdn.codemage.ir/Projects/SteamPulse/Resource/MSFS/header.jpg";
        }
        public struct Hero
        {
            public static string MSFS => "https://cdn.codemage.ir/Projects/SteamPulse/Resource/MSFS/library.jpg";
        }
    }
    public struct Colors
    {
        public struct Light
        {
            public static Color NileBlue => Color.FromArgb(24, 49, 83);
            public static Color White => Color.FromArgb(255, 255, 255);
            public static Color AthenGray => Color.FromArgb(241, 240, 245);
        }
        public struct Dark
        {
            public static Color White => Color.FromArgb(255, 255, 255);
            public static Color NileBlue => Color.FromArgb(24, 49, 83);
            public static Color Cello => Color.FromArgb(33, 63, 105);
        }
    }

}
