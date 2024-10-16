namespace View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _calculationGroupBox = new GroupBox();
            calculationDataGridView = new DataGridView();
            _deleteButton = new Button();
            _clearButton = new Button();
            _addButton = new Button();
#if DEBUG
            _randomButton = new Button();
#endif
            _editingGroupBox = new GroupBox();
            _resetButton = new Button();
            _filterButton = new Button();
            _saveButton = new Button();
            _loadButton = new Button();
            _calculationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calculationDataGridView).BeginInit();
            _editingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // _calculationGroupBox
            // 
            _calculationGroupBox.Controls.Add(calculationDataGridView);
            _calculationGroupBox.Location = new Point(12, 50);
            _calculationGroupBox.Name = "_calculationGroupBox";
            _calculationGroupBox.Size = new Size(688, 305);
            _calculationGroupBox.TabIndex = 0;
            _calculationGroupBox.TabStop = false;
            _calculationGroupBox.Text = "Расчет координаты";
            // 
            // calculationDataGridView
            // 
            calculationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calculationDataGridView.Location = new Point(6, 27);
            calculationDataGridView.Name = "calculationDataGridView";
            calculationDataGridView.ReadOnly = true;
            calculationDataGridView.RowHeadersWidth = 51;
            calculationDataGridView.RowTemplate.Height = 29;
            calculationDataGridView.Size = new Size(675, 273);
            calculationDataGridView.TabIndex = 0;
            // 
            // _deleteButton
            // 
            _deleteButton.Location = new Point(452, 27);
            _deleteButton.Name = "_deleteButton";
            _deleteButton.Size = new Size(112, 32);
            _deleteButton.TabIndex = 2;
            _deleteButton.Text = "Удалить";
            _deleteButton.UseVisualStyleBackColor = true;
            // 
            // _clearButton
            // 
            _clearButton.Location = new Point(570, 27);
            _clearButton.Name = "_clearButton";
            _clearButton.Size = new Size(112, 32);
            _clearButton.TabIndex = 3;
            _clearButton.Text = "Очистить";
            _clearButton.UseVisualStyleBackColor = true;
            // 
            // _addButton
            // 
            _addButton.Location = new Point(6, 27);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(112, 32);
            _addButton.TabIndex = 4;
            _addButton.Text = "Добавить";
            _addButton.UseVisualStyleBackColor = true;
#if DEBUG
            // 
            // _randomButton
            // 
            _randomButton.Location = new Point(581, 12);
            _randomButton.Name = "_randomButton";
            _randomButton.Size = new Size(112, 32);
            _randomButton.TabIndex = 5;
            _randomButton.Text = "Random";
            _randomButton.UseVisualStyleBackColor = true;
#endif
            // 
            // _editingGroupBox
            // 
            _editingGroupBox.Controls.Add(_resetButton);
            _editingGroupBox.Controls.Add(_filterButton);
            _editingGroupBox.Controls.Add(_addButton);
            _editingGroupBox.Controls.Add(_clearButton);
            _editingGroupBox.Controls.Add(_deleteButton);
            _editingGroupBox.Location = new Point(12, 361);
            _editingGroupBox.Name = "_editingGroupBox";
            _editingGroupBox.Size = new Size(688, 71);
            _editingGroupBox.TabIndex = 6;
            _editingGroupBox.TabStop = false;
            _editingGroupBox.Text = "Редактирование списка";
            // 
            // _resetButton
            // 
            _resetButton.Location = new Point(242, 27);
            _resetButton.Name = "_resetButton";
            _resetButton.Size = new Size(112, 32);
            _resetButton.TabIndex = 7;
            _resetButton.Text = "Сбросить";
            _resetButton.UseVisualStyleBackColor = true;
            // 
            // _filterButton
            // 
            _filterButton.Location = new Point(124, 27);
            _filterButton.Name = "_filterButton";
            _filterButton.Size = new Size(112, 32);
            _filterButton.TabIndex = 6;
            _filterButton.Text = "Фильтр";
            _filterButton.UseVisualStyleBackColor = true;
            // 
            // _saveButton
            // 
            _saveButton.Location = new Point(18, 12);
            _saveButton.Name = "_saveButton";
            _saveButton.Size = new Size(112, 32);
            _saveButton.TabIndex = 7;
            _saveButton.Text = "Сохранить";
            _saveButton.UseVisualStyleBackColor = true;
            // 
            // _loadButton
            // 
            _loadButton.Location = new Point(136, 12);
            _loadButton.Name = "_loadButton";
            _loadButton.Size = new Size(112, 32);
            _loadButton.TabIndex = 8;
            _loadButton.Text = "Загрузить";
            _loadButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(755, 455);
            Controls.Add(_loadButton);
            Controls.Add(_saveButton);
            Controls.Add(_editingGroupBox);
#if DEBUG
            Controls.Add(_randomButton);
#endif
            Controls.Add(_calculationGroupBox);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Расчет координаты";
            Load += LoadMainForm;
            _calculationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)calculationDataGridView).EndInit();
            _editingGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _calculationGroupBox;
        private DataGridView calculationDataGridView;
        private Button _deleteButton;
        private Button _clearButton;
        private Button _addButton;
#if DEBUG
        private Button _randomButton;
#endif
        private GroupBox _editingGroupBox;
        private Button _saveButton;
        private Button _loadButton;
        private Button _filterButton;
        private Button _resetButton;
    }
}