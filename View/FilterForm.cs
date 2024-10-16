using System.ComponentModel;
using Model;

namespace View
{
    /// <summary>
    /// Форма настроек фильтрации.
    /// </summary>
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Список на форме.
        /// </summary>
        private BindingList<MotionBase> _motionList;

        /// <summary>
        /// Отфильтрованный список.
        /// </summary>
        private BindingList<MotionBase> _filteredMotionList;

        /// <summary>
        /// Событие фильтрации списка.
        /// </summary>
        public EventHandler MotionsFiltered;

        /// <summary>
        /// Конструктор класса <see cref="FilterForm"/>.
        /// </summary>
        /// <param name="motionList">Список движений.</param>
        public FilterForm(BindingList<MotionBase> motionList)
        {
            _motionList = motionList;
            InitializeComponent();
            _initialValueTextBox.Enabled = false;
            _timeTextBox.Enabled = false;
            _okButton.Enabled = false;
            _okButton.Click += Filter;
            _initialValueCheckBox.CheckedChanged += ActivateInitialValueTextBox;
            _timeCheckBox.CheckedChanged += ActivateTimeTextBox;
            _constantMotionCheckBox.CheckedChanged += ActivateOkButton;
            _acceleratedMotionCheckBox.CheckedChanged += ActivateOkButton;
            _oscillatoryMotionCheckBox.CheckedChanged += ActivateOkButton;
            _initialValueCheckBox.CheckedChanged += ActivateOkButton;
            _timeCheckBox.CheckedChanged += ActivateOkButton;
        }

        /// <summary>
        /// Метод активации кнопки "Ок".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ActivateOkButton(object sender, EventArgs e)
        {
            bool activate = _constantMotionCheckBox.Checked
                || _acceleratedMotionCheckBox.Checked
                || _oscillatoryMotionCheckBox.Checked
                || _initialValueCheckBox.Checked
                || _timeCheckBox.Checked;

            _okButton.Enabled = activate;
        }

        /// <summary>
        /// Метод активации поля ввода начальной координаты.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ActivateInitialValueTextBox(object sender, EventArgs e)
        {
            _initialValueTextBox.Enabled = _initialValueCheckBox.Checked;
        }

        /// <summary>
        /// Метод активации поля ввода времени.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ActivateTimeTextBox(object sender, EventArgs e)
        {
            _timeTextBox.Enabled = _timeCheckBox.Checked;
        }

        /// <summary>
        /// Фильтрация списка.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void Filter(object sender, EventArgs e)
        {
            _filteredMotionList = new BindingList<MotionBase>();
            BindingList<MotionBase> test = new();

            bool check = _constantMotionCheckBox.Checked
                || _acceleratedMotionCheckBox.Checked
                || _oscillatoryMotionCheckBox.Checked;

            if (_constantMotionCheckBox.Checked) 
            {
                FilterByType(_motionList, test,
                    typeof(ConstantMotion));
            }

            if (_acceleratedMotionCheckBox.Checked)
            {
                FilterByType(_motionList, test,
                    typeof(AcceleratedMotion));
            }

            if (_oscillatoryMotionCheckBox.Checked)
            {
                FilterByType(_motionList, test,
                    typeof(OscillatoryMotion));
            }

            foreach (var motion in _motionList)
            {
                if (test.Contains(motion))
                {
                    _filteredMotionList.Add(motion);
                }
            }

            if (check)
            {
                CheckParameters(_filteredMotionList);
            }
            else
            {
                CheckParameters(_motionList);
            }
            
            MotionsFiltered.Invoke(this, 
                new MotionFilteredEvent(_filteredMotionList));
        }

        /// <summary>
        /// Метод проверки параметров.
        /// </summary>
        /// <param name="motionList">Список движений.</param>
        public void CheckParameters(BindingList<MotionBase> motionList)
        {
            if (_initialValueCheckBox.Checked)
            {
                if (!string.IsNullOrWhiteSpace(_initialValueTextBox.Text))
                {
                    _filteredMotionList =
                        FilterByInitialValue(motionList,
                        Convert.ToDouble(_initialValueTextBox.Text));
                }
                else
                {
                    MessageBox.Show("Введите начальную координату",
                        "Сообщение", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            if (_timeCheckBox.Checked)
            {
                if (!string.IsNullOrWhiteSpace(_timeTextBox.Text))
                {
                    _filteredMotionList =
                        FilterByTime(motionList,
                        Convert.ToDouble(_timeTextBox.Text));
                }
                else
                {
                    MessageBox.Show("Введите время",
                        "Сообщение", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Метод фильтрации по типу движения.
        /// </summary>
        /// <param name="originalList">Исходный список.</param>
        /// <param name="filteredList">Отфильтрованный список.</param>
        /// <param name="type">Тип движения.</param>
        public static void FilterByType(BindingList<MotionBase> originalList,
            BindingList<MotionBase> filteredList, Type type)
        {
            foreach (var item in originalList)
            {
                if (type.IsInstanceOfType(item))
                {
                    filteredList.Add(item);
                }
            }
        }

        /// <summary>
        /// Метод фильтрации по начальной координате.
        /// </summary>
        /// <param name="originalList">Исходный список.</param>
        /// <param name="initialValue">Начальная координата.</param>
        /// <returns>Отфильтрованный список.</returns>
        private static BindingList<MotionBase> FilterByInitialValue(
            BindingList<MotionBase> originalList, double initialValue)
        {
            BindingList<MotionBase> filteredList = new();
            foreach (var element in originalList)
            {
                if (element.InitialValue == initialValue)
                {
                    filteredList.Add(element);
                }
            }

            return filteredList;
        }

        /// <summary>
        /// Метод фильтрации по времени.
        /// </summary>
        /// <param name="originalList">Исходный список.</param>
        /// <param name="time">Время.</param>
        /// <returns>Отфильтрованный список.</returns>
        private static BindingList<MotionBase> FilterByTime(
            BindingList<MotionBase> originalList, double time)
        {
            BindingList<MotionBase> filteredList = new();
            foreach (var element in originalList)
            {
                if (element.Time == time)
                {
                    filteredList.Add(element);
                }
            }

            return filteredList;
        }
    }
}