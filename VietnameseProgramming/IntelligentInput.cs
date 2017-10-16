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
    public partial class IntelligentInput : UserControl
    {
        int currentRow;
        int currentCol;
        GroupFormat keyword;
        List<InputElement> inputElement;
        public IntelligentInput()
        {
            InitializeComponent();
        }
        public void AddNewElementToControl(InputElement element)
        {
            if (element.Width + element.Location.X > this.Width)
            {
                currentRow++;
                currentCol = 0;
            }
            if (inputElement.Count == 1)
            {
                element.Location = new Point(0, currentRow * element.Height);
            }
            this.Controls.Add(element);
            
        }
        private void IntelligentInput_Load(object sender, EventArgs e)
        {
            currentRow =0;
            inputElement = new List<InputElement>();
            inputElement.Add(new InputElement());
            AddNewElementToControl(inputElement[0]);
            keyword = new GroupFormat();
            keyword.BackgroundColor = Color.White;
            keyword.ForeColor = Color.DodgerBlue;

        }

        private void IntelligentInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

            }
            
        }

        private void IntelligentInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            inputElement[inputElement.Count - 1].Data += e.KeyChar;
        }
    }
}
