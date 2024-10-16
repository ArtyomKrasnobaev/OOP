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
            _frequencyTextBox = new NumericBox();
            _frequencyLabel = new Label();
            _amplitudeTextBox = new NumericBox();
            _amplitudeLabel = new Label();
            _timeTextBox = new NumericBox();
            _timeLabel = new Label();
            _initialValueTextBox = new NumericNegativeBox();
            _initialValueLabel = new Label();
            SuspendLayout();
            // 
            // _frequencyTextBox
            // 
            _frequencyTextBox.Location = new Point(208, 120);
            _frequencyTextBox.Margin = new Padding(3, 4, 3, 4);
            _frequencyTextBox.MaxLength = 10;
            _frequencyTextBox.Name = "_frequencyTextBox";
            _frequencyTextBox.Size = new Size(114, 27);
            _frequencyTextBox.TabIndex = 21;
            // 
            // _frequencyLabel
            // 
            _frequencyLabel.AutoSize = true;
            _frequencyLabel.Location = new Point(3, 124);
            _frequencyLabel.Name = "_frequencyLabel";
            _frequencyLabel.Size = new Size(63, 20);
            _frequencyLabel.TabIndex = 20;
            _frequencyLabel.Text = "Частота";
            // 
            // _amplitudeTextBox
            // 
            _amplitudeTextBox.Location = new Point(208, 81);
            _amplitudeTextBox.Margin = new Padding(3, 4, 3, 4);
            _amplitudeTextBox.MaxLength = 10;
            _amplitudeTextBox.Name = "_amplitudeTextBox";
            _amplitudeTextBox.Size = new Size(114, 27);
            _amplitudeTextBox.TabIndex = 19;
            // 
            // _amplitudeLabel
            // 
            _amplitudeLabel.AutoSize = true;
            _amplitudeLabel.Location = new Point(3, 85);
            _amplitudeLabel.Name = "_amplitudeLabel";
            _amplitudeLabel.Size = new Size(85, 20);
            _amplitudeLabel.TabIndex = 18;
            _amplitudeLabel.Text = "Амплитуда";
            // 
            // _timeTextBox
            // 
            _timeTextBox.Location = new Point(208, 43);
            _timeTextBox.Margin = new Padding(3, 4, 3, 4);
            _timeTextBox.MaxLength = 10;
            _timeTextBox.Name = "_timeTextBox";
            _timeTextBox.Size = new Size(114, 27);
            _timeTextBox.TabIndex = 17;
            // 
            // _timeLabel
            // 
            _timeLabel.AutoSize = true;
            _timeLabel.Location = new Point(3, 47);
            _timeLabel.Name = "_timeLabel";
            _timeLabel.Size = new Size(54, 20);
            _timeLabel.TabIndex = 16;
            _timeLabel.Text = "Время";
            // 
            // _initialValueTextBox
            // 
            _initialValueTextBox.Location = new Point(208, 4);
            _initialValueTextBox.Margin = new Padding(3, 4, 3, 4);
            _initialValueTextBox.MaxLength = 10;
            _initialValueTextBox.Name = "_initialValueTextBox";
            _initialValueTextBox.Size = new Size(114, 27);
            _initialValueTextBox.TabIndex = 15;
            // 
            // _initialValueLabel
            // 
            _initialValueLabel.AutoSize = true;
            _initialValueLabel.Location = new Point(3, 8);
            _initialValueLabel.Name = "_initialValueLabel";
            _initialValueLabel.Size = new Size(171, 20);
            _initialValueLabel.TabIndex = 14;
            _initialValueLabel.Text = "Начальная координата";
            // 
            // OscillatoryMotionUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_frequencyTextBox);
            Controls.Add(_frequencyLabel);
            Controls.Add(_amplitudeTextBox);
            Controls.Add(_amplitudeLabel);
            Controls.Add(_timeTextBox);
            Controls.Add(_timeLabel);
            Controls.Add(_initialValueTextBox);
            Controls.Add(_initialValueLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OscillatoryMotionUserControl";
            Size = new Size(326, 245);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal NumericBox _frequencyTextBox;
        internal Label _frequencyLabel;
        internal NumericBox _amplitudeTextBox;
        internal Label _amplitudeLabel;
        internal NumericBox _timeTextBox;
        internal Label _timeLabel;
        internal NumericNegativeBox _initialValueTextBox;
        internal Label _initialValueLabel;
    }
}
