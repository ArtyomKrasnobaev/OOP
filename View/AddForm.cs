using Model;
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

        public EventHandler MotionAdded;

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

        private void AgreeButtonClick(object sender, EventArgs e)
        {
            MotionBase motionBase = null;

            if (constantMotionUserControl1.Visible)
            {
                motionBase = new ConstantMotion()
                {
                    InitialValue = Convert.ToDouble(constantMotionUserControl1.textBox1.Text),
                    Time = Convert.ToDouble(constantMotionUserControl1.textBox2.Text),
                    Velocity = Convert.ToDouble(constantMotionUserControl1.textBox3.Text),
                };
            }

            if (acceleratedMotionUserControl1.Visible)
            {
                motionBase = new AcceleratedMotion()
                {
                    InitialValue = Convert.ToDouble(acceleratedMotionUserControl1.initialValueTextBox.Text),
                    Time = Convert.ToDouble(acceleratedMotionUserControl1.timeTextBox.Text),
                    Velocity = Convert.ToDouble(acceleratedMotionUserControl1.velocityTextBox.Text),
                    Acceleration = Convert.ToDouble(acceleratedMotionUserControl1.accelerationTextBox.Text),
                };
            }

            if (oscillatoryMotionUserControl1.Visible)
            {
                motionBase = new OscillatoryMotion()
                {
                    InitialValue = Convert.ToDouble(oscillatoryMotionUserControl1.initialValueTextBox.Text),
                    Time = Convert.ToDouble(oscillatoryMotionUserControl1.timeTextBox.Text),
                    Amplitude = Convert.ToDouble(oscillatoryMotionUserControl1.amplitudeTextBox.Text),
                    Frequency = Convert.ToDouble(oscillatoryMotionUserControl1.frequencyTextBox.Text),
                };
            }

            MotionAdded?.Invoke(this,
                new MotionAddedEvent(motionBase));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
