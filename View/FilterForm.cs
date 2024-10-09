using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// Форма настроек фильтрации.
    /// </summary>
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Исходный список.
        /// </summary>
        private BindingList<MotionBase> _motionList;

        /// <summary>
        /// Отфильтрованный список.
        /// </summary>
        private BindingList<MotionBase> _filteredMotionList;

        /// <summary>
        /// Событие фильтрации списка.
        /// </summary>
        public EventHandler MotionFiltered;

        /// <summary>
        /// Конструктор класса FilterForm.
        /// </summary>
        /// <param name="motionList"></param>
        public FilterForm(BindingList<MotionBase> motionList)
        {
            _motionList = motionList;

            InitializeComponent();

            okButton.Click += new EventHandler(ClickOkButton);
        }

        private void ClickOkButton(object sender, EventArgs e)
        {
            bool checkClick = checkBoxConstantMotion.Checked
                || checkBoxAcceleratedMotion.Checked
                || checkBoxOscillatoryMotion.Checked
                || checkBoxInitialValue.Checked;

            if (checkClick)
            {
                _filteredMotionList = new BindingList<MotionBase>();

                if (checkBoxConstantMotion.Checked)
                {
                    FilterByType(_motionList,
                        _filteredMotionList,
                        typeof(ConstantMotion));
                }

                if (checkBoxAcceleratedMotion.Checked)
                {
                    FilterByType(_motionList,
                        _filteredMotionList,
                        typeof(AcceleratedMotion));
                }

                if (checkBoxOscillatoryMotion.Checked)
                {
                    FilterByType(_motionList,
                        _filteredMotionList,
                        typeof(OscillatoryMotion));
                }

                CheckedData();
                if (_filteredMotionList.Count == 0
                    || _filteredMotionList is null)
                {
                    MessageBox.Show("Совпадений не найдено.", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MotionFiltered.Invoke(this,
                new MotionFilteredEvent(_filteredMotionList));
            }
            else
            {
                MessageBox.Show("Заполните критерии поиска.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CheckedData()
        {
            BindingList<MotionBase> motionList = new BindingList<MotionBase>();

            bool statusCheckBox = checkBoxConstantMotion.Checked
                || checkBoxAcceleratedMotion.Checked
                || checkBoxOscillatoryMotion.Checked;

            if (statusCheckBox)
            {
                motionList = new BindingList<MotionBase>(_filteredMotionList);
            }
            else
            {
                motionList = new BindingList<MotionBase>(_motionList);
            }

            if (checkBoxInitialValue.Checked)
            {
                if (!string.IsNullOrEmpty(textBoxInitialValue.Text))
                {
                    FilterByInitialValue(motionList,
                    Convert.ToDouble(textBoxInitialValue.Text));
                    _filteredMotionList = motionList;
                }
                else
                {
                    MessageBox.Show("Введите начальную координату.", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Метод фильтрации по типу движения.
        /// </summary>
        /// <param name="motionList"></param>
        /// <param name="filteredMotionList"></param>
        /// <param name="motionType"></param>
        private static void FilterByType(
            BindingList<MotionBase> motionList,
            BindingList<MotionBase> filteredMotionList,
            Type motionType)
        {
            foreach (var motion in motionList)
            {
                if (motionType == motion.GetType())
                {
                    filteredMotionList.Add(motion);
                }
            }
        }

        /// <summary>
        /// Метод фильтрации по начальной координате.
        /// </summary>
        /// <param name="motionList"></param>
        /// <param name="initialValue"></param>
        private static void FilterByInitialValue(
            BindingList<MotionBase> motionList, double initialValue)
        {
            for (int i = motionList.Count - 1; i >= 0; i--)
            {
                if (motionList[i].InitialValue != initialValue)
                {
                    motionList.RemoveAt(i);
                }
            }
        }
    }
}