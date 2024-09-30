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
            groupBox1 = new GroupBox();
            checkBoxOscillatoryMotion = new CheckBox();
            checkBoxAcceleratedMotion = new CheckBox();
            checkBoxConstantMotion = new CheckBox();
            buttonOK = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxOscillatoryMotion);
            groupBox1.Controls.Add(checkBoxAcceleratedMotion);
            groupBox1.Controls.Add(checkBoxConstantMotion);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип движения";
            // 
            // checkBoxOscillatoryMotion
            // 
            checkBoxOscillatoryMotion.AutoSize = true;
            checkBoxOscillatoryMotion.Location = new Point(7, 95);
            checkBoxOscillatoryMotion.Margin = new Padding(3, 4, 3, 4);
            checkBoxOscillatoryMotion.Name = "checkBoxOscillatoryMotion";
            checkBoxOscillatoryMotion.Size = new Size(138, 24);
            checkBoxOscillatoryMotion.TabIndex = 3;
            checkBoxOscillatoryMotion.Text = "Колебательное";
            checkBoxOscillatoryMotion.UseVisualStyleBackColor = true;
            // 
            // checkBoxAcceleratedMotion
            // 
            checkBoxAcceleratedMotion.AutoSize = true;
            checkBoxAcceleratedMotion.Location = new Point(7, 61);
            checkBoxAcceleratedMotion.Margin = new Padding(3, 4, 3, 4);
            checkBoxAcceleratedMotion.Name = "checkBoxAcceleratedMotion";
            checkBoxAcceleratedMotion.Size = new Size(155, 24);
            checkBoxAcceleratedMotion.TabIndex = 2;
            checkBoxAcceleratedMotion.Text = "Равноускоренное";
            checkBoxAcceleratedMotion.UseVisualStyleBackColor = true;
            // 
            // checkBoxConstantMotion
            // 
            checkBoxConstantMotion.AutoSize = true;
            checkBoxConstantMotion.Location = new Point(7, 28);
            checkBoxConstantMotion.Margin = new Padding(3, 4, 3, 4);
            checkBoxConstantMotion.Name = "checkBoxConstantMotion";
            checkBoxConstantMotion.Size = new Size(127, 24);
            checkBoxConstantMotion.TabIndex = 1;
            checkBoxConstantMotion.Text = "Равномерное";
            checkBoxConstantMotion.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(12, 371);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(112, 32);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "ОК";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 415);
            Controls.Add(buttonOK);
            Controls.Add(groupBox1);
            Name = "FilterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки фильтрации";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBoxOscillatoryMotion;
        private CheckBox checkBoxAcceleratedMotion;
        private CheckBox checkBoxConstantMotion;
        private Button buttonOK;
    }
}