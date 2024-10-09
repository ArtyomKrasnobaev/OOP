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
            _motionTypeGroupBox = new GroupBox();
            _oscillatoryMotionRadioButton = new RadioButton();
            _acceleratedMotionRadioButton = new RadioButton();
            _constantMotionRadioButton = new RadioButton();
            _parametersGroupBox = new GroupBox();
            oscillatoryMotionUserControl = new OscillatoryMotionUserControl();
            acceleratedMotionUserControl = new AcceleratedMotionUserControl();
            constantMotionUserControl = new ConstantMotionUserControl();
            _addButton = new Button();
            _cancelButton = new Button();
            _motionTypeGroupBox.SuspendLayout();
            _parametersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // _motionTypeGroupBox
            // 
            _motionTypeGroupBox.Controls.Add(_oscillatoryMotionRadioButton);
            _motionTypeGroupBox.Controls.Add(_acceleratedMotionRadioButton);
            _motionTypeGroupBox.Controls.Add(_constantMotionRadioButton);
            _motionTypeGroupBox.Location = new Point(12, 12);
            _motionTypeGroupBox.Name = "_motionTypeGroupBox";
            _motionTypeGroupBox.Size = new Size(350, 144);
            _motionTypeGroupBox.TabIndex = 3;
            _motionTypeGroupBox.TabStop = false;
            _motionTypeGroupBox.Text = "Тип движения";
            // 
            // _oscillatoryMotionRadioButton
            // 
            _oscillatoryMotionRadioButton.AutoSize = true;
            _oscillatoryMotionRadioButton.Location = new Point(7, 95);
            _oscillatoryMotionRadioButton.Margin = new Padding(3, 4, 3, 4);
            _oscillatoryMotionRadioButton.Name = "_oscillatoryMotionRadioButton";
            _oscillatoryMotionRadioButton.Size = new Size(137, 24);
            _oscillatoryMotionRadioButton.TabIndex = 5;
            _oscillatoryMotionRadioButton.TabStop = true;
            _oscillatoryMotionRadioButton.Text = "Колебательное";
            _oscillatoryMotionRadioButton.UseVisualStyleBackColor = true;
            // 
            // _acceleratedMotionRadioButton
            // 
            _acceleratedMotionRadioButton.AutoSize = true;
            _acceleratedMotionRadioButton.Location = new Point(7, 61);
            _acceleratedMotionRadioButton.Margin = new Padding(3, 4, 3, 4);
            _acceleratedMotionRadioButton.Name = "_acceleratedMotionRadioButton";
            _acceleratedMotionRadioButton.Size = new Size(154, 24);
            _acceleratedMotionRadioButton.TabIndex = 4;
            _acceleratedMotionRadioButton.TabStop = true;
            _acceleratedMotionRadioButton.Text = "Равноускоренное";
            _acceleratedMotionRadioButton.UseVisualStyleBackColor = true;
            // 
            // _constantMotionRadioButton
            // 
            _constantMotionRadioButton.AutoSize = true;
            _constantMotionRadioButton.Location = new Point(7, 28);
            _constantMotionRadioButton.Margin = new Padding(3, 4, 3, 4);
            _constantMotionRadioButton.Name = "_constantMotionRadioButton";
            _constantMotionRadioButton.Size = new Size(126, 24);
            _constantMotionRadioButton.TabIndex = 0;
            _constantMotionRadioButton.TabStop = true;
            _constantMotionRadioButton.Text = "Равномерное";
            _constantMotionRadioButton.UseVisualStyleBackColor = true;
            // 
            // _parametersGroupBox
            // 
            _parametersGroupBox.Controls.Add(oscillatoryMotionUserControl);
            _parametersGroupBox.Controls.Add(acceleratedMotionUserControl);
            _parametersGroupBox.Controls.Add(constantMotionUserControl);
            _parametersGroupBox.Location = new Point(12, 162);
            _parametersGroupBox.Name = "_parametersGroupBox";
            _parametersGroupBox.Size = new Size(350, 199);
            _parametersGroupBox.TabIndex = 4;
            _parametersGroupBox.TabStop = false;
            _parametersGroupBox.Text = "Параметры движения";
            // 
            // oscillatoryMotionUserControl
            // 
            oscillatoryMotionUserControl.Location = new Point(7, 28);
            oscillatoryMotionUserControl.Margin = new Padding(3, 5, 3, 5);
            oscillatoryMotionUserControl.Name = "oscillatoryMotionUserControl";
            oscillatoryMotionUserControl.Size = new Size(326, 155);
            oscillatoryMotionUserControl.TabIndex = 5;
            oscillatoryMotionUserControl.Visible = false;
            // 
            // acceleratedMotionUserControl
            // 
            acceleratedMotionUserControl.Location = new Point(7, 28);
            acceleratedMotionUserControl.Margin = new Padding(3, 5, 3, 5);
            acceleratedMotionUserControl.Name = "acceleratedMotionUserControl";
            acceleratedMotionUserControl.Size = new Size(326, 155);
            acceleratedMotionUserControl.TabIndex = 5;
            acceleratedMotionUserControl.Visible = false;
            // 
            // constantMotionUserControl
            // 
            constantMotionUserControl.Location = new Point(7, 28);
            constantMotionUserControl.Margin = new Padding(3, 5, 3, 5);
            constantMotionUserControl.Name = "constantMotionUserControl";
            constantMotionUserControl.Size = new Size(326, 155);
            constantMotionUserControl.TabIndex = 0;
            constantMotionUserControl.Visible = false;
            // 
            // _addButton
            // 
            _addButton.Location = new Point(14, 368);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(112, 32);
            _addButton.TabIndex = 5;
            _addButton.Text = "Добавить";
            _addButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            _cancelButton.Location = new Point(133, 368);
            _cancelButton.Name = "_cancelButton";
            _cancelButton.Size = new Size(112, 32);
            _cancelButton.TabIndex = 6;
            _cancelButton.Text = "Закрыть";
            _cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(389, 415);
            Controls.Add(_cancelButton);
            Controls.Add(_addButton);
            Controls.Add(_parametersGroupBox);
            Controls.Add(_motionTypeGroupBox);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить";
            _motionTypeGroupBox.ResumeLayout(false);
            _motionTypeGroupBox.PerformLayout();
            _parametersGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox _motionTypeGroupBox;
        private RadioButton _oscillatoryMotionRadioButton;
        private RadioButton _acceleratedMotionRadioButton;
        private RadioButton _constantMotionRadioButton;
        private GroupBox _parametersGroupBox;
        private ConstantMotionUserControl constantMotionUserControl;
        private AcceleratedMotionUserControl acceleratedMotionUserControl;
        private OscillatoryMotionUserControl oscillatoryMotionUserControl;
        private Button _addButton;
        private Button _cancelButton;
    }
}