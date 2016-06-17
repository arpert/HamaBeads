/*
 * Utworzone przez SharpDevelop.
 * Użytkownik: admin
 * Data: 2012-06-06
 * Godzina: 13:46
 * 
 * Do zmiany tego szablonu użyj Narzędzia | Opcje | Kodowanie | Edycja Nagłówków Standardowych.
 */
namespace HamaBeads
{
   partial class OptionsDlg
   {
      /// <summary>
      /// Designer variable used to keep track of non-visual components.
      /// </summary>
      private System.ComponentModel.IContainer components = null;
      
      /// <summary>
      /// Disposes resources used by the form.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing) {
            if (components != null) {
               components.Dispose();
            }
         }
         base.Dispose(disposing);
      }
      
      /// <summary>
      /// This method is required for Windows Forms designer support.
      /// Do not change the method contents inside the source code editor. The Forms designer might
      /// not be able to load this method if it was changed manually.
      /// </summary>
      private void InitializeComponent()
      {
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabRec = new System.Windows.Forms.TabPage();
         this.tbNRec = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.tabCir = new System.Windows.Forms.TabPage();
         this.tbNCir = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.tabHex = new System.Windows.Forms.TabPage();
         this.tbNHex = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btOk = new System.Windows.Forms.Button();
         this.btCancel = new System.Windows.Forms.Button();
         this.tbDOut = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.tbDInn = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.tabControl1.SuspendLayout();
         this.tabRec.SuspendLayout();
         this.tabCir.SuspendLayout();
         this.tabHex.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabRec);
         this.tabControl1.Controls.Add(this.tabCir);
         this.tabControl1.Controls.Add(this.tabHex);
         this.tabControl1.Location = new System.Drawing.Point(8, 122);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(268, 110);
         this.tabControl1.TabIndex = 0;
         // 
         // tabRec
         // 
         this.tabRec.Controls.Add(this.tbNRec);
         this.tabRec.Controls.Add(this.label3);
         this.tabRec.Location = new System.Drawing.Point(4, 22);
         this.tabRec.Name = "tabRec";
         this.tabRec.Padding = new System.Windows.Forms.Padding(3);
         this.tabRec.Size = new System.Drawing.Size(260, 84);
         this.tabRec.TabIndex = 0;
         this.tabRec.Text = "Kwadrat";
         this.tabRec.UseVisualStyleBackColor = true;
         // 
         // tbNRec
         // 
         this.tbNRec.Location = new System.Drawing.Point(68, 3);
         this.tbNRec.Name = "tbNRec";
         this.tbNRec.Size = new System.Drawing.Size(49, 20);
         this.tbNRec.TabIndex = 3;
         this.tbNRec.Text = "20";
         this.tbNRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // label3
         // 
         this.label3.Location = new System.Drawing.Point(6, 3);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(56, 23);
         this.label3.TabIndex = 2;
         this.label3.Text = "N";
         // 
         // tabCir
         // 
         this.tabCir.Controls.Add(this.tbNCir);
         this.tabCir.Controls.Add(this.label2);
         this.tabCir.Location = new System.Drawing.Point(4, 22);
         this.tabCir.Name = "tabCir";
         this.tabCir.Padding = new System.Windows.Forms.Padding(3);
         this.tabCir.Size = new System.Drawing.Size(260, 84);
         this.tabCir.TabIndex = 1;
         this.tabCir.Text = "Koło";
         this.tabCir.UseVisualStyleBackColor = true;
         // 
         // tbNCir
         // 
         this.tbNCir.Location = new System.Drawing.Point(68, 3);
         this.tbNCir.Name = "tbNCir";
         this.tbNCir.Size = new System.Drawing.Size(49, 20);
         this.tbNCir.TabIndex = 3;
         this.tbNCir.Text = "12";
         this.tbNCir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // label2
         // 
         this.label2.Location = new System.Drawing.Point(6, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 23);
         this.label2.TabIndex = 2;
         this.label2.Text = "N";
         // 
         // tabHex
         // 
         this.tabHex.Controls.Add(this.tbNHex);
         this.tabHex.Controls.Add(this.label1);
         this.tabHex.Location = new System.Drawing.Point(4, 22);
         this.tabHex.Name = "tabHex";
         this.tabHex.Padding = new System.Windows.Forms.Padding(3);
         this.tabHex.Size = new System.Drawing.Size(260, 84);
         this.tabHex.TabIndex = 2;
         this.tabHex.Text = "Sześciokąt";
         this.tabHex.UseVisualStyleBackColor = true;
         // 
         // tbNHex
         // 
         this.tbNHex.Location = new System.Drawing.Point(68, 3);
         this.tbNHex.Name = "tbNHex";
         this.tbNHex.Size = new System.Drawing.Size(49, 20);
         this.tbNHex.TabIndex = 1;
         this.tbNHex.Text = "15";
         this.tbNHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(6, 3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(56, 23);
         this.label1.TabIndex = 0;
         this.label1.Text = "N";
         // 
         // btOk
         // 
         this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btOk.Location = new System.Drawing.Point(201, 238);
         this.btOk.Name = "btOk";
         this.btOk.Size = new System.Drawing.Size(75, 23);
         this.btOk.TabIndex = 1;
         this.btOk.Text = "OK";
         this.btOk.UseVisualStyleBackColor = true;
         this.btOk.Click += new System.EventHandler(this.BtOk_Click);
         // 
         // btCancel
         // 
         this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btCancel.Location = new System.Drawing.Point(120, 238);
         this.btCancel.Name = "btCancel";
         this.btCancel.Size = new System.Drawing.Size(75, 23);
         this.btCancel.TabIndex = 2;
         this.btCancel.Text = "Anuluj";
         this.btCancel.UseVisualStyleBackColor = true;
         // 
         // tbDOut
         // 
         this.tbDOut.Location = new System.Drawing.Point(74, 9);
         this.tbDOut.Name = "tbDOut";
         this.tbDOut.Size = new System.Drawing.Size(49, 20);
         this.tbDOut.TabIndex = 4;
         this.tbDOut.Text = "12";
         this.tbDOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // label4
         // 
         this.label4.Location = new System.Drawing.Point(12, 9);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(56, 23);
         this.label4.TabIndex = 3;
         this.label4.Text = "D";
         // 
         // tbDInn
         // 
         this.tbDInn.Location = new System.Drawing.Point(74, 32);
         this.tbDInn.Name = "tbDInn";
         this.tbDInn.Size = new System.Drawing.Size(49, 20);
         this.tbDInn.TabIndex = 6;
         this.tbDInn.Text = "4";
         this.tbDInn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // label5
         // 
         this.label5.Location = new System.Drawing.Point(12, 32);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(56, 23);
         this.label5.TabIndex = 5;
         this.label5.Text = "d";
         // 
         // OptionsDlg
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(292, 273);
         this.Controls.Add(this.tbDInn);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.tbDOut);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.btCancel);
         this.Controls.Add(this.btOk);
         this.Controls.Add(this.tabControl1);
         this.MinimumSize = new System.Drawing.Size(300, 300);
         this.Name = "OptionsDlg";
         this.Text = "OptionsDlg";
         this.tabControl1.ResumeLayout(false);
         this.tabRec.ResumeLayout(false);
         this.tabRec.PerformLayout();
         this.tabCir.ResumeLayout(false);
         this.tabCir.PerformLayout();
         this.tabHex.ResumeLayout(false);
         this.tabHex.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();
      }
      private System.Windows.Forms.TextBox tbNRec;
      private System.Windows.Forms.TabPage tabCir;
      private System.Windows.Forms.TextBox tbNCir;
      private System.Windows.Forms.TextBox tbNHex;
      private System.Windows.Forms.TextBox tbDInn;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox tbDOut;
      private System.Windows.Forms.Button btCancel;
      private System.Windows.Forms.Button btOk;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TabPage tabHex;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TabPage tabRec;
      private System.Windows.Forms.TabControl tabControl1;
   }
}
