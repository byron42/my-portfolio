using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine_Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // setup random number
        private readonly Random rand = new Random();

        // set index
        private int[] Img_Indexes = new int[3];

        // list for holding the payout values
        List<double> Total_Winnings = new List<double>();

        // list for holding the wagers made
        List<double> Total_Wagers = new List<double>();

        // randomize images
        private int getRandomImageIndex()
        {
            return rand.Next(fruitImageList1.Images.Count);
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            double timesTwo;
            double timesThree;
            double wager = double.Parse(insertedTextBox.Text);

            // add to wager list every click
            Total_Wagers.Add(wager);

            // get images
            var randomIndex = getRandomImageIndex();
            fruitPictureBox1.Image = fruitImageList1.Images[randomIndex];
            Img_Indexes[0] = randomIndex;

            randomIndex = getRandomImageIndex();
            fruitPictureBox2.Image = fruitImageList1.Images[randomIndex];
            Img_Indexes[1] = randomIndex;

            randomIndex = getRandomImageIndex();
            fruitPictureBox3.Image = fruitImageList1.Images[randomIndex];
            Img_Indexes[2] = randomIndex;

            // compare images
            if (Img_Indexes[0] == Img_Indexes[1] && Img_Indexes[1] == Img_Indexes[2])
            {
                // award 3 times bet
                timesThree = wager * 3;

                // add to winnings list
                Total_Winnings.Add(timesThree);

                MessageBox.Show("Congratulations, you won " + timesThree.ToString("c"));
            }

            else
            {
                if (Img_Indexes[0] == Img_Indexes[1] && Img_Indexes[1] != Img_Indexes[2]
                    || Img_Indexes[0] != Img_Indexes[1] && Img_Indexes[0] == Img_Indexes[2]
                    || Img_Indexes[0] != Img_Indexes[1] && Img_Indexes[1] == Img_Indexes[2])
                {
                    // award 2 times bet
                    timesTwo = wager * 2;

                    // add to winnings list
                    Total_Winnings.Add(timesTwo);

                    MessageBox.Show("Congratulations, you won " + timesTwo.ToString("c"));
                }

                else
                {
                    MessageBox.Show("Unfortunately, you won $0.00");
                }
            }

            // reset the index every click.
            Img_Indexes = new int[3];

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // sum of winnings list
            double winnings = Total_Winnings.Sum();

            // sum of wagers list
            double wagersMade = Total_Wagers.Sum();

            MessageBox.Show("- You wagered " + wagersMade.ToString("c") + "\n\n" + "- You won " + winnings.ToString("c"));

            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
