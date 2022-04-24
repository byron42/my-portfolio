using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Counter_and_Average_Letters_per_Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countWordsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string words;              // var for input
                int count = 0;             // counter
                int total = 0;             // Accumulator
                double average;            // var for average

                // get the user input 
                words = inputTextBox.Text.ToString();

                // get white space count
                int white_space = words.Count(Char.IsWhiteSpace);

                if (total < words.Length)
                { 

                    // get the words as tokens
                    string[] tokens = words.Split(null);

                    // set the accumulator to 0
                    total = 0;

                    // calculate the total of the word tokens
                    foreach (string str in tokens)
                    {
                        count++;
                    }

                    // calculate the average of these
                    average = ((double)inputTextBox.Text.Length - white_space) / tokens.Length;

                    // Show the results
                    MessageBox.Show("- The number of words is " + count + "\n\n"
                    + "- The average number of letters per word is " + average.ToString("n1"));

                }
            }
            catch (Exception ex)
            {
                // display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
