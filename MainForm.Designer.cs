/*
 * Utworzone przez SharpDevelop.
 * Użytkownik: admin
 * Data: 2012-05-29
 * Godzina: 14:05
 * 
 * Do zmiany tego szablonu użyj Narzędzia | Opcje | Kodowanie | Edycja Nagłówków Standardowych.
 */
namespace HamaBeads
{
   partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorTłaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazTłaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pustyObrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(456, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Rec",
            "Cir",
            "Hex"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(160, 28);
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.ToolStripComboBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(456, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorToolStripMenuItem,
            this.kolorTłaToolStripMenuItem,
            this.obrazTłaToolStripMenuItem,
            this.pustyObrazToolStripMenuItem,
            this.konfiguracjaToolStripMenuItem,
            this.koniecCtrlXToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // kolorToolStripMenuItem
            // 
            this.kolorToolStripMenuItem.Name = "kolorToolStripMenuItem";
            this.kolorToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.kolorToolStripMenuItem.Text = "Kolor";
            this.kolorToolStripMenuItem.Click += new System.EventHandler(this.KolorToolStripMenuItem_Click);
            // 
            // kolorTłaToolStripMenuItem
            // 
            this.kolorTłaToolStripMenuItem.Name = "kolorTłaToolStripMenuItem";
            this.kolorTłaToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.kolorTłaToolStripMenuItem.Text = "Kolor tła";
            this.kolorTłaToolStripMenuItem.Click += new System.EventHandler(this.KolorTłaToolStripMenuItem_Click);
            // 
            // obrazTłaToolStripMenuItem
            // 
            this.obrazTłaToolStripMenuItem.Name = "obrazTłaToolStripMenuItem";
            this.obrazTłaToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.obrazTłaToolStripMenuItem.Text = "Obraz tła";
            this.obrazTłaToolStripMenuItem.Click += new System.EventHandler(this.ObrazTłaToolStripMenuItem_Click);
            // 
            // pustyObrazToolStripMenuItem
            // 
            this.pustyObrazToolStripMenuItem.Name = "pustyObrazToolStripMenuItem";
            this.pustyObrazToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.pustyObrazToolStripMenuItem.Text = "Pusty obraz";
            this.pustyObrazToolStripMenuItem.Click += new System.EventHandler(this.PustyObrazToolStripMenuItem_Click);
            // 
            // konfiguracjaToolStripMenuItem
            // 
            this.konfiguracjaToolStripMenuItem.Name = "konfiguracjaToolStripMenuItem";
            this.konfiguracjaToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.konfiguracjaToolStripMenuItem.Text = "Konfiguracja";
            this.konfiguracjaToolStripMenuItem.Click += new System.EventHandler(this.KonfiguracjaToolStripMenuItem_Click);
            // 
            // koniecCtrlXToolStripMenuItem
            // 
            this.koniecCtrlXToolStripMenuItem.Name = "koniecCtrlXToolStripMenuItem";
            this.koniecCtrlXToolStripMenuItem.ShortcutKeyDisplayString = "Alt-F4";
            this.koniecCtrlXToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.koniecCtrlXToolStripMenuItem.Text = "Koniec";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(359, 342);
            this.Name = "MainForm";
            this.Text = "HamaBeads";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }
      private System.Windows.Forms.ToolStripMenuItem koniecCtrlXToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem konfiguracjaToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem pustyObrazToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem obrazTłaToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem kolorTłaToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem kolorToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolTip toolTip1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
      private System.Windows.Forms.ToolStrip toolStrip1;
      
   }
}
