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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            removeButton = new Button();
            button3 = new Button();
            addButton = new Button();
            randomButton = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(718, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Координаты";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(706, 205);
            dataGridView1.TabIndex = 0;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(132, 26);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(112, 32);
            removeButton.TabIndex = 2;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(132, 64);
            button3.Name = "button3";
            button3.Size = new Size(112, 32);
            button3.TabIndex = 3;
            button3.Text = "Очистить";
            button3.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(6, 26);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 32);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // randomButton
            // 
            randomButton.Location = new Point(6, 64);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(112, 32);
            randomButton.TabIndex = 5;
            randomButton.Text = "Random";
            randomButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(addButton);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(randomButton);
            groupBox2.Controls.Add(removeButton);
            groupBox2.Location = new Point(12, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 107);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Редактирование списка";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 404);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Расчет координаты";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button removeButton;
        private Button button3;
        private Button addButton;
        private Button randomButton;
        private GroupBox groupBox2;
    }
}