/*
 * Utworzone przez SharpDevelop.
 * Użytkownik: admin
 * Data: 2012-06-06
 * Godzina: 13:46
 * 
 * Do zmiany tego szablonu użyj Narzędzia | Opcje | Kodowanie | Edycja Nagłówków Standardowych.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HamaBeads
{
   /// <summary>
   /// Description of OptionsDlg.
   /// </summary>
   public partial class OptionsDlg : Form
   {
      public OptionsDlg(Form parent)
      {
         //
         // The InitializeComponent() call is required for Windows Forms designer support.
         //
         InitializeComponent();
         
         //
         // TODO: Add constructor code after the InitializeComponent() call.
         //
         tbDOut.Text = MainForm.settings.DOut.ToString();
         tbDInn.Text = MainForm.settings.DInn.ToString();
         
         tbNCir.Text = MainForm.settings.SizeCir.ToString();
         tbNRec.Text = MainForm.settings.SizeRec.ToString();
         tbNHex.Text = MainForm.settings.SizeHex.ToString();
      }
      
      void BtOk_Click(object sender, EventArgs e)
      {
         MainForm.settings.DOut = uint.Parse(tbDOut.Text);
         MainForm.settings.DInn = uint.Parse(tbDInn.Text);
         MainForm.settings.SizeCir = uint.Parse(tbNCir.Text);
         MainForm.settings.SizeRec = uint.Parse(tbNRec.Text);
         MainForm.settings.SizeHex = uint.Parse(tbNHex.Text);
      }
   }
}
