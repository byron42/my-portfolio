namespace Random_Numbers_Game
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
            this.resetButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkNumberButton = new System.Windows.Forms.Button();
            this.guessDescriptionLabel = new System.Windows.Forms.Label();
            this.playerGuessTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(127, 86);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(95, 23);
            this.resetButton.TabIndex = 28;
            this.resetButton.Text = "Start Over";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkNumberButton
            // 
            this.checkNumberButton.Location = new System.Drawing.Point(26, 86);
            this.checkNumberButton.Name = "checkNumberButton";
            this.checkNumberButton.Size = new System.Drawing.Size(95, 23);
            this.checkNumberButton.TabIndex = 25;
            this.checkNumberButton.Text = "Check number";
            this.checkNumberButton.UseVisualStyleBackColor = true;
            this.checkNumberButton.Click += new System.EventHandler(this.checkNumberButton_Click);
            // 
            // guessDescriptionLabel
            // 
            this.guessDescriptionLabel.AutoSize = true;
            this.guessDescriptionLabel.Location = new System.Drawing.Point(92, 53);
            this.guessDescriptionLabel.Name = "guessDescriptionLabel";
            this.guessDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.guessDescriptionLabel.TabIndex = 23;
            this.guessDescriptionLabel.Text = "Your guess:";
            // 
            // playerGuessTextBox
            // 
            this.playerGuessTextBox.Location = new System.Drawing.Point(184, 50);
            this.playerGuessTextBox.Name = "playerGuessTextBox";
            this.playerGuessTextBox.Size = new System.Drawing.Size(50, 20);
            this.playerGuessTextBox.TabIndex = 21;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(41, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(269, 13);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "Can you guess the random numberbetween 1 and 100?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 133);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkNumberButton);
            this.Controls.Add(this.guessDescriptionLabel);
            this.Controls.Add(this.playerGuessTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Random Number Guessing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button checkNumberButton;
        private System.Windows.Forms.Label guessDescriptionLabel;
        private System.Windows.Forms.TextBox playerGuessTextBox;
        private System.Windows.Forms.Label titleLabel;
    }
}

