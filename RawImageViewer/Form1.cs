using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawImageViewer
{
    public partial class Form1 : Form
    {
        PixelButtonArray pixelArray;
        Bitmap resBmp;

        public Form1()
        {
            InitializeComponent();

            pixelArray = new PixelButtonArray(flpPixelButton, 16);
        }

        private void btnPixelSet_Click(object sender, EventArgs e)
        {
            resBmp = new Bitmap(Convert.ToInt32(tbWidth.Text), Convert.ToInt32(tbHeight.Text));

            //panel1.BackgroundImage = (Image)bmp;
            //panel1.BackgroundImageLayout = ImageLayout.None;
            //bmp.SetPixel(15, 15, Color.Red); bmp.SetPixel(16, 16, Color.Red);

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Raw Files(*.raw)|*.raw";

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbImagePath.Text = dialog.FileName;
            }
        }

        private void tbPixelSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar == Keys.Enter)
            {
                int size = Convert.ToInt32(tbPixelSize.Text);

                if(size > 32)
                {
                    size = 32;
                    tbPixelSize.Text = size.ToString();
                }

                if(size % 8 != 0)
                {
                    tbPixelSize.Text = ((int)((size + 4)/8) * 8).ToString();

                    size = Convert.ToInt32(tbPixelSize.Text);
                }

                pixelArray.setPixelSize(size);
            }
        }

        private void pResult_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.draw
        }
    }
}
