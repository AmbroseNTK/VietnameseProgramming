using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietnameseProgramming
{
    public partial class InputElement : UserControl
    {
        private string data;

        public string Data
        {
            get => data;
            set
            {
                data = value;
                lbData.Text = data;
            }
        }

        public InputElement()
        {
            InitializeComponent();
            this.Size = lbData.Size;
        }
        
        private void label1_SizeChanged(object sender, EventArgs e)
        {
            this.Size = lbData.Size;
        }

        private void InputElement_Load(object sender, EventArgs e)
        {

        }
    }
}
