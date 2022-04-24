namespace Team_Leader
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
            this.inputBonusLabel = new System.Windows.Forms.Label();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.shiftTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inputRateLabel = new System.Windows.Forms.Label();
            this.inputMileageLabel = new System.Windows.Forms.Label();
            this.inputNumberLabel = new System.Windows.Forms.Label();
            this.inputNameLabel = new System.Windows.Forms.Label();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.objectGroupBox = new System.Windows.Forms.GroupBox();
            this.bonusLabel = new System.Windows.Forms.Label();
            this.outputBonusLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.outputRateLabel = new System.Windows.Forms.Label();
            this.outputMileageLabel = new System.Windows.Forms.Label();
            this.outputModelLabel = new System.Windows.Forms.Label();
            this.outputMakeLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.annualInputGroupBox = new System.Windows.Forms.GroupBox();
            this.requiredHoursTextBox = new System.Windows.Forms.TextBox();
            this.inputRequiredHoursLabel = new System.Windows.Forms.Label();
            this.earnedHoursTextBox = new System.Windows.Forms.TextBox();
            this.inputEarnedHoursLabel = new System.Windows.Forms.Label();
            this.annualOutputgroupBox = new System.Windows.Forms.GroupBox();
            this.requiredHoursLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.earnedHoursLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.objectGroupBox.SuspendLayout();
            this.annualInputGroupBox.SuspendLayout();
            this.annualOutputgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBonusLabel
            // 
            this.inputBonusLabel.AutoSize = true;
            this.inputBonusLabel.Location = new System.Drawing.Point(35, 129);
            this.inputBonusLabel.Name = "inputBonusLabel";
            this.inputBonusLabel.Size = new System.Drawing.Size(80, 13);
            this.inputBonusLabel.TabIndex = 9;
            this.inputBonusLabel.Text = "Monthly Bonus:";
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.annualInputGroupBox);
            this.inputGroupBox.Controls.Add(this.bonusTextBox);
            this.inputGroupBox.Controls.Add(this.inputBonusLabel);
            this.inputGroupBox.Controls.Add(this.rateTextBox);
            this.inputGroupBox.Controls.Add(this.shiftTextBox);
            this.inputGroupBox.Controls.Add(this.numberTextBox);
            this.inputGroupBox.Controls.Add(this.nameTextBox);
            this.inputGroupBox.Controls.Add(this.inputRateLabel);
            this.inputGroupBox.Controls.Add(this.inputMileageLabel);
            this.inputGroupBox.Controls.Add(this.inputNumberLabel);
            this.inputGroupBox.Controls.Add(this.inputNameLabel);
            this.inputGroupBox.Location = new System.Drawing.Point(27, 21);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(267, 263);
            this.inputGroupBox.TabIndex = 12;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Enter Team Leader Data";
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(118, 126);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.bonusTextBox.TabIndex = 10;
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(118, 100);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(100, 20);
            this.rateTextBox.TabIndex = 8;
            // 
            // shiftTextBox
            // 
            this.shiftTextBox.Location = new System.Drawing.Point(119, 74);
            this.shiftTextBox.Name = "shiftTextBox";
            this.shiftTextBox.Size = new System.Drawing.Size(100, 20);
            this.shiftTextBox.TabIndex = 7;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(119, 48);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(119, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // inputRateLabel
            // 
            this.inputRateLabel.AutoSize = true;
            this.inputRateLabel.Location = new System.Drawing.Point(49, 103);
            this.inputRateLabel.Name = "inputRateLabel";
            this.inputRateLabel.Size = new System.Drawing.Size(66, 13);
            this.inputRateLabel.TabIndex = 3;
            this.inputRateLabel.Text = "Hourly Rate:";
            // 
            // inputMileageLabel
            // 
            this.inputMileageLabel.AutoSize = true;
            this.inputMileageLabel.Location = new System.Drawing.Point(84, 77);
            this.inputMileageLabel.Name = "inputMileageLabel";
            this.inputMileageLabel.Size = new System.Drawing.Size(31, 13);
            this.inputMileageLabel.TabIndex = 2;
            this.inputMileageLabel.Text = "Shift:";
            // 
            // inputNumberLabel
            // 
            this.inputNumberLabel.AutoSize = true;
            this.inputNumberLabel.Location = new System.Drawing.Point(19, 51);
            this.inputNumberLabel.Name = "inputNumberLabel";
            this.inputNumberLabel.Size = new System.Drawing.Size(96, 13);
            this.inputNumberLabel.TabIndex = 1;
            this.inputNumberLabel.Text = "Employee Number:";
            // 
            // inputNameLabel
            // 
            this.inputNameLabel.AutoSize = true;
            this.inputNameLabel.Location = new System.Drawing.Point(28, 25);
            this.inputNameLabel.Name = "inputNameLabel";
            this.inputNameLabel.Size = new System.Drawing.Size(87, 13);
            this.inputNameLabel.TabIndex = 0;
            this.inputNameLabel.Text = "Employee Name:";
            // 
            // createObjectButton
            // 
            this.createObjectButton.Location = new System.Drawing.Point(114, 307);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(156, 40);
            this.createObjectButton.TabIndex = 14;
            this.createObjectButton.Text = "Create Object";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);
            // 
            // objectGroupBox
            // 
            this.objectGroupBox.Controls.Add(this.annualOutputgroupBox);
            this.objectGroupBox.Controls.Add(this.bonusLabel);
            this.objectGroupBox.Controls.Add(this.outputBonusLabel);
            this.objectGroupBox.Controls.Add(this.rateLabel);
            this.objectGroupBox.Controls.Add(this.shiftLabel);
            this.objectGroupBox.Controls.Add(this.numberLabel);
            this.objectGroupBox.Controls.Add(this.nameLabel);
            this.objectGroupBox.Controls.Add(this.outputRateLabel);
            this.objectGroupBox.Controls.Add(this.outputMileageLabel);
            this.objectGroupBox.Controls.Add(this.outputModelLabel);
            this.objectGroupBox.Controls.Add(this.outputMakeLabel);
            this.objectGroupBox.Location = new System.Drawing.Point(323, 21);
            this.objectGroupBox.Name = "objectGroupBox";
            this.objectGroupBox.Size = new System.Drawing.Size(267, 263);
            this.objectGroupBox.TabIndex = 13;
            this.objectGroupBox.TabStop = false;
            this.objectGroupBox.Text = "Object Properties";
            // 
            // bonusLabel
            // 
            this.bonusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bonusLabel.Location = new System.Drawing.Point(118, 129);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(100, 23);
            this.bonusLabel.TabIndex = 15;
            this.bonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputBonusLabel
            // 
            this.outputBonusLabel.AutoSize = true;
            this.outputBonusLabel.Location = new System.Drawing.Point(35, 134);
            this.outputBonusLabel.Name = "outputBonusLabel";
            this.outputBonusLabel.Size = new System.Drawing.Size(80, 13);
            this.outputBonusLabel.TabIndex = 14;
            this.outputBonusLabel.Text = "Monthly Bonus:";
            // 
            // rateLabel
            // 
            this.rateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rateLabel.Location = new System.Drawing.Point(118, 102);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(100, 23);
            this.rateLabel.TabIndex = 13;
            this.rateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shiftLabel
            // 
            this.shiftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shiftLabel.Location = new System.Drawing.Point(118, 76);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(100, 23);
            this.shiftLabel.TabIndex = 12;
            this.shiftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberLabel
            // 
            this.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberLabel.Location = new System.Drawing.Point(118, 50);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(100, 23);
            this.numberLabel.TabIndex = 11;
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Location = new System.Drawing.Point(118, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputRateLabel
            // 
            this.outputRateLabel.AutoSize = true;
            this.outputRateLabel.Location = new System.Drawing.Point(49, 107);
            this.outputRateLabel.Name = "outputRateLabel";
            this.outputRateLabel.Size = new System.Drawing.Size(66, 13);
            this.outputRateLabel.TabIndex = 8;
            this.outputRateLabel.Text = "Hourly Rate:";
            // 
            // outputMileageLabel
            // 
            this.outputMileageLabel.AutoSize = true;
            this.outputMileageLabel.Location = new System.Drawing.Point(84, 81);
            this.outputMileageLabel.Name = "outputMileageLabel";
            this.outputMileageLabel.Size = new System.Drawing.Size(31, 13);
            this.outputMileageLabel.TabIndex = 7;
            this.outputMileageLabel.Text = "Shift:";
            // 
            // outputModelLabel
            // 
            this.outputModelLabel.AutoSize = true;
            this.outputModelLabel.Location = new System.Drawing.Point(19, 55);
            this.outputModelLabel.Name = "outputModelLabel";
            this.outputModelLabel.Size = new System.Drawing.Size(96, 13);
            this.outputModelLabel.TabIndex = 6;
            this.outputModelLabel.Text = "Employee Number:";
            // 
            // outputMakeLabel
            // 
            this.outputMakeLabel.AutoSize = true;
            this.outputMakeLabel.Location = new System.Drawing.Point(28, 29);
            this.outputMakeLabel.Name = "outputMakeLabel";
            this.outputMakeLabel.Size = new System.Drawing.Size(87, 13);
            this.outputMakeLabel.TabIndex = 5;
            this.outputMakeLabel.Text = "Employee Name:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(345, 307);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(156, 40);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // annualInputGroupBox
            // 
            this.annualInputGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.annualInputGroupBox.Controls.Add(this.earnedHoursTextBox);
            this.annualInputGroupBox.Controls.Add(this.inputEarnedHoursLabel);
            this.annualInputGroupBox.Controls.Add(this.requiredHoursTextBox);
            this.annualInputGroupBox.Controls.Add(this.inputRequiredHoursLabel);
            this.annualInputGroupBox.Location = new System.Drawing.Point(12, 164);
            this.annualInputGroupBox.Name = "annualInputGroupBox";
            this.annualInputGroupBox.Size = new System.Drawing.Size(240, 84);
            this.annualInputGroupBox.TabIndex = 15;
            this.annualInputGroupBox.TabStop = false;
            this.annualInputGroupBox.Text = "Annual Training";
            // 
            // requiredHoursTextBox
            // 
            this.requiredHoursTextBox.Location = new System.Drawing.Point(106, 22);
            this.requiredHoursTextBox.Name = "requiredHoursTextBox";
            this.requiredHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.requiredHoursTextBox.TabIndex = 16;
            // 
            // inputRequiredHoursLabel
            // 
            this.inputRequiredHoursLabel.AutoSize = true;
            this.inputRequiredHoursLabel.Location = new System.Drawing.Point(21, 25);
            this.inputRequiredHoursLabel.Name = "inputRequiredHoursLabel";
            this.inputRequiredHoursLabel.Size = new System.Drawing.Size(84, 13);
            this.inputRequiredHoursLabel.TabIndex = 15;
            this.inputRequiredHoursLabel.Text = "Reqiured Hours:";
            // 
            // earnedHoursTextBox
            // 
            this.earnedHoursTextBox.Location = new System.Drawing.Point(106, 48);
            this.earnedHoursTextBox.Name = "earnedHoursTextBox";
            this.earnedHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.earnedHoursTextBox.TabIndex = 18;
            // 
            // inputEarnedHoursLabel
            // 
            this.inputEarnedHoursLabel.AutoSize = true;
            this.inputEarnedHoursLabel.Location = new System.Drawing.Point(30, 51);
            this.inputEarnedHoursLabel.Name = "inputEarnedHoursLabel";
            this.inputEarnedHoursLabel.Size = new System.Drawing.Size(75, 13);
            this.inputEarnedHoursLabel.TabIndex = 17;
            this.inputEarnedHoursLabel.Text = "Earned Hours:";
            // 
            // annualOutputgroupBox
            // 
            this.annualOutputgroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.annualOutputgroupBox.Controls.Add(this.earnedHoursLabel);
            this.annualOutputgroupBox.Controls.Add(this.label4);
            this.annualOutputgroupBox.Controls.Add(this.requiredHoursLabel);
            this.annualOutputgroupBox.Controls.Add(this.label2);
            this.annualOutputgroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.annualOutputgroupBox.Location = new System.Drawing.Point(14, 164);
            this.annualOutputgroupBox.Name = "annualOutputgroupBox";
            this.annualOutputgroupBox.Size = new System.Drawing.Size(240, 84);
            this.annualOutputgroupBox.TabIndex = 16;
            this.annualOutputgroupBox.TabStop = false;
            this.annualOutputgroupBox.Text = "Annual Training";
            // 
            // requiredHoursLabel
            // 
            this.requiredHoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requiredHoursLabel.Location = new System.Drawing.Point(104, 20);
            this.requiredHoursLabel.Name = "requiredHoursLabel";
            this.requiredHoursLabel.Size = new System.Drawing.Size(100, 23);
            this.requiredHoursLabel.TabIndex = 18;
            this.requiredHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Required Hours:";
            // 
            // earnedHoursLabel
            // 
            this.earnedHoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.earnedHoursLabel.Location = new System.Drawing.Point(104, 46);
            this.earnedHoursLabel.Name = "earnedHoursLabel";
            this.earnedHoursLabel.Size = new System.Drawing.Size(100, 23);
            this.earnedHoursLabel.TabIndex = 20;
            this.earnedHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Earned Hours:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 369);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.objectGroupBox);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Team Leader";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.objectGroupBox.ResumeLayout(false);
            this.objectGroupBox.PerformLayout();
            this.annualInputGroupBox.ResumeLayout(false);
            this.annualInputGroupBox.PerformLayout();
            this.annualOutputgroupBox.ResumeLayout(false);
            this.annualOutputgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label inputBonusLabel;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox shiftTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label inputRateLabel;
        private System.Windows.Forms.Label inputMileageLabel;
        private System.Windows.Forms.Label inputNumberLabel;
        private System.Windows.Forms.Label inputNameLabel;
        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.GroupBox objectGroupBox;
        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.Label outputBonusLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label outputRateLabel;
        private System.Windows.Forms.Label outputMileageLabel;
        private System.Windows.Forms.Label outputModelLabel;
        private System.Windows.Forms.Label outputMakeLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox annualInputGroupBox;
        private System.Windows.Forms.TextBox earnedHoursTextBox;
        private System.Windows.Forms.Label inputEarnedHoursLabel;
        private System.Windows.Forms.TextBox requiredHoursTextBox;
        private System.Windows.Forms.Label inputRequiredHoursLabel;
        private System.Windows.Forms.GroupBox annualOutputgroupBox;
        private System.Windows.Forms.Label earnedHoursLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label requiredHoursLabel;
        private System.Windows.Forms.Label label2;
    }
}

