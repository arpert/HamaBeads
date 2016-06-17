/*
 * Utworzone przez SharpDevelop.
 * Użytkownik: admin
 * Data: 2012-05-29
 * Godzina: 14:05
 * 
 * Do zmiany tego szablonu użyj Narzędzia | Opcje | Kodowanie | Edycja Nagłówków Standardowych.
 */
using System;
using System.Windows.Forms;

namespace HamaBeads
{
   /// <summary>
   /// Class with program entry point.
   /// </summary>
   internal sealed class Program
   {
      /// <summary>
      /// Program entry point.
      /// </summary>
      [STAThread]
      private static void Main(string[] args)
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new MainForm());
      }
      
   }
}
