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
        /// Список фигур.
        /// </summary>
        private BindingList<MotionBase> _geometricFigures;

        /// <summary>
        /// Отфильтрованный список фигур.
        /// </summary>
        private BindingList<MotionBase> _filteredGeometricFigures;

        /// <summary>
        /// Событие на фильтрацию списка.
        /// </summary>
        public EventHandler FiguresFilteredOut;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="FilterForm"/>.
        /// </summary>
        /// <param name="geometricFigures">Список 
        /// геометрических фигур для фильтрации.</param>
        public FilterForm(BindingList<MotionBase> geometricFigures)
        {
            _geometricFigures = geometricFigures;
            InitializeComponent();
            DeactivateElements();

            okButton.Click += Filter;
            checkBoxInitialValue.CheckedChanged += ActivateAreaBox;
            timeCheckBox.CheckedChanged += ActivatePerimeterBox;

            checkBoxConstantMotion.CheckedChanged += ActivateElements;
            checkBoxAcceleratedMotion.CheckedChanged += ActivateElements;
            checkBoxOscillatoryMotion.CheckedChanged += ActivateElements;
        }

        /// <summary>
        /// Деактивирует элементы управления на форме.
        /// </summary>
        private void DeactivateElements()
        {
            checkBoxInitialValue.Enabled = false;
            timeCheckBox.Enabled = false;

            textBoxInitialValue.Enabled = false;
            timeTextBox.Enabled = false;

            okButton.Enabled = false;
        }

        /// <summary>
        /// Активирует или деактивирует элементы управления
        /// в зависимости от состояния чекбоксов типа фигуры.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект <see cref="EventArgs"/>,
        /// содержащий данные события.</param>
        private void ActivateElements(object sender, EventArgs e)
        {
            bool activate = checkBoxConstantMotion.Checked
                || checkBoxAcceleratedMotion.Checked
                || checkBoxOscillatoryMotion.Checked;

            okButton.Enabled = activate;
            checkBoxInitialValue.Enabled = activate;
            timeCheckBox.Enabled = activate;
        }

        /// <summary>
        /// Активация поля ввода Площади.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект <see cref="EventArgs"/>,
        /// содержащий данные события.</param>
        private void ActivateAreaBox(object sender, EventArgs e)
        {
            textBoxInitialValue.Enabled = checkBoxInitialValue.Checked;
        }

        /// <summary>
        /// Активациия поля ввода Периметра.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект <see cref="EventArgs"/>,
        /// содержащий данные события.</param>
        private void ActivatePerimeterBox(object sender, EventArgs e)
        {
            timeTextBox.Enabled = timeCheckBox.Checked;
        }

        /// <summary>
        /// Фильтрация списка.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект <see cref="EventArgs"/>,
        /// содержащий данные события.</param>
        private void Filter(object sender, EventArgs e)
        {
            _filteredGeometricFigures = new BindingList<MotionBase>();

            if (checkBoxConstantMotion.Checked) 
            {
                FilterByType(_geometricFigures, _filteredGeometricFigures,
                    typeof(ConstantMotion));
            }
            if (checkBoxAcceleratedMotion.Checked)
            {
                FilterByType(_geometricFigures, _filteredGeometricFigures,
                    typeof(AcceleratedMotion));
            }
            if (checkBoxOscillatoryMotion.Checked)
            {
                FilterByType(_geometricFigures, _filteredGeometricFigures,
                    typeof(OscillatoryMotion));
            }
            if (checkBoxInitialValue.Checked)
            {
                if (!string.IsNullOrWhiteSpace(textBoxInitialValue.Text))
                {
                    _filteredGeometricFigures = 
                        FilterByArea(_filteredGeometricFigures,
                        Convert.ToDouble(textBoxInitialValue.Text));
                }
                else 
                {
                    _ = MessageBox.Show("Пожалуйста, заполните Площадь",
                        "Сообщение", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            if (timeCheckBox.Checked)
            {
                if (!string.IsNullOrWhiteSpace(timeTextBox.Text))
                {
                    _filteredGeometricFigures = 
                        FilterByPerimeter(_filteredGeometricFigures,
                        Convert.ToDouble(timeTextBox.Text));
                }
                else
                {
                    _ = MessageBox.Show("Пожалуйста, заполните Периметр",
                        "Сообщение", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            FiguresFilteredOut.Invoke(this, 
                new MotionFilteredEvent(_filteredGeometricFigures));
        }

        /// <summary>
        /// Отфильтровывает список по типу.
        /// </summary>
        /// <typeparam name="T">Тип значений списка.</typeparam>
        /// <param name="originalList">Лист подлежащий фильтрации.</param>
        /// <param name="filteredList">Список в который будут добавленны
        /// отфильтрованные значения</param>
        /// <param name="typeFilter">Тип отфильтрованных значений.</param>
        private static void FilterByType<T>(
            BindingList<T> originalList, BindingList<T> filteredList,
            Type typeFilter) where T : class
        {
            foreach (var item in originalList)
            {
                if (typeFilter.IsInstanceOfType(item))
                {
                    filteredList.Add(item);
                }
            }
        }


        /// <summary>
        /// Отфильтровывает список по Площади.
        /// </summary>
        /// <param name="originalList">Лист подлежащий фильтрации.</param>
        /// <param name="valueArea">Значение Площади.</param>
        /// <returns>Отфильтрованный список.</returns>
        private static BindingList<MotionBase> FilterByArea(
            BindingList<MotionBase> originalList, double valueArea)
        {
            BindingList<MotionBase> filteredList = new();
            foreach (var item in originalList)
            {
                if (item.InitialValue == valueArea)
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }

        /// <summary>
        /// Отфильтровывает список по Периметру.
        /// </summary>
        /// <param name="originalList">Лист пдлежащий ильтрации.</param>
        /// <param name="valuePerimeter">Значение Периметра.</param>
        /// <returns>Отфильтрованный список.</returns>
        private static BindingList<MotionBase> FilterByPerimeter(
            BindingList<MotionBase> originalList, double valuePerimeter)
        {
            BindingList<MotionBase> filteredList = new();
            foreach (var item in originalList)
            {
                if (item.Time == valuePerimeter)
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }
    }
}