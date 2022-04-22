using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock__Paper__Scissors
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int rndnumber = 0;

        private void Random_Number()
        {
            Random rand = new Random();
            rndnumber = rand.Next(3) + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random_Number();
        }

        private void PlayerChoiceRock()
        {
           
            // Hide the "original images"
            rockPictureBox.Visible = false;
            paperPictureBox.Visible = false;
            scissorPictureBox.Visible = false;

            // Display the "player choice" image
            playerRockChoice.Visible = true;

            // Display the other labels
            versusLabel.Visible = true;
        }

        private void PlayerChoicePaper()
        {

            // Hide the "original images"
            rockPictureBox.Visible = false;
            paperPictureBox.Visible = false;
            scissorPictureBox.Visible = false;

            // Display the "player choice" image
            playerPaperChoice.Visible = true;

            // Display the other labels
            versusLabel.Visible = true;
        }

        private void PlayerChoiceScissor()
        {

            // Hide the "original images" image
            rockPictureBox.Visible = false;
            paperPictureBox.Visible = false;
            scissorPictureBox.Visible = false;

            // Display the "player choice" image
            playerScissorChoice.Visible = true;

            // Display the other labels
            versusLabel.Visible = true;
        }

        private void CPU_Choice()
        {
            // Match random number to cpu images
            if (rndnumber == 1)
            {
                cpuRockChoice.Visible = true;
            }
            else
            {
                if (rndnumber == 2)
                {
                    cpuPaperChoice.Visible = true;
                }
                else
                {
                    if (rndnumber == 3)
                    {
                        cpuScissorChoice.Visible = true;
                    }
                }
            }
        }

        private void rockPictureBox_Click(object sender, EventArgs e)
        {
            PlayerChoiceRock();
            CPU_Choice();

            // both rocks
            if (rndnumber == 1)
            {
                messageLabel.Text = "Tie";
            }
            else
            {
                // rock vs paper
                if (rndnumber == 2)
                {
                    messageLabel.ForeColor = System.Drawing.Color.Red;
                    messageLabel.Text = "LOSE - Paper covers rock";
                }
                else
                {
                    // rock vs scissors
                    messageLabel.ForeColor = System.Drawing.Color.Green;
                    messageLabel.Text = "WIN - Rock smashes scissors";
                }
            }
        }

        private void paperPictureBox_Click(object sender, EventArgs e)
        {
            PlayerChoicePaper();
            CPU_Choice();

            if (rndnumber == 1)
            {
                messageLabel.ForeColor = System.Drawing.Color.Green;
                messageLabel.Text = "WIN - Paper covers rock";
            }
            else
            {
                if (rndnumber == 2)
                {
                    messageLabel.Text = "Tie";
                }
                else
                {
                    messageLabel.ForeColor = System.Drawing.Color.Red;
                    messageLabel.Text = "LOSE - Scissors cuts paper";
                }
            }

        }

        private void scissorPictureBox_Click(object sender, EventArgs e)
        {
            PlayerChoiceScissor();
            CPU_Choice();

            if (rndnumber == 1)
            {
                messageLabel.ForeColor = System.Drawing.Color.Red;
                messageLabel.Text = "LOSE - Rock smashes scissors";
            }
            else
            {
                if (rndnumber == 2)
                {
                    messageLabel.ForeColor = System.Drawing.Color.Green;
                    messageLabel.Text = " WIN - Scissors cuts paper";
                }
                else
                {
                    messageLabel.Text = "Tie";
                }
            }
        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            rndnumber = rand.Next(3) + 1;

            // Reset options
            rockPictureBox.Visible = true;
            paperPictureBox.Visible = true;
            scissorPictureBox.Visible = true;

            // Reset Choice
            playerRockChoice.Visible = false;
            playerPaperChoice.Visible = false;
            playerScissorChoice.Visible = false;

            // Reset CPU image
            cpuRockChoice.Visible = false;
            cpuPaperChoice.Visible = false;
            cpuScissorChoice.Visible = false;

            // Reset labels
            messageLabel.Text = "Choose your weapon wisely";
            versusLabel.Visible = false;
            messageLabel.ForeColor = System.Drawing.Color.Black;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

