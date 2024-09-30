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
            label3 = new Label();
            timeTextBox = new TextBox();
            label2 = new Label();
            initialValueTextBox = new TextBox();
            label1 = new Label();
            accelerationTextBox = new TextBox();
            label4 = new Label();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 85);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 10;
            label3.Text = "Скорость";
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(208, 43);
            timeTextBox.Margin = new Padding(3, 4, 3, 4);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(114, 27);
            timeTextBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 47);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 8;
            label2.Text = "Время";
            // 
            // initialValueTextBox
            // 
            initialValueTextBox.Location = new Point(208, 4);
            initialValueTextBox.Margin = new Padding(3, 4, 3, 4);
            initialValueTextBox.Name = "initialValueTextBox";
            initialValueTextBox.Size = new Size(114, 27);
            initialValueTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 6;
            label1.Text = "Начальная координата";
            // 
            // accelerationTextBox
            // 
            accelerationTextBox.Location = new Point(208, 120);
            accelerationTextBox.Margin = new Padding(3, 4, 3, 4);
            accelerationTextBox.Name = "accelerationTextBox";
            accelerationTextBox.Size = new Size(114, 27);
            accelerationTextBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 124);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 12;
            label4.Text = "Ускорение";
            // 
            // AcceleratedMotionUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(accelerationTextBox);
            Controls.Add(label4);
            Controls.Add(velocityTextBox);
            Controls.Add(label3);
            Controls.Add(timeTextBox);
            Controls.Add(label2);
            Controls.Add(initialValueTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AcceleratedMotionUserControl";
            Size = new Size(326, 245);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox velocityTextBox;
        internal Label label3;
        internal TextBox timeTextBox;
        internal Label label2;
        internal TextBox initialValueTextBox;
        internal Label label1;
        internal TextBox accelerationTextBox;
        internal Label label4;
    }
}
