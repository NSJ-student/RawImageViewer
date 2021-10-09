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

namespace RawImageViewer
{
    public partial class Form1 : Form
    {
        public enum dc1394error_t
        {
            DC1394_SUCCESS = 0,
            DC1394_FAILURE = -1,
            DC1394_NOT_A_CAMERA = -2,
            DC1394_FUNCTION_NOT_SUPPORTED = -3,
            DC1394_CAMERA_NOT_INITIALIZED = -4,
            DC1394_MEMORY_ALLOCATION_FAILURE = -5,
            DC1394_TAGGED_REGISTER_NOT_FOUND = -6,
            DC1394_NO_ISO_CHANNEL = -7,
            DC1394_NO_BANDWIDTH = -8,
            DC1394_IOCTL_FAILURE = -9,
            DC1394_CAPTURE_IS_NOT_SET = -10,
            DC1394_CAPTURE_IS_RUNNING = -11,
            DC1394_RAW1394_FAILURE = -12,
            DC1394_FORMAT7_ERROR_FLAG_1 = -13,
            DC1394_FORMAT7_ERROR_FLAG_2 = -14,
            DC1394_INVALID_ARGUMENT_VALUE = -15,
            DC1394_REQ_VALUE_OUTSIDE_RANGE = -16,
            DC1394_INVALID_FEATURE = -17,
            DC1394_INVALID_VIDEO_FORMAT = -18,
            DC1394_INVALID_VIDEO_MODE = -19,
            DC1394_INVALID_FRAMERATE = -20,
            DC1394_INVALID_TRIGGER_MODE = -21,
            DC1394_INVALID_TRIGGER_SOURCE = -22,
            DC1394_INVALID_ISO_SPEED = -23,
            DC1394_INVALID_IIDC_VERSION = -24,
            DC1394_INVALID_COLOR_CODING = -25,
            DC1394_INVALID_COLOR_FILTER = -26,
            DC1394_INVALID_CAPTURE_POLICY = -27,
            DC1394_INVALID_ERROR_CODE = -28,
            DC1394_INVALID_BAYER_METHOD = -29,
            DC1394_INVALID_VIDEO1394_DEVICE = -30,
            DC1394_INVALID_OPERATION_MODE = -31,
            DC1394_INVALID_TRIGGER_POLARITY = -32,
            DC1394_INVALID_FEATURE_MODE = -33,
            DC1394_INVALID_LOG_TYPE = -34,
            DC1394_INVALID_BYTE_ORDER = -35,
            DC1394_INVALID_STEREO_METHOD = -36,
            DC1394_BASLER_NO_MORE_SFF_CHUNKS = -37,
            DC1394_BASLER_CORRUPTED_SFF_CHUNK = -38,
            DC1394_BASLER_UNKNOWN_SFF_CHUNK = -39
        };

        public enum dc1394bayer_method_t
        {
            DC1394_BAYER_METHOD_NEAREST = 0,
            DC1394_BAYER_METHOD_SIMPLE,
            DC1394_BAYER_METHOD_BILINEAR,
            DC1394_BAYER_METHOD_HQLINEAR,
            DC1394_BAYER_METHOD_DOWNSAMPLE,
            DC1394_BAYER_METHOD_EDGESENSE,
            DC1394_BAYER_METHOD_VNG,
            DC1394_BAYER_METHOD_AHD
        };

        public enum dc1394color_filter_t
        {
            DC1394_COLOR_FILTER_RGGB = 512,
            DC1394_COLOR_FILTER_GBRG,
            DC1394_COLOR_FILTER_GRBG,
            DC1394_COLOR_FILTER_BGGR
        };

        [DllImport("bayer2rgb.dll")]
        public static extern dc1394error_t dc1394_bayer_decoding_8bit (IntPtr bayer, IntPtr rgb, UInt32 sx, UInt32 sy, dc1394color_filter_t tile, dc1394bayer_method_t method);

        [DllImport("bayer2rgb.dll")]
        public static extern dc1394error_t dc1394_bayer_decoding_16bit (IntPtr bayer, IntPtr rgb, UInt32 sx, UInt32 sy, dc1394color_filter_t tile, dc1394bayer_method_t method, UInt32 bits);

        PixelButtonArray pixelArray;
        Bitmap resBmp;

        public Form1()
        {
            InitializeComponent();

            resBmp = null;
            pixelArray = new PixelButtonArray(flpPixelButton, 16);
        }

        private void btnPixelSet_Click(object sender, EventArgs e)
        {
            resBmp = new Bitmap(Convert.ToInt32(tbWidth.Text), Convert.ToInt32(tbHeight.Text));
            //Invalidate(true);
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
            if(resBmp != null)
            {
                Pen pen = new Pen(Color.Red);
                e.Graphics.DrawRectangle(pen, 0, 0, resBmp.Width, resBmp.Height);
                e.Graphics.DrawImage((Image)resBmp, 0, 0);
            }
        }

        private void pResult_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pResult_MouseMove(object sender, MouseEventArgs e)
        {
            if (resBmp != null)
            {
                resBmp.SetPixel(e.X, e.Y, Color.Red);
                //Invalidate(true);
            }
        }

        private void pResult_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
