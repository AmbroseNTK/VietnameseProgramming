using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;

namespace VietnameseProgramming
{
    class GroupFormat
    {
        private Font font;
        private List<string> listData;
        private Color backgroundColor;
        private Color foreColor;

        public Font Font { get => font; set => font = value; }
        public List<string> ListData { get => listData; set => listData = value; }
        public Color BackgroundColor { get => backgroundColor; set => backgroundColor = value; }
        public Color ForeColor { get => foreColor; set => foreColor = value; }

        public GroupFormat()
        {
            font = new Font(FontFamily.GenericSerif,9,FontStyle.Regular,GraphicsUnit.Pixel);
        }
    }
}
