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
            frequencyTextBox = new NumericBox();
            frequencyLabel = new Label();
            amplitudeTextBox = new NumericBox();
            amplitudeLabel = new Label();
            timeTextBox = new NumericBox();
            timeLabel = new Label();
            initialValueTextBox = new NumericBox();
            initialValueLabel = new Label();
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
            // frequencyLabel
            // 
            frequencyLabel.AutoSize = true;
            frequencyLabel.Location = new Point(3, 124);
            frequencyLabel.Name = "frequencyLabel";
            frequencyLabel.Size = new Size(63, 20);
            frequencyLabel.TabIndex = 20;
            frequencyLabel.Text = "Частота";
            // 
            // amplitudeTextBox
            // 
            amplitudeTextBox.Location = new Point(208, 81);
            amplitudeTextBox.Margin = new Padding(3, 4, 3, 4);
            amplitudeTextBox.Name = "amplitudeTextBox";
            amplitudeTextBox.Size = new Size(114, 27);
            amplitudeTextBox.TabIndex = 19;
            // 
            // amplitudeLabel
            // 
            amplitudeLabel.AutoSize = true;
            amplitudeLabel.Location = new Point(3, 85);
            amplitudeLabel.Name = "amplitudeLabel";
            amplitudeLabel.Size = new Size(85, 20);
            amplitudeLabel.TabIndex = 18;
            amplitudeLabel.Text = "Амплитуда";
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(208, 43);
            timeTextBox.Margin = new Padding(3, 4, 3, 4);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(114, 27);
            timeTextBox.TabIndex = 17;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(3, 47);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(54, 20);
            timeLabel.TabIndex = 16;
            timeLabel.Text = "Время";
            // 
            // initialValueTextBox
            // 
            initialValueTextBox.Location = new Point(208, 4);
            initialValueTextBox.Margin = new Padding(3, 4, 3, 4);
            initialValueTextBox.Name = "initialValueTextBox";
            initialValueTextBox.Size = new Size(114, 27);
            initialValueTextBox.TabIndex = 15;
            // 
            // initialValueLabel
            // 
            initialValueLabel.AutoSize = true;
            initialValueLabel.Location = new Point(3, 8);
            initialValueLabel.Name = "initialValueLabel";
            initialValueLabel.Size = new Size(171, 20);
            initialValueLabel.TabIndex = 14;
            initialValueLabel.Text = "Начальная координата";
            // 
            // OscillatoryMotionUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(frequencyTextBox);
            Controls.Add(frequencyLabel);
            Controls.Add(amplitudeTextBox);
            Controls.Add(amplitudeLabel);
            Controls.Add(timeTextBox);
            Controls.Add(timeLabel);
            Controls.Add(initialValueTextBox);
            Controls.Add(initialValueLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OscillatoryMotionUserControl";
            Size = new Size(326, 245);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal NumericBox frequencyTextBox;
        internal Label frequencyLabel;
        internal NumericBox amplitudeTextBox;
        internal Label amplitudeLabel;
        internal NumericBox timeTextBox;
        internal Label timeLabel;
        internal NumericBox initialValueTextBox;
        internal Label initialValueLabel;
    }
}
