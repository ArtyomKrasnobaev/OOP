using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ConstantMotionUserControl : UserControl
    {
        public ConstantMotionUserControl()
        {
            InitializeComponent();

            initialValueTextBox.KeyPress += PressTextBox;

            timeTextBox.KeyPress += PressTextBox;

            velocityTextBox.KeyPress += PressTextBox;
        }

        private void PressTextBox(object sender, KeyPressEventArgs e)
        {
            TextBoxReader.CheckInput(e);
        }
    }
}
