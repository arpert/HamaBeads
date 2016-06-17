/*
 * Utworzone przez SharpDevelop.
 * Użytkownik: admin
 * Data: 2012-06-06
 * Godzina: 16:23
 * 
 * Do zmiany tego szablonu użyj Narzędzia | Opcje | Kodowanie | Edycja Nagłówków Standardowych.
 */
 using System.Drawing;
using System;
using System.Configuration;

namespace HamaBeads
{
   /// <summary>
   /// Description of HamaSettings.
   /// </summary>
//Application settings wrapper class
   public sealed class HamaSettings : ApplicationSettingsBase
   {
      public HamaSettings()
      {
//          type = "Cir";
//          DOut = 12;
//          DInn = 4;
//          SizeCir = 12;
//          SizeHex = 15;
//          SizeRec = 20;
//          BackColor = Color.Wheat;
//          BeadColor = Color.LightGreen;
      }

       [UserScopedSettingAttribute()]
       [DefaultSettingValueAttribute("Cir")]
       public string BoardType
       {
           get { return (string)(this["BoardType"]); }
           set { this["BoardType"] = value; }
       }

       [UserScopedSettingAttribute()]
       [DefaultSettingValueAttribute("12")]
       public uint DOut
       {
           get { return (uint)(this["DOut"]); }
           set { this["DOut"] = value; }
       }

       [UserScopedSettingAttribute()]
       [DefaultSettingValueAttribute("4")]
       public uint DInn
       {
           get { return (uint)(this["DInn"]); }
           set { this["DInn"] = value; }
       }

       [UserScopedSettingAttribute()]
       [DefaultSettingValueAttribute("9")]
       public uint SizeCir
       {
           get { return (uint)(this["SizeCir"]); }
           set { this["SizeCir"] = value; }
       }

       [UserScopedSettingAttribute()]
       [DefaultSettingValueAttribute("20")]
       public uint SizeRec
       {
           get { return (uint)(this["SizeRec"]); }
           set { this["SizeRec"] = value; }
       }

       [UserScopedSettingAttribute()]
       [DefaultSettingValueAttribute("15")]
       public uint SizeHex
       {
           get { return (uint)(this["SizeHex"]); }
           set { this["SizeHex"] = value; }
       }
       
       [UserScopedSettingAttribute()]
       [DefaultSettingValueAttribute("LightGray")]
       public Color BackColor
       {
           get { return (Color)this["BackColor"]; }
           set { this["BackColor"] = value; }
       }

       [UserScopedSettingAttribute()]
       [DefaultSettingValueAttribute("LightGreen")]
       public Color BeadColor
       {
           get { return (Color)this["BeadColor"]; }
           set { this["BeadColor"] = value; }
       }
   }
}
