using Model;
namespace View
{
    /// <summary>
    /// Форма для добавления движения.
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        /// Конструктор класса AddForm.
        /// </summary>
        public AddForm()
        {
            InitializeComponent();

            cancelButton.Click += ClickCancelButton;

            constantMotionRadioButton.CheckedChanged += ChangeConstantMotionStatus;

            acceleratedMotionRadioButton.CheckedChanged += ChangeAcceleratedMotionStatus;

            oscillatoryMotionRadioButton.CheckedChanged += ChangeOscillatoryMotionStatus;

            addButton.Click += ClickAddButton;
        }

        /// <summary>
        /// Событие добавления движения.
        /// </summary>
        public EventHandler MotionAdded;

        /// <summary>
        /// Метод изменения статуса равномерного движения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeConstantMotionStatus(object sender, EventArgs e)
        {
            constantMotionUserControl1.Visible = true;
            acceleratedMotionUserControl1.Visible = false;
            oscillatoryMotionUserControl1.Visible = false;
        }

        /// <summary>
        /// Метод изменения статуса равноускоренного движения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeAcceleratedMotionStatus(object sender, EventArgs e)
        {
            constantMotionUserControl1.Visible = false;
            acceleratedMotionUserControl1.Visible = true;
            oscillatoryMotionUserControl1.Visible = false;
        }

        /// <summary>
        /// Метод изменения статуса колебательного движения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeOscillatoryMotionStatus(object sender, EventArgs e)
        {
            constantMotionUserControl1.Visible = false;
            acceleratedMotionUserControl1.Visible = false;
            oscillatoryMotionUserControl1.Visible = true;
        }

        private void ClickAddButton(object sender, EventArgs e)
        {
            try
            {
                MotionBase motionBase = null;

                if (constantMotionUserControl1.Visible)
                {
                    motionBase = new ConstantMotion()
                    {
                        InitialValue = Convert.ToDouble(constantMotionUserControl1.initialValueTextBox.Text),
                        Time = Convert.ToDouble(constantMotionUserControl1.timeTextBox.Text),
                        Velocity = Convert.ToDouble(constantMotionUserControl1.velocityTextBox.Text),
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
            catch
            {
                MessageBox.Show("Введите корректные данные.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку "Закрыть".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCancelButton(object sender, EventArgs e)
        {
            Close();
        }
    }
}
 