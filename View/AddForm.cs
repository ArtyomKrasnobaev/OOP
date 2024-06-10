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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void constantMotionButton_CheckedChanged(object sender, EventArgs e)
        {
            constantMotionUserControl1.Visible = true;
            acceleratedMotionUserControl1.Visible = false;
            oscillatoryMotionUserControl1.Visible = false;
        }

        private void acceleratedMotionButton_CheckedChanged(object sender, EventArgs e)
        {
            constantMotionUserControl1.Visible = false;
            acceleratedMotionUserControl1.Visible = true;
            oscillatoryMotionUserControl1.Visible = false;
        }

        private void oscillatedMotionButton_CheckedChanged(object sender, EventArgs e)
        {
            constantMotionUserControl1.Visible = false;
            acceleratedMotionUserControl1.Visible = false;
            oscillatoryMotionUserControl1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
