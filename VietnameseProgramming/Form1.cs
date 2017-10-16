using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietnameseProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private VieCompiler compiler;
        private void Form1_Load(object sender, EventArgs e)
        {
            lbApplicationName.Text = Text;
            picIco.Image = Icon.ToBitmap();
            compiler = new VieCompiler();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        #region Drag my custom form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void TopDock_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void tbFunction_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                switch (tbFunction.Text.ToLower())
                {
                    case "thoát":
                        Application.Exit();
                        break;
                    case "phóng to":
                        WindowState = FormWindowState.Maximized;
                        break;
                    case "thu nhỏ":
                        WindowState = FormWindowState.Minimized;
                        break;
                    case "mặc định":
                        WindowState = FormWindowState.Normal;
                        break;
                    case "khởi động lại":
                        Application.Restart();
                        break;
                    case "dịch":
                        compiler.SourceInput = tbNativeCode.Text;
                        compiler.compile();
                        tbCPP.Text = compiler.SourceOut;
                        break;
                }
        }
    }

}
