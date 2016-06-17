/*
 * Utworzone przez SharpDevelop.
 * Użytkownik: admin
 * Data: 2012-05-29
 * Godzina: 14:05
 * 
 * Do zmiany tego szablonu użyj Narzędzia | Opcje | Kodowanie | Edycja Nagłówków Standardowych.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace HamaBeads
{
   /// <summary>
   /// Description of MainForm.
   /// </summary>
   public partial class MainForm : Form
   {
      private OptionsDlg options = null;
      public static HamaSettings settings = new HamaSettings();
      private Color beadColor = Color.Blue;
      private Color bkgColor = Color.Wheat;
      private ArrayList beadsCir = new System.Collections.ArrayList();
      private ArrayList beadsHex = new System.Collections.ArrayList();
      private ArrayList beadsRec = new System.Collections.ArrayList();
//      Bitmap bmp = null;
      
      public MainForm()
      {
//         settings.Reset();
         
         //
         // The InitializeComponent() call is required for Windows Forms designer support.
         //
         InitializeComponent();
         
         //
         // TODO: Add constructor code after the InitializeComponent() call.
         //
         toolStripComboBox1.SelectedText = settings.BoardType;
         toolStripComboBox1.Text = settings.BoardType;
      }
      
      void InitBoard(bool force)
      {
         switch (settings.BoardType)
         {
            case "Cir": InitCircleBoard(force); break;
            case "Hex": InitHexBoard(force); break;
            default:    InitRectBoard(force); break;
         }
      }
      
      void ToolStripComboBox1_TextChanged(object sender, EventArgs e)
      {
         settings.BoardType = toolStripComboBox1.Text;
         InitBoard(true);
         Invalidate();
      }
      
      void DrawBead(Graphics gr, int x, int y, Color clr)
      {
         Pen pn = new Pen(clr, (float)((settings.DOut - settings.DInn) / 2.0));
         gr.DrawEllipse(pn, x - settings.DOut / 2, y - settings.DOut / 2, settings.DOut, settings.DOut);
      }

      private void InitCircleBoard(bool force)
      {
         if (!force && beadsCir != null && beadsCir.Count > 0) return;
         int w = Bead.scale;
         int h = Bead.scale;
         int l = Math.Min(w, h);
         int x0 = l / 2;
         int y0 = l / 2;
         int D =  (int)(l / (settings.SizeCir + 1));
         int x;
         int y;
         int xp;
         int yp;
         beadsCir.Clear();
         Color clr = beadColor;
         Bitmap bmp = null;
         if (pictureBox1.Image != null)
            bmp = new Bitmap(pictureBox1.Image);
         beadsCir = new ArrayList();
         if (bmp != null)
         {
            xp = x0 * bmp.Width  / Bead.scale;
            yp = y0 * bmp.Height / Bead.scale;
            clr = bmp.GetPixel(xp, yp);
         }
         beadsCir.Add(new Bead(x0, y0, clr));
         for(int i = 1; i <= settings.SizeCir; i++)
         {
            int r = i * D / 2;
            for(int t = 0; t < i * 6; t++)
            {
               x = x0 + (int)(r * Math.Cos((float)t/i/3.0*Math.PI));
               y = y0 + (int)(r * Math.Sin((float)t/i/3.0*Math.PI));
               clr = beadColor;
               if (bmp != null)
               {
                  xp = x * bmp.Width  / Bead.scale;
                  yp = y * bmp.Height / Bead.scale;
                  try {
                     clr = bmp.GetPixel(xp, yp);
                  } catch (Exception ex)
                  {
                     System.Console.WriteLine(ex.Message);
                  }
               }
               beadsCir.Add(new Bead(x, y, clr));
            }
         }
      }
      
      private void DrawCircleBoard2(Graphics gr, int w, int h)
      {
         int l = Math.Min(w, h);
         int x0 = l / 2;
         int y0 = l / 2;
         int D = (int)((l - 3 * settings.DOut) / settings.SizeCir);
         
         SolidBrush br = new SolidBrush(bkgColor);
         gr.FillEllipse(br, x0 - D * settings.SizeCir / 2 - settings.DOut, y0 - D * settings.SizeCir /2 - settings.DOut, 
                                 D * settings.SizeCir + 2 * settings.DOut, D * settings.SizeCir + 2 * settings.DOut);
         foreach(Bead bd in beadsCir)
         {
            bd.Draw(gr, l, l);
         }
      }
      
      private void DrawCircleBoard(Graphics gr, int w, int h)
      {
         int x0 = w / 2;
         int y0 = h / 2;
         int D = (int)((Math.Min(w, h) - 3 * settings.DOut) / settings.SizeCir);
         SolidBrush br = new SolidBrush(bkgColor);
//         gr.FillEllipse(br, x0 - D * n / 2 - d, y0 - D * n /2 - d, 
//                                   D * n + 2 * d, D * n + 2 * d);
         DrawBead(gr, x0, y0, beadColor);
         for(int i = 1; i <= settings.SizeCir; i++)
         {
            int r = i * D / 2;
            for(int t = 0; t < i * 6; t++)
            {
               DrawBead(gr, x0 + (int)(r * Math.Cos((float)t/i/3.0*Math.PI)),
                            y0 + (int)(r * Math.Sin((float)t/i/3.0*Math.PI)),
                           beadColor);
            }
         }
      }
      
      private void InitHexBoard(bool force)
      {
         if (!force && beadsCir != null && beadsCir.Count > 0) return;
         int w = Bead.scale;
         int h = Bead.scale;
         int D = (int)((Math.Min(w, h * 2 / Math.Sqrt(3)) - 3 * settings.DOut) / settings.SizeHex);
         float DY = (float)(D * Math.Sqrt(3) / 2);
         int x;
         int y;
         int xp;
         int yp;
         beadsHex.Clear();
         Color clr = beadColor;
         Bitmap bmp = null;
         if (pictureBox1.Image != null)
            bmp = new Bitmap(pictureBox1.Image);
         beadsHex = new ArrayList();

         for(int iy = 0; iy < settings.SizeHex; iy++)
         {
            y = (int)(iy * DY + D / 2);
            for(int ix = 0; ix < settings.SizeHex; ix++)
            {
               x = (int)(ix * D + (D * (iy % 2) / 2 + D / 2));
               if (bmp != null)
               {
                  xp = x * bmp.Width  / Bead.scale;
                  yp = y * bmp.Height / Bead.scale;
                  clr = bmp.GetPixel(xp, yp);
               }
               beadsHex.Add(new Bead(x, y, clr));
            }
         }
      }

      private void DrawHexBoard2(Graphics gr, int w, int h)
      {
         int l = Math.Min(w, h);
         int D = (int)((Math.Min(w, h * 2 / Math.Sqrt(3)) - 3 * settings.DOut) / settings.SizeHex);
         float DY = (float)(D * Math.Sqrt(3) / 2);
         
         SolidBrush br = new SolidBrush(bkgColor);

         gr.FillRectangle(br, D / 2 - settings.DOut, DY/2 - settings.DOut, 
                          D * settings.SizeHex - D / 2 + 2 * settings.DOut, DY * settings.SizeHex - DY / 2 + 2 * settings.DOut);

         foreach(Bead bd in beadsHex)
         {
            bd.Draw(gr, l, l);
         }
      }

      private void DrawHexBoard(Graphics gr, int w, int h)
      {
         int D = (int)((Math.Min(w, h * 2 / Math.Sqrt(3)) - 3 * settings.DOut) / settings.SizeHex);
         float DY = (float)(D * Math.Sqrt(3) / 2);
         SolidBrush br = new SolidBrush(bkgColor);
//         gr.FillRectangle(br, D / 2 - d, DY/2 - d, 
//                          D * n - D / 2 + 2 * d, DY * n - DY / 2 + 2 * d);
         for(int x = 0; x < settings.SizeHex; x++)
         {
            for(int y = 0; y < settings.SizeHex; y++)
            {
               DrawBead(gr, (int)(x * D + (D * (y % 2) / 2 + D / 2)),
                            (int)(y * DY + D / 2), beadColor);
            }
         }
      }
      
      private void InitRectBoard(bool force)
      {
         if (!force && beadsCir != null && beadsCir.Count > 0) return;
         int w = Bead.scale;
         int h = Bead.scale;
         int D = (int)((Math.Min(w, h)) / settings.SizeRec);
         float DY = (float)(D * Math.Sqrt(3) / 2);
         int x;
         int y;
         int xp;
         int yp;
         beadsRec.Clear();
         Color clr = beadColor;
         Bitmap bmp = null;
         if (pictureBox1.Image != null)
            bmp = new Bitmap(pictureBox1.Image);
         beadsRec = new ArrayList();

         for(int iy = 0; iy < settings.SizeRec; iy++)
         {
            y = iy * D + D / 2;
            for(int ix = 0; ix < settings.SizeRec; ix++)
            {
               x = ix * D + D / 2;
               if (bmp != null)
               {
                  xp = x * bmp.Width  / Bead.scale;
                  yp = y * bmp.Height / Bead.scale;
                  clr = bmp.GetPixel(xp, yp);
               }
               beadsRec.Add(new Bead(x, y, clr));
            }
         }
      }
      
      private void DrawRectBoard(Graphics gr, int w, int h)
      {
         int D = (int)((Math.Min(w, h)) / settings.SizeRec);
         SolidBrush br = new SolidBrush(bkgColor);
//         gr.FillRectangle(br, D / 2 - d, D/2 - d, 
//                                     D * n - D + 2 * d, D * n - D + 2 * d);
         for(int x = 0; x < settings.SizeRec; x++)
         {
            for(int y = 0; y < settings.SizeRec; y++)
            {
               DrawBead(gr, x * D + D / 2, 
                            y * D + D / 2, beadColor);
            }
         }
      }

      private void DrawRectBoard2(Graphics gr, int w, int h)
      {
         int l = Math.Min(w, h);
         int D = (int)((Math.Min(w, h)) / settings.SizeRec);
         SolidBrush br = new SolidBrush(bkgColor);
         gr.FillRectangle(br, D / 2 - settings.DOut, D/2 - settings.DOut, 
                                     D * settings.SizeRec - D + 2 * settings.DOut, D * settings.SizeRec - D + 2 * settings.DOut);
         foreach(Bead bd in beadsRec)
         {
            bd.Draw(gr, l, l);
         }
      }
      
      void MainForm_Paint(object sender, PaintEventArgs e)
      {
         int w = pictureBox1.Width;
         int h = pictureBox1.Height;
         Graphics gr = pictureBox1.CreateGraphics();
//         SolidBrush br = new SolidBrush(bkgColor);
         gr.FillRectangle(SystemBrushes.ButtonFace, 0, 0, w, h);
         pictureBox1.Refresh();
         gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
         gr.DrawString(settings.BoardType, DefaultFont, Brushes.DarkRed, 10, 10);
         switch (settings.BoardType)
         {
            case "Cir":
               DrawCircleBoard2(gr, w, h);
               break;
            case "Hex": 
               DrawHexBoard2(gr, w, h);
               break;
            default:
               DrawRectBoard2(gr, w, h);
               break;
         }
      }
      
      void KolorToolStripMenuItem_Click(object sender, EventArgs e)
      {
         ColorDialog clrDlg = new ColorDialog();
         clrDlg.Color = beadColor;
         if (clrDlg.ShowDialog() == DialogResult.OK)
         {
            beadColor = clrDlg.Color;
            Invalidate();
         }
      }
      
      void KolorTłaToolStripMenuItem_Click(object sender, EventArgs e)
      {
         ColorDialog clrDlg = new ColorDialog();
         clrDlg.Color = bkgColor;
         if (clrDlg.ShowDialog() == DialogResult.OK)
         {
            bkgColor = clrDlg.Color;
            Invalidate();
         }
      }
      
      public class Bead
      {
         public static int scale = 10000;
         public int x;
         public int y;
         public Color clr;
         public bool hollow;
         
         public Bead(int x0, int y0, Color clr0)
         {
            x = x0;
            y = y0;
            clr = clr0;
            hollow = false;
         }
         
         public void Draw(Graphics gr, int w, int h)
         {
            if (!hollow) 
            {
               Pen pn = new Pen(clr, (float)((MainForm.settings.DOut - settings.DInn) / 2.0));
               gr.DrawEllipse(pn, x * w / scale - MainForm.settings.DOut / 2, 
                                  y * h / scale - MainForm.settings.DOut / 2, 
                                  MainForm.settings.DOut, MainForm.settings.DOut);
            }
         }
      }
      
      void ObrazTłaToolStripMenuItem_Click(object sender, EventArgs e)
      {
         OpenFileDialog ofdlg = new OpenFileDialog();
         ofdlg.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png|All files (*.*)|*.*";
         if (ofdlg.ShowDialog() == DialogResult.OK)
         {
            pictureBox1.Load(ofdlg.FileName);
            InitBoard(true);
         }
      }
      
      void PustyObrazToolStripMenuItem_Click(object sender, EventArgs e)
      {
         pictureBox1.Image = null;
      }

      void KonfiguracjaToolStripMenuItem_Click(object sender, System.EventArgs e)
      {
         if (options == null)
            options = new OptionsDlg();
         options.ShowDialog();
      }

      
      void MainForm_FormClosed(object sender, FormClosedEventArgs e)
      {
         settings.BackColor = Color.Blue;
         settings.Save();
      }
   }
}
