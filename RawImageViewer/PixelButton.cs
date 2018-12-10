using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RawImageViewer
{
    public class PixelButtonArray
    {
        FlowLayoutPanel pPixelPanel;

        public PixelButtonArray(FlowLayoutPanel panel, int init_size = 16)
        {
            pPixelPanel = panel;

            for(int cnt=0; cnt<init_size; cnt++)
            {
                PixelButton button = new PixelButton();
                pPixelPanel.Controls.Add(button);
            }
        }

        public void setPixelSize(int size)
        {
            while(pPixelPanel.Controls.Count < size)
            {
                PixelButton button = new PixelButton();
                pPixelPanel.Controls.Add(button);
            }

            while (pPixelPanel.Controls.Count > size)
            {
                pPixelPanel.Controls.RemoveAt(pPixelPanel.Controls.Count - 1);
            }
        }
    }

    public class PixelButton : Button
    {
        public Color OwnColor
        {
            get
            {
                return this.BackColor;
            }
        }


        public PixelButton()
            : base()
        {
            this.Width = this.Height;
            // set whatever styling properties needed here
            this.Click += new EventHandler(MyButton_Click);
            this.BackColor = Color.White;
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            if(this.BackColor == Color.Red)
            {
                this.BackColor = Color.Green;
            }
            else if(this.BackColor == Color.Green)
            {
                this.BackColor = Color.Blue;
            }
            else if (this.BackColor == Color.Blue)
            {
                this.BackColor = Color.White;
            }
            else if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }
}
