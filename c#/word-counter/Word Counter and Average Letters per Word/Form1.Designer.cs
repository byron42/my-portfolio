namespace Word_Counter_and_Average_Letters_per_Word
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.countWordsButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(30, 34);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(333, 13);
            this.instructionLabel.TabIndex = 11;
            this.instructionLabel.Text = "Type something into the box and I will tell you how many words it has.";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(213, 121);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // countWordsButton
            // 
            this.countWordsButton.Location = new System.Drawing.Point(69, 121);
            this.countWordsButton.Name = "countWordsButton";
            this.countWordsButton.Size = new System.Drawing.Size(103, 23);
            this.countWordsButton.TabIndex = 9;
            this.countWordsButton.Text = "Count Words";
            this.countWordsButton.UseVisualStyleBackColor = true;
            this.countWordsButton.Click += new System.EventHandler(this.countWordsButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(48, 68);
            this.inputTextBox.MaximumSize = new System.Drawing.Size(300, 60);
            this.inputTextBox.MinimumSize = new System.Drawing.Size(300, 60);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(300, 20);
            this.inputTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 179);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.countWordsButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Word Counter and Average Letters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button countWordsButton;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

