namespace View
{
    partial class AddForm
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
            oscillatedMotionButton = new RadioButton();
            acceleratedMotionButton = new RadioButton();
            constantMotionButton = new RadioButton();
            groupBox2 = new GroupBox();
            oscillatoryMotionUserControl1 = new OscillatoryMotionUserControl();
            acceleratedMotionUserControl1 = new AcceleratedMotionUserControl();
            constantMotionUserControl1 = new ConstantMotionUserControl();
            addButton = new Button();
            cancelButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(oscillatedMotionButton);
            groupBox1.Controls.Add(acceleratedMotionButton);
            groupBox1.Controls.Add(constantMotionButton);
            groupBox1.Location = new Point(14, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 144);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип движения";
            // 
            // oscillatedMotionButton
            // 
            oscillatedMotionButton.AutoSize = true;
            oscillatedMotionButton.Location = new Point(7, 95);
            oscillatedMotionButton.Margin = new Padding(3, 4, 3, 4);
            oscillatedMotionButton.Name = "oscillatedMotionButton";
            oscillatedMotionButton.Size = new Size(137, 24);
            oscillatedMotionButton.TabIndex = 5;
            oscillatedMotionButton.TabStop = true;
            oscillatedMotionButton.Text = "Колебательное";
            oscillatedMotionButton.UseVisualStyleBackColor = true;
            oscillatedMotionButton.CheckedChanged += oscillatedMotionButton_CheckedChanged;
            // 
            // acceleratedMotionButton
            // 
            acceleratedMotionButton.AutoSize = true;
            acceleratedMotionButton.Location = new Point(7, 61);
            acceleratedMotionButton.Margin = new Padding(3, 4, 3, 4);
            acceleratedMotionButton.Name = "acceleratedMotionButton";
            acceleratedMotionButton.Size = new Size(154, 24);
            acceleratedMotionButton.TabIndex = 4;
            acceleratedMotionButton.TabStop = true;
            acceleratedMotionButton.Text = "Равноускоренное";
            acceleratedMotionButton.UseVisualStyleBackColor = true;
            acceleratedMotionButton.CheckedChanged += acceleratedMotionButton_CheckedChanged;
            // 
            // constantMotionButton
            // 
            constantMotionButton.AutoSize = true;
            constantMotionButton.Location = new Point(7, 28);
            constantMotionButton.Margin = new Padding(3, 4, 3, 4);
            constantMotionButton.Name = "constantMotionButton";
            constantMotionButton.Size = new Size(126, 24);
            constantMotionButton.TabIndex = 0;
            constantMotionButton.TabStop = true;
            constantMotionButton.Text = "Равномерное";
            constantMotionButton.UseVisualStyleBackColor = true;
            constantMotionButton.CheckedChanged += constantMotionButton_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(oscillatoryMotionUserControl1);
            groupBox2.Controls.Add(acceleratedMotionUserControl1);
            groupBox2.Controls.Add(constantMotionUserControl1);
            groupBox2.Location = new Point(14, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 199);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Параметры движения";
            // 
            // oscillatoryMotionUserControl1
            // 
            oscillatoryMotionUserControl1.Location = new Point(7, 28);
            oscillatoryMotionUserControl1.Margin = new Padding(3, 5, 3, 5);
            oscillatoryMotionUserControl1.Name = "oscillatoryMotionUserControl1";
            oscillatoryMotionUserControl1.Size = new Size(326, 155);
            oscillatoryMotionUserControl1.TabIndex = 5;
            oscillatoryMotionUserControl1.Visible = false;
            // 
            // acceleratedMotionUserControl1
            // 
            acceleratedMotionUserControl1.Location = new Point(7, 28);
            acceleratedMotionUserControl1.Margin = new Padding(3, 5, 3, 5);
            acceleratedMotionUserControl1.Name = "acceleratedMotionUserControl1";
            acceleratedMotionUserControl1.Size = new Size(326, 155);
            acceleratedMotionUserControl1.TabIndex = 5;
            acceleratedMotionUserControl1.Visible = false;
            // 
            // constantMotionUserControl1
            // 
            constantMotionUserControl1.Location = new Point(7, 28);
            constantMotionUserControl1.Margin = new Padding(3, 5, 3, 5);
            constantMotionUserControl1.Name = "constantMotionUserControl1";
            constantMotionUserControl1.Size = new Size(326, 155);
            constantMotionUserControl1.TabIndex = 0;
            constantMotionUserControl1.Visible = false;
            // 
            // addButton
            // 
            addButton.Location = new Point(14, 368);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 32);
            addButton.TabIndex = 5;
            addButton.Text = "Далее";
            addButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(133, 368);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 32);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Закрыть";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += button1_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 415);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AddForm";
            Text = "Добавить";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton oscillatedMotionButton;
        private RadioButton acceleratedMotionButton;
        private RadioButton constantMotionButton;
        private GroupBox groupBox2;
        private OscillatoryMotionUserControl oscillatoryMotionUserControl;
        private ConstantMotionUserControl constantMotionUserControl1;
        private AcceleratedMotionUserControl acceleratedMotionUserControl1;
        private OscillatoryMotionUserControl oscillatoryMotionUserControl1;
        private Button addButton;
        private Button cancelButton;
    }
}