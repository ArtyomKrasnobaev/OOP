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
            motionTypeGroupBox = new GroupBox();
            oscillatoryMotionRadioButton = new RadioButton();
            acceleratedMotionRadioButton = new RadioButton();
            constantMotionRadioButton = new RadioButton();
            parametersGroupBox = new GroupBox();
            oscillatoryMotionUserControl1 = new OscillatoryMotionUserControl();
            acceleratedMotionUserControl1 = new AcceleratedMotionUserControl();
            constantMotionUserControl1 = new ConstantMotionUserControl();
            addButton = new Button();
            cancelButton = new Button();
            motionTypeGroupBox.SuspendLayout();
            parametersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // motionTypeGroupBox
            // 
            motionTypeGroupBox.Controls.Add(oscillatoryMotionRadioButton);
            motionTypeGroupBox.Controls.Add(acceleratedMotionRadioButton);
            motionTypeGroupBox.Controls.Add(constantMotionRadioButton);
            motionTypeGroupBox.Location = new Point(14, 15);
            motionTypeGroupBox.Name = "motionTypeGroupBox";
            motionTypeGroupBox.Size = new Size(350, 144);
            motionTypeGroupBox.TabIndex = 3;
            motionTypeGroupBox.TabStop = false;
            motionTypeGroupBox.Text = "Тип движения";
            // 
            // oscillatoryMotionRadioButton
            // 
            oscillatoryMotionRadioButton.AutoSize = true;
            oscillatoryMotionRadioButton.Location = new Point(7, 95);
            oscillatoryMotionRadioButton.Margin = new Padding(3, 4, 3, 4);
            oscillatoryMotionRadioButton.Name = "oscillatoryMotionRadioButton";
            oscillatoryMotionRadioButton.Size = new Size(137, 24);
            oscillatoryMotionRadioButton.TabIndex = 5;
            oscillatoryMotionRadioButton.TabStop = true;
            oscillatoryMotionRadioButton.Text = "Колебательное";
            oscillatoryMotionRadioButton.UseVisualStyleBackColor = true;
            oscillatoryMotionRadioButton.CheckedChanged += oscillatedMotionButton_CheckedChanged;
            // 
            // acceleratedMotionRadioButton
            // 
            acceleratedMotionRadioButton.AutoSize = true;
            acceleratedMotionRadioButton.Location = new Point(7, 61);
            acceleratedMotionRadioButton.Margin = new Padding(3, 4, 3, 4);
            acceleratedMotionRadioButton.Name = "acceleratedMotionRadioButton";
            acceleratedMotionRadioButton.Size = new Size(154, 24);
            acceleratedMotionRadioButton.TabIndex = 4;
            acceleratedMotionRadioButton.TabStop = true;
            acceleratedMotionRadioButton.Text = "Равноускоренное";
            acceleratedMotionRadioButton.UseVisualStyleBackColor = true;
            acceleratedMotionRadioButton.CheckedChanged += acceleratedMotionButton_CheckedChanged;
            // 
            // constantMotionRadioButton
            // 
            constantMotionRadioButton.AutoSize = true;
            constantMotionRadioButton.Location = new Point(7, 28);
            constantMotionRadioButton.Margin = new Padding(3, 4, 3, 4);
            constantMotionRadioButton.Name = "constantMotionRadioButton";
            constantMotionRadioButton.Size = new Size(126, 24);
            constantMotionRadioButton.TabIndex = 0;
            constantMotionRadioButton.TabStop = true;
            constantMotionRadioButton.Text = "Равномерное";
            constantMotionRadioButton.UseVisualStyleBackColor = true;
            constantMotionRadioButton.CheckedChanged += constantMotionButton_CheckedChanged;
            // 
            // parametersGroupBox
            // 
            parametersGroupBox.Controls.Add(oscillatoryMotionUserControl1);
            parametersGroupBox.Controls.Add(acceleratedMotionUserControl1);
            parametersGroupBox.Controls.Add(constantMotionUserControl1);
            parametersGroupBox.Location = new Point(14, 164);
            parametersGroupBox.Name = "parametersGroupBox";
            parametersGroupBox.Size = new Size(350, 199);
            parametersGroupBox.TabIndex = 4;
            parametersGroupBox.TabStop = false;
            parametersGroupBox.Text = "Параметры движения";
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
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButtonClick;
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
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(389, 415);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(parametersGroupBox);
            Controls.Add(motionTypeGroupBox);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить";
            motionTypeGroupBox.ResumeLayout(false);
            motionTypeGroupBox.PerformLayout();
            parametersGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox motionTypeGroupBox;
        private RadioButton oscillatoryMotionRadioButton;
        private RadioButton acceleratedMotionRadioButton;
        private RadioButton constantMotionRadioButton;
        private GroupBox parametersGroupBox;
        private OscillatoryMotionUserControl oscillatoryMotionUserControl;
        private ConstantMotionUserControl constantMotionUserControl1;
        private AcceleratedMotionUserControl acceleratedMotionUserControl1;
        private OscillatoryMotionUserControl oscillatoryMotionUserControl1;
        private Button addButton;
        private Button cancelButton;
    }
}