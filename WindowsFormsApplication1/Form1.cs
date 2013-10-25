using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Image<Bgr, Byte> My_Image1;
        private Image<Bgr, Byte> My_Image2;

        public Form1()
        {
            InitializeComponent();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                //Load the Image
                My_Image1 = new Image<Bgr, byte>(Openfile.FileName);

                //Display the Image
                pictureBox1.Image = My_Image1.ToBitmap();
                My_Image1.Split();

            }
        }

        private void app1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}