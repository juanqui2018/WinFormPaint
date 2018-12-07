using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace juanCarlos.Paint
{
    public partial class MiHijo : Form
    {



        //using (Bitmap bitmap = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height)) 

        ////public Image img = 
        //public Bitmap bitmap = new Bitmap(pnl_Draw.ClientSize.Width, pnl_Draw.ClientSize.Height);
        ////    public Image img = pnl_Draw
        ////    {
        ////        get { return img.jpg; }
        ////set { img.png = value; }
        ////    }
        //public Image img;
        //public dynamic img { get; set; }

        public Bitmap unobitMap { get; set; }
        public Rectangle dos;
        

        public MiHijo()
        {
            InitializeComponent();
            g = pnl_Draw.CreateGraphics();

            int width = pnl_Draw.Width;
            int height = pnl_Draw.Height;
            Bitmap bitMap = new Bitmap(width, height);
            Rectangle rec = new Rectangle(0, 0, width, height);

            pnl_Draw.DrawToBitmap(bitMap, rec);
            unobitMap = bitMap;
            dos = rec;
        }
        

        bool startPaint = false;
        Graphics g;
        int? initX = null;
        int? initY = null;
        bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false;
        bool drawEllipse = false;
        private object sfdSave;

        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                Pen p = new Pen(btn_PenColor.BackColor, float.Parse(cmb_PenSize.Text));
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }

        private void pnl_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
                SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                g.FillRectangle(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {
                SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawRectangle = false;
            }
            if (drawCircle)
            {
                SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawCircle = false;
            }
            if (drawEllipse)
            {
                Pen p = new Pen(btn_PenColor.BackColor);
                g.DrawEllipse(p, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawEllipse = false;
            }
        }

        private void pnl_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                btn_PenColor.BackColor = c.Color;
            }
        }

        private void btn_Square_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }

        private void btn_Elipse_Click(object sender, EventArgs e)
        {
            drawEllipse = true;
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pnl_Draw.Width, pnl_Draw.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = pnl_Draw.RectangleToScreen(pnl_Draw.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, pnl_Draw.Size);
            g.Dispose();
            SfdFile.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (SfdFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(SfdFile.FileName))
                {
                    File.Delete(SfdFile.FileName);
                }
                if (SfdFile.FileName.Contains(".jpg"))
                {
                    bmp.Save(SfdFile.FileName, ImageFormat.Jpeg);
                }
                else if (SfdFile.FileName.Contains(".png"))
                {
                    bmp.Save(SfdFile.FileName, ImageFormat.Png);
                }
                else if (SfdFile.FileName.Contains(".bmp"))
                {
                    bmp.Save(SfdFile.FileName, ImageFormat.Bmp);
                }
                MessageBox.Show("Se guardó correctamente", "Save");
            }
        }
        public bool ThumbnailCallback()
        {
            return false;
        }
        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
            "All files (*.*)|*.*";

            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select Photos";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    try
                    {
                        PictureBox imageControl = new PictureBox();
                        imageControl.Height = pnl_Draw.Height;
                        imageControl.Width = pnl_Draw.Width;

                        Image.GetThumbnailImageAbort myCallback =
                                new Image.GetThumbnailImageAbort(ThumbnailCallback);
                        Bitmap myBitmap = new Bitmap(file);
                        Image myThumbnail = myBitmap.GetThumbnailImage(pnl_Draw.Height, pnl_Draw.Width,
                            myCallback, IntPtr.Zero);
                        imageControl.Image = myThumbnail;
                        
                        pnl_Draw.Controls.Add(imageControl);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
