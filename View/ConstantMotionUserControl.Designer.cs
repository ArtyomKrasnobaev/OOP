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
            initialValueLabel = new Label();
            initialValueTextBox = new NumericBox();
            timeTextBox = new NumericBox();
            timeLabel = new Label();
            velocityTextBox = new NumericBox();
            velocityLabel = new Label();
            SuspendLayout();
            // 
            // initialValueLabel
            // 
            initialValueLabel.AutoSize = true;
            initialValueLabel.Location = new Point(3, 8);
            initialValueLabel.Name = "initialValueLabel";
            initialValueLabel.Size = new Size(171, 20);
            initialValueLabel.TabIndex = 0;
            initialValueLabel.Text = "Начальная координата";
            // 
            // initialValueTextBox
            // 
            initialValueTextBox.Location = new Point(208, 4);
            initialValueTextBox.Margin = new Padding(3, 4, 3, 4);
            initialValueTextBox.Name = "initialValueTextBox";
            initialValueTextBox.Size = new Size(114, 27);
            initialValueTextBox.TabIndex = 1;
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(208, 43);
            timeTextBox.Margin = new Padding(3, 4, 3, 4);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(114, 27);
            timeTextBox.TabIndex = 3;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(3, 47);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(54, 20);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "Время";
            // 
            // velocityTextBox
            // 
            velocityTextBox.Location = new Point(208, 81);
            velocityTextBox.Margin = new Padding(3, 4, 3, 4);
            velocityTextBox.Name = "velocityTextBox";
            velocityTextBox.Size = new Size(114, 27);
            velocityTextBox.TabIndex = 5;
            // 
            // velocityLabel
            // 
            velocityLabel.AutoSize = true;
            velocityLabel.Location = new Point(3, 85);
            velocityLabel.Name = "velocityLabel";
            velocityLabel.Size = new Size(73, 20);
            velocityLabel.TabIndex = 4;
            velocityLabel.Text = "Скорость";
            // 
            // ConstantMotionUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(velocityTextBox);
            Controls.Add(velocityLabel);
            Controls.Add(timeTextBox);
            Controls.Add(timeLabel);
            Controls.Add(initialValueTextBox);
            Controls.Add(initialValueLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConstantMotionUserControl";
            Size = new Size(326, 245);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label initialValueLabel;
        internal NumericBox initialValueTextBox;
        internal NumericBox timeTextBox;
        internal Label timeLabel;
        internal NumericBox velocityTextBox;
        internal Label velocityLabel;
    }
}
