namespace ComputerScienceStudentAbstract
{
    partial class Form1
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
            this.getRequiredHoursButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.requiredHoursLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.infoSystemsRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentsIDLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.studentsNameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getRequiredHoursButton
            // 
            this.getRequiredHoursButton.Location = new System.Drawing.Point(265, 602);
            this.getRequiredHoursButton.Name = "getRequiredHoursButton";
            this.getRequiredHoursButton.Size = new System.Drawing.Size(167, 120);
            this.getRequiredHoursButton.TabIndex = 0;
            this.getRequiredHoursButton.Text = "Get Required Hours";
            this.getRequiredHoursButton.UseVisualStyleBackColor = true;
            this.getRequiredHoursButton.Click += new System.EventHandler(this.getRequiredHoursButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(451, 602);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(167, 120);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Required Hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Academic Track:";
            // 
            // requiredHoursLabel
            // 
            this.requiredHoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requiredHoursLabel.Location = new System.Drawing.Point(253, 439);
            this.requiredHoursLabel.Name = "requiredHoursLabel";
            this.requiredHoursLabel.Size = new System.Drawing.Size(242, 39);
            this.requiredHoursLabel.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(376, 83);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(242, 39);
            this.nameTextBox.TabIndex = 9;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(253, 111);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(242, 39);
            this.idTextBox.TabIndex = 10;
            // 
            // infoSystemsRadioButton
            // 
            this.infoSystemsRadioButton.AutoSize = true;
            this.infoSystemsRadioButton.Location = new System.Drawing.Point(258, 178);
            this.infoSystemsRadioButton.Name = "infoSystemsRadioButton";
            this.infoSystemsRadioButton.Size = new System.Drawing.Size(237, 29);
            this.infoSystemsRadioButton.TabIndex = 11;
            this.infoSystemsRadioButton.TabStop = true;
            this.infoSystemsRadioButton.Text = "Information Systems";
            this.infoSystemsRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AccessibleDescription = "softwareEngineeringRadioButton";
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(258, 240);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(248, 29);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Software Engineering";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.studentsIDLabel);
            this.groupBox1.Controls.Add(this.infoSystemsRadioButton);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.studentsNameLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.requiredHoursLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(123, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 525);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // studentsIDLabel
            // 
            this.studentsIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentsIDLabel.Location = new System.Drawing.Point(253, 378);
            this.studentsIDLabel.Name = "studentsIDLabel";
            this.studentsIDLabel.Size = new System.Drawing.Size(242, 39);
            this.studentsIDLabel.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Studnet\'s ID:";
            // 
            // studentsNameLabel
            // 
            this.studentsNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentsNameLabel.Location = new System.Drawing.Point(253, 311);
            this.studentsNameLabel.Name = "studentsNameLabel";
            this.studentsNameLabel.Size = new System.Drawing.Size(242, 39);
            this.studentsNameLabel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Student\'s Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 771);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getRequiredHoursButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Computer Science Student";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getRequiredHoursButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label requiredHoursLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.RadioButton infoSystemsRadioButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label studentsIDLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label studentsNameLabel;
        private System.Windows.Forms.Label label6;
    }
}

