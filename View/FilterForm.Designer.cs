namespace View
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            checkBoxOscillatoryMotion = new CheckBox();
            checkBoxAcceleratedMotion = new CheckBox();
            checkBoxConstantMotion = new CheckBox();
            okButton = new Button();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            textBoxInitialValue = new TextBox();
            checkBox2 = new CheckBox();
            checkBoxInitialValue = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxOscillatoryMotion);
            groupBox1.Controls.Add(checkBoxAcceleratedMotion);
            groupBox1.Controls.Add(checkBoxConstantMotion);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип движения";
            // 
            // checkBoxOscillatoryMotion
            // 
            checkBoxOscillatoryMotion.AutoSize = true;
            checkBoxOscillatoryMotion.Location = new Point(7, 95);
            checkBoxOscillatoryMotion.Margin = new Padding(3, 4, 3, 4);
            checkBoxOscillatoryMotion.Name = "checkBoxOscillatoryMotion";
            checkBoxOscillatoryMotion.Size = new Size(138, 24);
            checkBoxOscillatoryMotion.TabIndex = 3;
            checkBoxOscillatoryMotion.Text = "Колебательное";
            checkBoxOscillatoryMotion.UseVisualStyleBackColor = true;
            // 
            // checkBoxAcceleratedMotion
            // 
            checkBoxAcceleratedMotion.AutoSize = true;
            checkBoxAcceleratedMotion.Location = new Point(7, 61);
            checkBoxAcceleratedMotion.Margin = new Padding(3, 4, 3, 4);
            checkBoxAcceleratedMotion.Name = "checkBoxAcceleratedMotion";
            checkBoxAcceleratedMotion.Size = new Size(155, 24);
            checkBoxAcceleratedMotion.TabIndex = 2;
            checkBoxAcceleratedMotion.Text = "Равноускоренное";
            checkBoxAcceleratedMotion.UseVisualStyleBackColor = true;
            // 
            // checkBoxConstantMotion
            // 
            checkBoxConstantMotion.AutoSize = true;
            checkBoxConstantMotion.Location = new Point(7, 28);
            checkBoxConstantMotion.Margin = new Padding(3, 4, 3, 4);
            checkBoxConstantMotion.Name = "checkBoxConstantMotion";
            checkBoxConstantMotion.Size = new Size(127, 24);
            checkBoxConstantMotion.TabIndex = 1;
            checkBoxConstantMotion.Text = "Равномерное";
            checkBoxConstantMotion.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.Location = new Point(12, 285);
            okButton.Name = "okButton";
            okButton.Size = new Size(112, 32);
            okButton.TabIndex = 1;
            okButton.Text = "ОК";
            okButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBoxInitialValue);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBoxInitialValue);
            groupBox2.Location = new Point(12, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 117);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Параметры движения";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(230, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 3;
            // 
            // textBoxInitialValue
            // 
            textBoxInitialValue.Location = new Point(230, 24);
            textBoxInitialValue.Name = "textBoxInitialValue";
            textBoxInitialValue.Size = new Size(114, 27);
            textBoxInitialValue.TabIndex = 2;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(7, 65);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(76, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Время";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBoxInitialValue
            // 
            checkBoxInitialValue.AutoSize = true;
            checkBoxInitialValue.Location = new Point(6, 26);
            checkBoxInitialValue.Name = "checkBoxInitialValue";
            checkBoxInitialValue.Size = new Size(193, 24);
            checkBoxInitialValue.TabIndex = 0;
            checkBoxInitialValue.Text = "Начальная координата";
            checkBoxInitialValue.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 335);
            Controls.Add(groupBox2);
            Controls.Add(okButton);
            Controls.Add(groupBox1);
            Name = "FilterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки фильтрации";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBoxOscillatoryMotion;
        private CheckBox checkBoxAcceleratedMotion;
        private CheckBox checkBoxConstantMotion;
        private Button okButton;
        private GroupBox groupBox2;
        private CheckBox checkBoxInitialValue;
        private CheckBox checkBox2;
        private TextBox textBoxInitialValue;
        private TextBox textBox2;
    }
}