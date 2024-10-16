namespace View
{
    partial class FilterForm
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
            _oscillatoryMotionCheckBox = new CheckBox();
            _acceleratedMotionCheckBox = new CheckBox();
            _constantMotionCheckBox = new CheckBox();
            _okButton = new Button();
            _parametersGroupBox = new GroupBox();
            _timeTextBox = new NumericBox();
            _initialValueTextBox = new NumericNegativeBox();
            _timeCheckBox = new CheckBox();
            _initialValueCheckBox = new CheckBox();
            _motionTypeGroupBox.SuspendLayout();
            _parametersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // _motionTypeGroupBox
            // 
            _motionTypeGroupBox.Controls.Add(_oscillatoryMotionCheckBox);
            _motionTypeGroupBox.Controls.Add(_acceleratedMotionCheckBox);
            _motionTypeGroupBox.Controls.Add(_constantMotionCheckBox);
            _motionTypeGroupBox.Location = new Point(12, 12);
            _motionTypeGroupBox.Name = "_motionTypeGroupBox";
            _motionTypeGroupBox.Size = new Size(350, 144);
            _motionTypeGroupBox.TabIndex = 0;
            _motionTypeGroupBox.TabStop = false;
            _motionTypeGroupBox.Text = "Тип движения";
            // 
            // _oscillatoryMotionCheckBox
            // 
            _oscillatoryMotionCheckBox.AutoSize = true;
            _oscillatoryMotionCheckBox.Location = new Point(7, 95);
            _oscillatoryMotionCheckBox.Margin = new Padding(3, 4, 3, 4);
            _oscillatoryMotionCheckBox.Name = "_oscillatoryMotionCheckBox";
            _oscillatoryMotionCheckBox.Size = new Size(138, 24);
            _oscillatoryMotionCheckBox.TabIndex = 3;
            _oscillatoryMotionCheckBox.Text = "Колебательное";
            _oscillatoryMotionCheckBox.UseVisualStyleBackColor = true;
            // 
            // _acceleratedMotionCheckBox
            // 
            _acceleratedMotionCheckBox.AutoSize = true;
            _acceleratedMotionCheckBox.Location = new Point(7, 61);
            _acceleratedMotionCheckBox.Margin = new Padding(3, 4, 3, 4);
            _acceleratedMotionCheckBox.Name = "_acceleratedMotionCheckBox";
            _acceleratedMotionCheckBox.Size = new Size(155, 24);
            _acceleratedMotionCheckBox.TabIndex = 2;
            _acceleratedMotionCheckBox.Text = "Равноускоренное";
            _acceleratedMotionCheckBox.UseVisualStyleBackColor = true;
            // 
            // _constantMotionCheckBox
            // 
            _constantMotionCheckBox.AutoSize = true;
            _constantMotionCheckBox.Location = new Point(7, 28);
            _constantMotionCheckBox.Margin = new Padding(3, 4, 3, 4);
            _constantMotionCheckBox.Name = "_constantMotionCheckBox";
            _constantMotionCheckBox.Size = new Size(127, 24);
            _constantMotionCheckBox.TabIndex = 1;
            _constantMotionCheckBox.Text = "Равномерное";
            _constantMotionCheckBox.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            _okButton.Location = new Point(12, 285);
            _okButton.Name = "_okButton";
            _okButton.Size = new Size(112, 32);
            _okButton.TabIndex = 1;
            _okButton.Text = "ОК";
            _okButton.UseVisualStyleBackColor = true;
            // 
            // _parametersGroupBox
            // 
            _parametersGroupBox.Controls.Add(_timeTextBox);
            _parametersGroupBox.Controls.Add(_initialValueTextBox);
            _parametersGroupBox.Controls.Add(_timeCheckBox);
            _parametersGroupBox.Controls.Add(_initialValueCheckBox);
            _parametersGroupBox.Location = new Point(12, 162);
            _parametersGroupBox.Name = "_parametersGroupBox";
            _parametersGroupBox.Size = new Size(350, 117);
            _parametersGroupBox.TabIndex = 2;
            _parametersGroupBox.TabStop = false;
            _parametersGroupBox.Text = "Параметры движения";
            // 
            // _timeTextBox
            // 
            _timeTextBox.Location = new Point(230, 63);
            _timeTextBox.MaxLength = 10;
            _timeTextBox.Name = "_timeTextBox";
            _timeTextBox.Size = new Size(114, 27);
            _timeTextBox.TabIndex = 3;
            // 
            // _initialValueTextBox
            // 
            _initialValueTextBox.Location = new Point(230, 24);
            _initialValueTextBox.MaxLength = 10;
            _initialValueTextBox.Name = "_initialValueTextBox";
            _initialValueTextBox.Size = new Size(114, 27);
            _initialValueTextBox.TabIndex = 2;
            // 
            // _timeCheckBox
            // 
            _timeCheckBox.AutoSize = true;
            _timeCheckBox.Location = new Point(7, 65);
            _timeCheckBox.Name = "_timeCheckBox";
            _timeCheckBox.Size = new Size(76, 24);
            _timeCheckBox.TabIndex = 1;
            _timeCheckBox.Text = "Время";
            _timeCheckBox.UseVisualStyleBackColor = true;
            // 
            // _initialValueCheckBox
            // 
            _initialValueCheckBox.AutoSize = true;
            _initialValueCheckBox.Location = new Point(6, 26);
            _initialValueCheckBox.Name = "_initialValueCheckBox";
            _initialValueCheckBox.Size = new Size(193, 24);
            _initialValueCheckBox.TabIndex = 0;
            _initialValueCheckBox.Text = "Начальная координата";
            _initialValueCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(389, 335);
            Controls.Add(_parametersGroupBox);
            Controls.Add(_okButton);
            Controls.Add(_motionTypeGroupBox);
            MaximizeBox = false;
            Name = "FilterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки фильтрации";
            _motionTypeGroupBox.ResumeLayout(false);
            _motionTypeGroupBox.PerformLayout();
            _parametersGroupBox.ResumeLayout(false);
            _parametersGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _motionTypeGroupBox;
        private CheckBox _oscillatoryMotionCheckBox;
        private CheckBox _acceleratedMotionCheckBox;
        private CheckBox _constantMotionCheckBox;
        private Button _okButton;
        private GroupBox _parametersGroupBox;
        private CheckBox _initialValueCheckBox;
        private CheckBox _timeCheckBox;
        private NumericNegativeBox _initialValueTextBox;
        private NumericBox _timeTextBox;
    }
}