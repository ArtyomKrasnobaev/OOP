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
    /// <summary>
    /// Форма для ввода параметров равноускоренного движения.
    /// </summary>
    public partial class AcceleratedMotionUserControl : UserControl
    {
        /// <summary>
        /// Конструктор класса AcceleratedMotionUserControl.
        /// </summary>
        public AcceleratedMotionUserControl()
        {
            InitializeComponent();

            initialValueTextBox.KeyPress += PressTextBox;

            timeTextBox.KeyPress += PressTextBox;

            velocityTextBox.KeyPress += PressTextBox;

            accelerationTextBox.KeyPress += PressTextBox;
        }

        /// <summary>
        /// Метод проверки введенных символов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PressTextBox(object sender, KeyPressEventArgs e)
        {
            TextBoxReader.CheckInput(e);
        }
    }
}
