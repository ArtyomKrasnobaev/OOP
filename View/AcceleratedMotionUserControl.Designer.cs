namespace View
{
    partial class AcceleratedMotionUserControl
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
            velocityTextBox = new TextBox();
            velocityLabel = new Label();
            timeTextBox = new TextBox();
            timeLabel = new Label();
            initialValueTextBox = new TextBox();
            initialValueLabel = new Label();
            accelerationTextBox = new TextBox();
            accelerationLabel = new Label();
            SuspendLayout();
            // 
            // velocityTextBox
            // 
            velocityTextBox.Location = new Point(208, 81);
            velocityTextBox.Margin = new Padding(3, 4, 3, 4);
            velocityTextBox.Name = "velocityTextBox";
            velocityTextBox.Size = new Size(114, 27);
            velocityTextBox.TabIndex = 11;
            // 
            // velocityLabel
            // 
            velocityLabel.AutoSize = true;
            velocityLabel.Location = new Point(3, 85);
            velocityLabel.Name = "velocityLabel";
            velocityLabel.Size = new Size(73, 20);
            velocityLabel.TabIndex = 10;
            velocityLabel.Text = "Скорость";
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(208, 43);
            timeTextBox.Margin = new Padding(3, 4, 3, 4);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(114, 27);
            timeTextBox.TabIndex = 9;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(3, 47);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(54, 20);
            timeLabel.TabIndex = 8;
            timeLabel.Text = "Время";
            // 
            // initialValueTextBox
            // 
            initialValueTextBox.Location = new Point(208, 4);
            initialValueTextBox.Margin = new Padding(3, 4, 3, 4);
            initialValueTextBox.Name = "initialValueTextBox";
            initialValueTextBox.Size = new Size(114, 27);
            initialValueTextBox.TabIndex = 7;
            // 
            // initialValueLabel
            // 
            initialValueLabel.AutoSize = true;
            initialValueLabel.Location = new Point(3, 8);
            initialValueLabel.Name = "initialValueLabel";
            initialValueLabel.Size = new Size(171, 20);
            initialValueLabel.TabIndex = 6;
            initialValueLabel.Text = "Начальная координата";
            // 
            // accelerationTextBox
            // 
            accelerationTextBox.Location = new Point(208, 120);
            accelerationTextBox.Margin = new Padding(3, 4, 3, 4);
            accelerationTextBox.Name = "accelerationTextBox";
            accelerationTextBox.Size = new Size(114, 27);
            accelerationTextBox.TabIndex = 13;
            // 
            // accelerationLabel
            // 
            accelerationLabel.AutoSize = true;
            accelerationLabel.Location = new Point(3, 124);
            accelerationLabel.Name = "accelerationLabel";
            accelerationLabel.Size = new Size(84, 20);
            accelerationLabel.TabIndex = 12;
            accelerationLabel.Text = "Ускорение";
            // 
            // AcceleratedMotionUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(accelerationTextBox);
            Controls.Add(accelerationLabel);
            Controls.Add(velocityTextBox);
            Controls.Add(velocityLabel);
            Controls.Add(timeTextBox);
            Controls.Add(timeLabel);
            Controls.Add(initialValueTextBox);
            Controls.Add(initialValueLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AcceleratedMotionUserControl";
            Size = new Size(326, 245);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox velocityTextBox;
        internal Label velocityLabel;
        internal TextBox timeTextBox;
        internal Label timeLabel;
        internal TextBox initialValueTextBox;
        internal Label initialValueLabel;
        internal TextBox accelerationTextBox;
        internal Label accelerationLabel;
    }
}
