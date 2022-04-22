namespace Rock__Paper__Scissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rockPictureBox = new System.Windows.Forms.PictureBox();
            this.paperPictureBox = new System.Windows.Forms.PictureBox();
            this.scissorPictureBox = new System.Windows.Forms.PictureBox();
            this.playGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.playerScissorChoice = new System.Windows.Forms.PictureBox();
            this.playerPaperChoice = new System.Windows.Forms.PictureBox();
            this.playerRockChoice = new System.Windows.Forms.PictureBox();
            this.cpuScissorChoice = new System.Windows.Forms.PictureBox();
            this.cpuPaperChoice = new System.Windows.Forms.PictureBox();
            this.cpuRockChoice = new System.Windows.Forms.PictureBox();
            this.versusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerScissorChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPaperChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRockChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuScissorChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPaperChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuRockChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // rockPictureBox
            // 
            this.rockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rockPictureBox.Image")));
            this.rockPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("rockPictureBox.InitialImage")));
            this.rockPictureBox.Location = new System.Drawing.Point(26, 47);
            this.rockPictureBox.Name = "rockPictureBox";
            this.rockPictureBox.Size = new System.Drawing.Size(100, 100);
            this.rockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rockPictureBox.TabIndex = 0;
            this.rockPictureBox.TabStop = false;
            this.rockPictureBox.Click += new System.EventHandler(this.rockPictureBox_Click);
            // 
            // paperPictureBox
            // 
            this.paperPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paperPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("paperPictureBox.Image")));
            this.paperPictureBox.Location = new System.Drawing.Point(152, 47);
            this.paperPictureBox.MinimumSize = new System.Drawing.Size(30, 30);
            this.paperPictureBox.Name = "paperPictureBox";
            this.paperPictureBox.Size = new System.Drawing.Size(100, 100);
            this.paperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paperPictureBox.TabIndex = 1;
            this.paperPictureBox.TabStop = false;
            this.paperPictureBox.Click += new System.EventHandler(this.paperPictureBox_Click);
            // 
            // scissorPictureBox
            // 
            this.scissorPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("scissorPictureBox.Image")));
            this.scissorPictureBox.Location = new System.Drawing.Point(278, 47);
            this.scissorPictureBox.Name = "scissorPictureBox";
            this.scissorPictureBox.Size = new System.Drawing.Size(100, 100);
            this.scissorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scissorPictureBox.TabIndex = 2;
            this.scissorPictureBox.TabStop = false;
            this.scissorPictureBox.Click += new System.EventHandler(this.scissorPictureBox_Click);
            // 
            // playGameButton
            // 
            this.playGameButton.Location = new System.Drawing.Point(99, 235);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(75, 23);
            this.playGameButton.TabIndex = 3;
            this.playGameButton.Text = "Try Again";
            this.playGameButton.UseVisualStyleBackColor = true;
            this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(213, 235);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(26, 175);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(352, 27);
            this.messageLabel.TabIndex = 6;
            this.messageLabel.Text = "Choose your weapon wisely";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerScissorChoice
            // 
            this.playerScissorChoice.Image = ((System.Drawing.Image)(resources.GetObject("playerScissorChoice.Image")));
            this.playerScissorChoice.Location = new System.Drawing.Point(26, 47);
            this.playerScissorChoice.Name = "playerScissorChoice";
            this.playerScissorChoice.Size = new System.Drawing.Size(100, 100);
            this.playerScissorChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerScissorChoice.TabIndex = 9;
            this.playerScissorChoice.TabStop = false;
            this.playerScissorChoice.Visible = false;
            // 
            // playerPaperChoice
            // 
            this.playerPaperChoice.Image = ((System.Drawing.Image)(resources.GetObject("playerPaperChoice.Image")));
            this.playerPaperChoice.Location = new System.Drawing.Point(26, 47);
            this.playerPaperChoice.Name = "playerPaperChoice";
            this.playerPaperChoice.Size = new System.Drawing.Size(100, 100);
            this.playerPaperChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPaperChoice.TabIndex = 8;
            this.playerPaperChoice.TabStop = false;
            this.playerPaperChoice.Visible = false;
            // 
            // playerRockChoice
            // 
            this.playerRockChoice.Image = ((System.Drawing.Image)(resources.GetObject("playerRockChoice.Image")));
            this.playerRockChoice.InitialImage = ((System.Drawing.Image)(resources.GetObject("playerRockChoice.InitialImage")));
            this.playerRockChoice.Location = new System.Drawing.Point(26, 47);
            this.playerRockChoice.Name = "playerRockChoice";
            this.playerRockChoice.Size = new System.Drawing.Size(100, 100);
            this.playerRockChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerRockChoice.TabIndex = 7;
            this.playerRockChoice.TabStop = false;
            this.playerRockChoice.Visible = false;
            // 
            // cpuScissorChoice
            // 
            this.cpuScissorChoice.Image = ((System.Drawing.Image)(resources.GetObject("cpuScissorChoice.Image")));
            this.cpuScissorChoice.Location = new System.Drawing.Point(278, 47);
            this.cpuScissorChoice.Name = "cpuScissorChoice";
            this.cpuScissorChoice.Size = new System.Drawing.Size(100, 100);
            this.cpuScissorChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpuScissorChoice.TabIndex = 12;
            this.cpuScissorChoice.TabStop = false;
            this.cpuScissorChoice.Visible = false;
            // 
            // cpuPaperChoice
            // 
            this.cpuPaperChoice.Image = ((System.Drawing.Image)(resources.GetObject("cpuPaperChoice.Image")));
            this.cpuPaperChoice.Location = new System.Drawing.Point(278, 47);
            this.cpuPaperChoice.Name = "cpuPaperChoice";
            this.cpuPaperChoice.Size = new System.Drawing.Size(100, 100);
            this.cpuPaperChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpuPaperChoice.TabIndex = 11;
            this.cpuPaperChoice.TabStop = false;
            this.cpuPaperChoice.Visible = false;
            // 
            // cpuRockChoice
            // 
            this.cpuRockChoice.Image = ((System.Drawing.Image)(resources.GetObject("cpuRockChoice.Image")));
            this.cpuRockChoice.InitialImage = ((System.Drawing.Image)(resources.GetObject("cpuRockChoice.InitialImage")));
            this.cpuRockChoice.Location = new System.Drawing.Point(278, 47);
            this.cpuRockChoice.Name = "cpuRockChoice";
            this.cpuRockChoice.Size = new System.Drawing.Size(100, 100);
            this.cpuRockChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpuRockChoice.TabIndex = 10;
            this.cpuRockChoice.TabStop = false;
            this.cpuRockChoice.Visible = false;
            // 
            // versusLabel
            // 
            this.versusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLabel.Location = new System.Drawing.Point(174, 79);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(53, 33);
            this.versusLabel.TabIndex = 15;
            this.versusLabel.Text = "VS";
            this.versusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versusLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 282);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.cpuScissorChoice);
            this.Controls.Add(this.cpuPaperChoice);
            this.Controls.Add(this.cpuRockChoice);
            this.Controls.Add(this.playerScissorChoice);
            this.Controls.Add(this.playerPaperChoice);
            this.Controls.Add(this.playerRockChoice);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playGameButton);
            this.Controls.Add(this.scissorPictureBox);
            this.Controls.Add(this.paperPictureBox);
            this.Controls.Add(this.rockPictureBox);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerScissorChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPaperChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRockChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuScissorChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPaperChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuRockChoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rockPictureBox;
        private System.Windows.Forms.PictureBox paperPictureBox;
        private System.Windows.Forms.PictureBox scissorPictureBox;
        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.PictureBox playerScissorChoice;
        private System.Windows.Forms.PictureBox playerPaperChoice;
        private System.Windows.Forms.PictureBox playerRockChoice;
        private System.Windows.Forms.PictureBox cpuScissorChoice;
        private System.Windows.Forms.PictureBox cpuPaperChoice;
        private System.Windows.Forms.PictureBox cpuRockChoice;
        private System.Windows.Forms.Label versusLabel;
    }
}

