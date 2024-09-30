using System.ComponentModel;
using System.Xml.Serialization;
using Model;

namespace View
{
    //TODO: XML
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список на форме.
        /// </summary>
        private BindingList<MotionBase> _motionList = new();

        private XmlSerializer _serializer = new XmlSerializer(typeof(BindingList<MotionBase>));

        //TODO: XML
        private void MainForm_Load(object sender, EventArgs e)
        {
            _motionList = new BindingList<MotionBase>();
            CreateTable(_motionList, calculationDataGridView);
        }

        public static void CreateTable(BindingList<MotionBase> motions, DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            var source = new BindingSource(motions, null);
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

        public MainForm()
        {
            InitializeComponent();

            saveButton.Click += SaveFile;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.MotionAdded += AddedMotion;
            addForm.Show();
        }

        private void AddedMotion(object sender, EventArgs motionBase)
        {
            MotionAddedEvent addedEventArgs =
                motionBase as MotionAddedEvent;

            _motionList.Add(addedEventArgs?.MotionBase);
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            _motionList.Add(MotionRandom.GetRandomMotion());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _motionList.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (calculationDataGridView.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in calculationDataGridView.SelectedRows)
                {
                    _motionList.Remove(row.DataBoundItem as MotionBase);
                }
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (!_motionList.Any() || _motionList is null)
            {
                MessageBox.Show("Список пуст!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*tran.)|*.tran|Все файлы (*.*)|*.*"
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
    }
}