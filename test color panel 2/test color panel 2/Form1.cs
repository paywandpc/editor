using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;
namespace test_color_panel_2
{
    public partial class Form1 : Form
    {

        string Hex;
        Color paintcolor;
        bool choose = false;
        bool draw = false;
        int x, y, lx, ly = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            choose = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (choose)
            {
                Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
                paintcolor = bmp.GetPixel(e.X, e.Y);
                trackBar1.Value = paintcolor.R;
                trackBar2.Value = paintcolor.G;
                trackBar3.Value = paintcolor.B;
                trackBar4.Value = paintcolor.A;
                textBox1.Text = paintcolor.R.ToString();
                textBox2.Text = paintcolor.G.ToString();
                textBox3.Text = paintcolor.B.ToString();
                textBox4.Text = paintcolor.A.ToString();
                pictureBox2.BackColor = paintcolor;
                Hex = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}", trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
                textBox4.Text = "#" + Hex;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            choose = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            pictureBox2.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
            Hex = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}", trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
            textBox4.Text = "#" + Hex;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
            pictureBox2.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
            Hex = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}", trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
            textBox4.Text = "#" + Hex;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar3.Value.ToString();
            pictureBox2.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
            Hex = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}", trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
            textBox4.Text = "#" + Hex;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = trackBar4.Value.ToString();
            pictureBox2.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
            Hex = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}", trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
            textBox4.Text = "#" + Hex;
        
        }
    }
}
