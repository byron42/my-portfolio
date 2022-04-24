using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Numbers_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int generatedNumber = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // create a Random object
            Random rand = new Random();

            // get a random integer in the range of 1 - 100
            generatedNumber = rand.Next(100) + 1;
        }

        private void checkNumberButton_Click(object sender, EventArgs e)
        {
            try
            {
                // variable for guess
                int guessNumber;

                // get info from user
                guessNumber = int.Parse(playerGuessTextBox.Text);

                if (guessNumber > generatedNumber)
                {
                    MessageBox.Show("Too high, try again.");
                }
                else
                {
                    if (guessNumber < generatedNumber)
                    {
                        MessageBox.Show("Too low, try again.");
                    }
                    else
                    {
                        if (guessNumber == generatedNumber)
                        {
                            MessageBox.Show("Congratulations, you guessed the correct number!");
                        }
                    }
                } 
            }
            catch (Exception ex)
            {
                // display the default error message
                MessageBox.Show(ex.Message);
            }
        }
        
        private void resetButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            generatedNumber = rand.Next(100) + 1;
            playerGuessTextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
