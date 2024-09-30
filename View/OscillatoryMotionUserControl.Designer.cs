namespace View
{
    partial class OscillatoryMotionUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            frequencyTextBox = new TextBox();
            label4 = new Label();
            amplitudeTextBox = new TextBox();
            label3 = new Label();
            timeTextBox = new TextBox();
            label2 = new Label();
            initialValueTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // frequencyTextBox
            // 
            frequencyTextBox.Location = new Point(208, 120);
            frequencyTextBox.Margin = new Padding(3, 4, 3, 4);
            frequencyTextBox.Name = "frequencyTextBox";
            frequencyTextBox.Size = new Size(114, 27);
            frequencyTextBox.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 124);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 20;
            label4.Text = "Частота";
            // 
            // amplitudeTextBox
            // 
            amplitudeTextBox.Location = new Point(208, 81);
            amplitudeTextBox.Margin = new Padding(3, 4, 3, 4);
            amplitudeTextBox.Name = "amplitudeTextBox";
            amplitudeTextBox.Size = new Size(114, 27);
            amplitudeTextBox.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 85);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 18;
            label3.Text = "Амплитуда";
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(208, 43);
            timeTextBox.Margin = new Padding(3, 4, 3, 4);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(114, 27);
            timeTextBox.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 47);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 16;
            label2.Text = "Время";
            // 
            // initialValueTextBox
            // 
            initialValueTextBox.Location = new Point(208, 4);
            initialValueTextBox.Margin = new Padding(3, 4, 3, 4);
            initialValueTextBox.Name = "initialValueTextBox";
            initialValueTextBox.Size = new Size(114, 27);
            initialValueTextBox.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 14;
            label1.Text = "Начальная координата";
            // 
            // OscillatoryMotionUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(frequencyTextBox);
            Controls.Add(label4);
            Controls.Add(amplitudeTextBox);
            Controls.Add(label3);
            Controls.Add(timeTextBox);
            Controls.Add(label2);
            Controls.Add(initialValueTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OscillatoryMotionUserControl";
            Size = new Size(326, 245);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox frequencyTextBox;
        internal Label label4;
        internal TextBox amplitudeTextBox;
        internal Label label3;
        internal TextBox timeTextBox;
        internal Label label2;
        internal TextBox initialValueTextBox;
        internal Label label1;
    }
}
