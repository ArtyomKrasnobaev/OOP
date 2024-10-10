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

            _cancelButton.Click += ClickCancelButton;

            _constantMotionRadioButton.CheckedChanged +=
                ChangeConstantMotionStatus;

            _acceleratedMotionRadioButton.CheckedChanged +=
                ChangeAcceleratedMotionStatus;

            _oscillatoryMotionRadioButton.CheckedChanged +=
                ChangeOscillatoryMotionStatus;

            _addButton.Click += ClickAddButton;
        }

        /// <summary>
        /// Событие добавления движения.
        /// </summary>
        public EventHandler MotionAdded;

        /// <summary>
        /// Метод изменения статуса равномерного движения.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChangeConstantMotionStatus(object sender, EventArgs e)
        {
            constantMotionUserControl.Visible = true;
            acceleratedMotionUserControl.Visible = false;
            oscillatoryMotionUserControl.Visible = false;
        }

        /// <summary>
        /// Метод изменения статуса равноускоренного движения.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChangeAcceleratedMotionStatus(
            object sender, EventArgs e)
        {
            constantMotionUserControl.Visible = false;
            acceleratedMotionUserControl.Visible = true;
            oscillatoryMotionUserControl.Visible = false;
        }

        /// <summary>
        /// Метод изменения статуса колебательного движения.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChangeOscillatoryMotionStatus(
            object sender, EventArgs e)
        {
            constantMotionUserControl.Visible = false;
            acceleratedMotionUserControl.Visible = false;
            oscillatoryMotionUserControl.Visible = true;
        }

        /// <summary>
        /// Метод нажатия на кнопку "Добавить".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ClickAddButton(object sender, EventArgs e)
        {
            try
            {
                MotionBase motionBase = null;

                if (constantMotionUserControl.Visible)
                {
                    motionBase = new ConstantMotion()
                    {
                        InitialValue = Convert.ToDouble(
                            constantMotionUserControl.
                            _initialValueTextBox.Text),
                        Time = Convert.ToDouble(
                            constantMotionUserControl.
                            _timeTextBox.Text),
                        Velocity = Convert.ToDouble(
                            constantMotionUserControl.
                            _velocityTextBox.Text),
                    };
                }

                if (acceleratedMotionUserControl.Visible)
                {
                    motionBase = new AcceleratedMotion()
                    {
                        InitialValue = Convert.ToDouble(
                            acceleratedMotionUserControl.
                            _initialValueTextBox.Text),
                        Time = Convert.ToDouble(
                            acceleratedMotionUserControl.
                            _timeTextBox.Text),
                        Velocity = Convert.ToDouble(
                            acceleratedMotionUserControl.
                            _velocityTextBox.Text),
                        Acceleration = Convert.ToDouble(
                            acceleratedMotionUserControl.
                            _accelerationTextBox.Text),
                    };
                }

                if (oscillatoryMotionUserControl.Visible)
                {
                    motionBase = new OscillatoryMotion()
                    {
                        InitialValue = Convert.ToDouble(
                            oscillatoryMotionUserControl.
                            _initialValueTextBox.Text),
                        Time = Convert.ToDouble(
                            oscillatoryMotionUserControl.
                            _timeTextBox.Text),
                        Amplitude = Convert.ToDouble(
                            oscillatoryMotionUserControl.
                            _amplitudeTextBox.Text),
                        Frequency = Convert.ToDouble(
                            oscillatoryMotionUserControl.
                            _frequencyTextBox.Text),
                    };
                }

                MotionAdded?.Invoke(this,
                    new MotionAddedEvent(motionBase));
            }
            catch
            {
                MessageBox.Show("Введите корректные данные.",
                    "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку "Закрыть".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ClickCancelButton(object sender, EventArgs e)
        {
            Close();
        }
    }
}
 