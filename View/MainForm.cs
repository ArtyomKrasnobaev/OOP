using System.ComponentModel;
using System.Xml.Serialization;
using Model;

namespace View
{
    //TODO+: XML
    /// <summary>
    /// Основная форма программы.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список на форме.
        /// </summary>
        private BindingList<MotionBase> _motionList = new();

        /// <summary>
        /// Отфильтрованный список.
        /// </summary>
        private BindingList<MotionBase> _filteredMotionList;

        /// <summary>
        /// Сериализация списка.
        /// </summary>
        private XmlSerializer _serializer = new XmlSerializer(typeof(BindingList<MotionBase>));

        //TODO+: XML
        /// <summary>
        /// Метод загрузки формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadMainForm(object sender, EventArgs e)
        {
            _motionList = new BindingList<MotionBase>();
            CreateTable(_motionList, calculationDataGridView);
        }

        /// <summary>
        /// Метод создания таблицы на форме.
        /// </summary>
        /// <param name="motions"></param>
        /// <param name="dataGridView"></param>
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

        /// <summary>
        /// Конструктор класса MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            addButton.Click += ClickAddButton;

            randomButton.Click += ClickRandomButton;

            deleteButton.Click += ClickDeleteButton;

            clearButton.Click += ClickClearButton;

            saveButton.Click += ClickSaveButton;

            loadButton.Click += ClickLoadButton;

            filterButton.Click += ClickFilterButton;

            resetButton.Click += ClickResetButton;
        }

        /// <summary>
        /// Метод нажатия на кнопку "Добавить".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickAddButton(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.MotionAdded += AddedMotion;
            addForm.Show();
        }

        /// <summary>
        /// Метод нажатия на кнопку "Random".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickRandomButton(object sender, EventArgs e)
        {
            _motionList.Add(MotionRandom.GetRandomMotion());
        }

        /// <summary>
        /// Метод нажатия на кнопку "Очистить".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickClearButton(object sender, EventArgs e)
        {
            _motionList.Clear();
        }

        /// <summary>
        /// Обработчик добавления данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="motionBase"></param>
        private void AddedMotion(object sender, EventArgs motionBase)
        {
            MotionAddedEvent addedEventArgs =
                motionBase as MotionAddedEvent;

            _motionList.Add(addedEventArgs?.MotionBase);
        }

        /// <summary>
        /// Метод нажатия на кнопку "Удалить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickDeleteButton(object sender, EventArgs e)
        {
            if (calculationDataGridView.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in calculationDataGridView.SelectedRows)
                {
                    _motionList.Remove(row.DataBoundItem as MotionBase);
                }
            }
        }

        /// <summary>
        /// Метод сохранения списка в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickSaveButton(object sender, EventArgs e)
        {
            if (!_motionList.Any() || _motionList is null)
            {
                MessageBox.Show("Список пуст!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*mtn.)|*.mtn|Все файлы (*.*)|*.*"
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
        /// Метод загрузки списка из файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickLoadButton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.mtn)|*.mtn|Все файлы (*.*)|*.*"
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
                MessageBox.Show("Не удалось загрузить файл!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку фильтра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickFilterButton(object sender, EventArgs e)
        {
            FilterForm filterForm = new FilterForm(_motionList);
            filterForm.FiguresFilteredOut += FilterMotion;
            filterForm.Show();
        }

        /// <summary>
        /// Метод фильтрации.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="motionList"></param>
        private void FilterMotion(object sender, EventArgs motionList)
        {
            MotionFilteredEvent filterEventArgs =
                motionList as MotionFilteredEvent;

            _filteredMotionList = filterEventArgs?.FilteredMotionList;
            CreateTable(_filteredMotionList, calculationDataGridView);
        }

        /// <summary>
        /// Метод нажатия на кнопку "Сбросить".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickResetButton(object sender, EventArgs e)
        {
            CreateTable(_motionList, calculationDataGridView);
        }
    }
}