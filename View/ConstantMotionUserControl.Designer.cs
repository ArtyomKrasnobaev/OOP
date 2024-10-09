namespace View
{
    partial class ConstantMotionUserControl
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
            _initialValueLabel = new Label();
            _initialValueTextBox = new NumericBox();
            _timeTextBox = new NumericBox();
            _timeLabel = new Label();
            _velocityTextBox = new NumericBox();
            _velocityLabel = new Label();
            SuspendLayout();
            // 
            // _initialValueLabel
            // 
            _initialValueLabel.AutoSize = true;
            _initialValueLabel.Location = new Point(3, 8);
            _initialValueLabel.Name = "_initialValueLabel";
            _initialValueLabel.Size = new Size(171, 20);
            _initialValueLabel.TabIndex = 0;
            _initialValueLabel.Text = "Начальная координата";
            // 
            // _initialValueTextBox
            // 
            _initialValueTextBox.Location = new Point(208, 4);
            _initialValueTextBox.Margin = new Padding(3, 4, 3, 4);
            _initialValueTextBox.Name = "_initialValueTextBox";
            _initialValueTextBox.Size = new Size(114, 27);
            _initialValueTextBox.TabIndex = 1;
            // 
            // _timeTextBox
            // 
            _timeTextBox.Location = new Point(208, 43);
            _timeTextBox.Margin = new Padding(3, 4, 3, 4);
            _timeTextBox.Name = "_timeTextBox";
            _timeTextBox.Size = new Size(114, 27);
            _timeTextBox.TabIndex = 3;
            // 
            // _timeLabel
            // 
            _timeLabel.AutoSize = true;
            _timeLabel.Location = new Point(3, 47);
            _timeLabel.Name = "_timeLabel";
            _timeLabel.Size = new Size(54, 20);
            _timeLabel.TabIndex = 2;
            _timeLabel.Text = "Время";
            // 
            // _velocityTextBox
            // 
            _velocityTextBox.Location = new Point(208, 81);
            _velocityTextBox.Margin = new Padding(3, 4, 3, 4);
            _velocityTextBox.Name = "_velocityTextBox";
            _velocityTextBox.Size = new Size(114, 27);
            _velocityTextBox.TabIndex = 5;
            // 
            // _velocityLabel
            // 
            _velocityLabel.AutoSize = true;
            _velocityLabel.Location = new Point(3, 85);
            _velocityLabel.Name = "_velocityLabel";
            _velocityLabel.Size = new Size(73, 20);
            _velocityLabel.TabIndex = 4;
            _velocityLabel.Text = "Скорость";
            // 
            // ConstantMotionUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_velocityTextBox);
            Controls.Add(_velocityLabel);
            Controls.Add(_timeTextBox);
            Controls.Add(_timeLabel);
            Controls.Add(_initialValueTextBox);
            Controls.Add(_initialValueLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConstantMotionUserControl";
            Size = new Size(326, 245);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label _initialValueLabel;
        internal NumericBox _initialValueTextBox;
        internal NumericBox _timeTextBox;
        internal Label _timeLabel;
        internal NumericBox _velocityTextBox;
        internal Label _velocityLabel;
    }
}
