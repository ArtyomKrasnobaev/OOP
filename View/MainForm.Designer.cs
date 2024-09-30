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
            calculationGroupBox = new GroupBox();
            calculationDataGridView = new DataGridView();
            removeButton = new Button();
            clearButton = new Button();
            addButton = new Button();
            randomButton = new Button();
            editingGroupBox = new GroupBox();
            saveButton = new Button();
            loadButton = new Button();
            calculationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calculationDataGridView).BeginInit();
            editingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // calculationGroupBox
            // 
            calculationGroupBox.Controls.Add(calculationDataGridView);
            calculationGroupBox.Location = new Point(12, 50);
            calculationGroupBox.Name = "calculationGroupBox";
            calculationGroupBox.Size = new Size(688, 305);
            calculationGroupBox.TabIndex = 0;
            calculationGroupBox.TabStop = false;
            calculationGroupBox.Text = "Расчет координаты";
            // 
            // calculationDataGridView
            // 
            calculationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calculationDataGridView.Location = new Point(6, 27);
            calculationDataGridView.Name = "calculationDataGridView";
            calculationDataGridView.RowHeadersWidth = 51;
            calculationDataGridView.RowTemplate.Height = 29;
            calculationDataGridView.Size = new Size(675, 273);
            calculationDataGridView.TabIndex = 0;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(242, 27);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(112, 32);
            removeButton.TabIndex = 2;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(360, 27);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 32);
            clearButton.TabIndex = 3;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(6, 27);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 32);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // randomButton
            // 
            randomButton.Location = new Point(124, 27);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(112, 32);
            randomButton.TabIndex = 5;
            randomButton.Text = "Случайно";
            randomButton.UseVisualStyleBackColor = true;
            randomButton.Click += randomButton_Click;
            // 
            // editingGroupBox
            // 
            editingGroupBox.Controls.Add(addButton);
            editingGroupBox.Controls.Add(clearButton);
            editingGroupBox.Controls.Add(randomButton);
            editingGroupBox.Controls.Add(removeButton);
            editingGroupBox.Location = new Point(12, 361);
            editingGroupBox.Name = "editingGroupBox";
            editingGroupBox.Size = new Size(688, 71);
            editingGroupBox.TabIndex = 6;
            editingGroupBox.TabStop = false;
            editingGroupBox.Text = "Редактирование списка";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(18, 12);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 32);
            saveButton.TabIndex = 7;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(136, 12);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(112, 32);
            loadButton.TabIndex = 8;
            loadButton.Text = "Загрузить";
            loadButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(755, 455);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(editingGroupBox);
            Controls.Add(calculationGroupBox);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Расчет координаты";
            Load += MainForm_Load;
            calculationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)calculationDataGridView).EndInit();
            editingGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox calculationGroupBox;
        private DataGridView calculationDataGridView;
        private Button removeButton;
        private Button clearButton;
        private Button addButton;
        private Button randomButton;
        private GroupBox editingGroupBox;
        private Button saveButton;
        private Button loadButton;
    }
}