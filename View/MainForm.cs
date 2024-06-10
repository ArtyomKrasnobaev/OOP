using System.ComponentModel;
using System.Xml.Serialization;
using Model;

namespace View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список на форме.
        /// </summary>
        private BindingList<MotionBase> _motionList = new();

        //private XmlSerializer _serializer = new XmlSerializer(typeof(BindingList<MotionBase>));

        private void MainForm_Load(object sender, EventArgs e)
        {
            _motionList = new BindingList<MotionBase>();
            CreateTable(_motionList, dataGridView1);
        }

        public static void CreateTable(BindingList<MotionBase> motions, DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            var source = new BindingSource(motions, null);
            dataGridView.DataSource = source;
            dataGridView.Columns[0].Width = 130;
            dataGridView.Columns[1].Width = 192;
            dataGridView.Columns[2].Width = 125;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;
            dataGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }
    }
}