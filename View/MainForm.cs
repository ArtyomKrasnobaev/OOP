using System.ComponentModel;
using System.Xml.Serialization;
using Model;

namespace View
{
    /// <summary>
    /// �������� ����� ���������.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������ �� �����.
        /// </summary>
        private BindingList<MotionBase> _motionList = new();

        /// <summary>
        /// ��������������� ������.
        /// </summary>
        private BindingList<MotionBase> _filteredMotionList;

        /// <summary>
        /// ������������ ������.
        /// </summary>
        private XmlSerializer _serializer = new XmlSerializer(
            typeof(BindingList<MotionBase>));

        /// <summary>
        /// ��������� ����� ����������.
        /// </summary>
        private bool _isAddFormOpened = false;

        /// <summary>
        /// ��������� ����� �������.
        /// </summary>
        private bool _isFilterFormOpened = false;

        /// <summary>
        /// ��������� �������.
        /// </summary>
        private bool _isFiltered = false;

        /// <summary>
        /// ����� �������� �����.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">������, ���������� ������ � �������.</param>
        private void LoadMainForm(object sender, EventArgs e)
        {
            _motionList = new BindingList<MotionBase>();
            CreateTable(_motionList, calculationDataGridView);
        }

        /// <summary>
        /// ����� �������� ������� �� �����.
        /// </summary>
        /// <param name="motionList">������ ��������.</param>
        /// <param name="dataGridView">�����.</param>
        public static void CreateTable(BindingList<MotionBase> motionList,
            DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            var source = new BindingSource(motionList, null);
            dataGridView.DataSource = source;
            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// ����������� ������ MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _addButton.Click += ClickAddButton;
#if DEBUG
            _randomButton.Click += ClickRandomButton;
#endif
            _deleteButton.Click += ClickDeleteButton;
            _clearButton.Click += ClickClearButton;
            _saveButton.Click += ClickSaveButton;
            _loadButton.Click += ClickLoadButton;
            _filterButton.Click += ClickFilterButton;
            _resetButton.Click += ClickResetButton;
        }

        /// <summary>
        /// ����� ������� �� ������ "��������".
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">������, ���������� ������ � �������.</param>
        private void ClickAddButton(object sender, EventArgs e)
        {
            if (_isAddFormOpened == false && _isFiltered == false)
            {
                _isAddFormOpened = true;
                AddForm addForm = new AddForm();
                addForm.FormClosed += (s, args) =>
                    { _isAddFormOpened = false; };
                addForm.FormClosed += (s, args) =>
                    { _filterButton.Enabled = true; };
                addForm.MotionAdded += AddedMotion;
                addForm.Show();
            }
            if (_isAddFormOpened)
            {
                _filterButton.Enabled = false;
            }
        }

        /// <summary>
        /// ����� ������� �� ������ "Random".
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">������, ���������� ������ � �������.</param>
        private void ClickRandomButton(object sender, EventArgs e)
        {
            _motionList.Add(MotionRandom.GetRandomMotion());
        }

        /// <summary>
        /// ����� ������� �� ������ "��������".
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">������, ���������� ������ � �������.</param>
        private void ClickClearButton(object sender, EventArgs e)
        {
            _motionList.Clear();
        }

        /// <summary>
        /// ���������� ���������� ������.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="motionBase">������ ������ MotionBase.</param>
        private void AddedMotion(object sender, EventArgs motionBase)
        {
            MotionAddedEvent addedEventArgs =
                motionBase as MotionAddedEvent;

            _motionList.Add(addedEventArgs?.MotionBase);
        }

        /// <summary>
        /// ����� ������� �� ������ "�������"
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">������, ���������� ������ � �������.</param>
        private void ClickDeleteButton(object sender, EventArgs e)
        {
            if (calculationDataGridView.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in
                    calculationDataGridView.SelectedRows)
                {
                    _motionList.Remove(row.DataBoundItem as MotionBase);
                }
            }
        }

        /// <summary>
        /// ����� ���������� ������ � ����.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">������, ���������� ������ � �������.</param>
        private void ClickSaveButton(object sender, EventArgs e)
        {
            if (!_motionList.Any() || _motionList is null)
            {
                MessageBox.Show("������ ����!", "��������������",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "����� (*mtn.)|*.mtn|��� ����� (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName.ToString();

                using (var file = File.Create(filePath))
                {
                    _serializer.Serialize(file, _motionList);
                }
            }
        }

        /// <summary>
        /// ����� �������� ������ �� �����.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">������, ���������� ������ � �������.</param>
        private void ClickLoadButton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "����� (*.mtn)|*.mtn|��� ����� (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            string filePath = openFileDialog.FileName.ToString();

            try
            {
                using (var file = new StreamReader(filePath))
                {
                    _motionList = (BindingList<MotionBase>)
                        _serializer.Deserialize(file);
                }

                calculationDataGridView.DataSource = _motionList;
            }
            catch (Exception)
            {
                MessageBox.Show("�� ������� ��������� ����!",
                    "��������������", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// ����� ������� �� ������ �������.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">������, ���������� ������ � �������.</param>
        private void ClickFilterButton(object sender, EventArgs e)
        {
            if (!_isFilterFormOpened)
            {
                _isFilterFormOpened = true;
                FilterForm filterForm = new FilterForm(_motionList);
                filterForm.FormClosed += (s, args) =>
                    { _isFilterFormOpened = false; };
                filterForm.FormClosed += (s, args) =>
                    { _addButton.Enabled = true; };
                filterForm.MotionsFiltered += FilterMotion;
                filterForm.Show();
            }
            if (_isFilterFormOpened)
            {
                _addButton.Enabled = false;
            }
        }

        /// <summary>
        /// ����� ����������.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="motionList">������ ��������.</param>
        private void FilterMotion(object sender, EventArgs motionList)
        {
            MotionFilteredEvent filterEventArgs =
                motionList as MotionFilteredEvent;
            _filteredMotionList = filterEventArgs?.FilteredMotionList;
            _isFiltered = true;
            _addButton.Enabled = false;
            //_clearButton.Enabled = false;
            CreateTable(_filteredMotionList, calculationDataGridView);
        }

        /// <summary>
        /// ����� ������� �� ������ "��������".
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">������, ���������� ������ � �������.</param>
        private void ClickResetButton(object sender, EventArgs e)
        {
            CreateTable(_motionList, calculationDataGridView);
            _isFiltered = false;
            //_addButton.Enabled = true;
            //_clearButton.Enabled = true;
        }
    }
}