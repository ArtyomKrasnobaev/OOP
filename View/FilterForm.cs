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
    public partial class FilterForm : Form
    {
        private BindingList<MotionBase> _motionList;

        private BindingList<MotionBase> _filteredMotionList;

        public EventHandler MotionFiltered;

        public FilterForm(BindingList<MotionBase> motionList)
        {
            _motionList = motionList;

            InitializeComponent();

            buttonOK.Click += new EventHandler(ClickButtonOK);
        }

        private void ClickButtonOK(object sender, EventArgs e)
        {
            bool checkClick = checkBoxConstantMotion.Checked
                || checkBoxAcceleratedMotion.Checked
                || checkBoxOscillatoryMotion.Checked;

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
        }

        private static void FilterByType<MotionBase>(
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
    }
}