namespace Slot_Machine_Simulation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.insertedAmountLabel = new System.Windows.Forms.Label();
            this.insertedTextBox = new System.Windows.Forms.TextBox();
            this.spinButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fruitImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fruitPictureBox3 = new System.Windows.Forms.PictureBox();
            this.fruitPictureBox2 = new System.Windows.Forms.PictureBox();
            this.fruitPictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // insertedAmountLabel
            // 
            this.insertedAmountLabel.AutoSize = true;
            this.insertedAmountLabel.Location = new System.Drawing.Point(113, 144);
            this.insertedAmountLabel.Name = "insertedAmountLabel";
            this.insertedAmountLabel.Size = new System.Drawing.Size(96, 13);
            this.insertedAmountLabel.TabIndex = 3;
            this.insertedAmountLabel.Text = "Amount Inserted: $";
            // 
            // insertedTextBox
            // 
            this.insertedTextBox.Location = new System.Drawing.Point(215, 141);
            this.insertedTextBox.Name = "insertedTextBox";
            this.insertedTextBox.Size = new System.Drawing.Size(100, 20);
            this.insertedTextBox.TabIndex = 4;
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(116, 179);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(75, 23);
            this.spinButton.TabIndex = 5;
            this.spinButton.Text = "Spin";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(240, 179);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fruitImageList1
            // 
            this.fruitImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fruitImageList1.ImageStream")));
            this.fruitImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.fruitImageList1.Images.SetKeyName(0, "Apple.bmp");
            this.fruitImageList1.Images.SetKeyName(1, "Banana.bmp");
            this.fruitImageList1.Images.SetKeyName(2, "Cherries.bmp");
            this.fruitImageList1.Images.SetKeyName(3, "Grapes.bmp");
            this.fruitImageList1.Images.SetKeyName(4, "Lemon.bmp");
            this.fruitImageList1.Images.SetKeyName(5, "Lime.bmp");
            this.fruitImageList1.Images.SetKeyName(6, "Orange.bmp");
            this.fruitImageList1.Images.SetKeyName(7, "Pear.bmp");
            this.fruitImageList1.Images.SetKeyName(8, "Strawberry.bmp");
            this.fruitImageList1.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // fruitPictureBox3
            // 
            this.fruitPictureBox3.Image = global::Slot_Machine_Simulation.Properties.Resources.Pear;
            this.fruitPictureBox3.Location = new System.Drawing.Point(306, 25);
            this.fruitPictureBox3.Name = "fruitPictureBox3";
            this.fruitPictureBox3.Size = new System.Drawing.Size(100, 100);
            this.fruitPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fruitPictureBox3.TabIndex = 2;
            this.fruitPictureBox3.TabStop = false;
            // 
            // fruitPictureBox2
            // 
            this.fruitPictureBox2.Image = global::Slot_Machine_Simulation.Properties.Resources.Orange;
            this.fruitPictureBox2.Location = new System.Drawing.Point(171, 25);
            this.fruitPictureBox2.Name = "fruitPictureBox2";
            this.fruitPictureBox2.Size = new System.Drawing.Size(100, 100);
            this.fruitPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fruitPictureBox2.TabIndex = 1;
            this.fruitPictureBox2.TabStop = false;
            // 
            // fruitPictureBox1
            // 
            this.fruitPictureBox1.Image = global::Slot_Machine_Simulation.Properties.Resources.Watermelon;
            this.fruitPictureBox1.Location = new System.Drawing.Point(32, 25);
            this.fruitPictureBox1.Name = "fruitPictureBox1";
            this.fruitPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.fruitPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fruitPictureBox1.TabIndex = 0;
            this.fruitPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 223);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.insertedTextBox);
            this.Controls.Add(this.insertedAmountLabel);
            this.Controls.Add(this.fruitPictureBox3);
            this.Controls.Add(this.fruitPictureBox2);
            this.Controls.Add(this.fruitPictureBox1);
            this.Name = "Form1";
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fruitPictureBox1;
        private System.Windows.Forms.PictureBox fruitPictureBox2;
        private System.Windows.Forms.PictureBox fruitPictureBox3;
        private System.Windows.Forms.Label insertedAmountLabel;
        private System.Windows.Forms.TextBox insertedTextBox;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ImageList fruitImageList1;
    }
}

