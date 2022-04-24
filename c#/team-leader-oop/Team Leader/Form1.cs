using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Leader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetEmployeeData method accepts a Car object as an
        // argument. It assigns the data entered by the
        // user to the object's properties.
        private void GetEmployeeData(TeamLeader emp)
        {
            // Temporary variables to hold emp number, shift, pay rate, and bonus
            int number;
            int shift;
            decimal rate;
            decimal bonus;

            // annual training variables
            int requiredHours, earnedHours;
            
            // Get the emp's name.
            emp.Name = nameTextBox.Text;

            // Get the emp's number.
            if (int.TryParse(numberTextBox.Text, out number))
            {
                emp.Number = number;

                // Get the emp's shift.
                if (int.TryParse(shiftTextBox.Text, out shift))
                {
                    emp.Shift = shift;

                    // Get the hourly rate.
                    if (decimal.TryParse(rateTextBox.Text, out rate))
                    {
                        emp.Rate = rate;

                        // get bonus amount
                        if (decimal.TryParse(bonusTextBox.Text, out bonus))
                        {
                            emp.Bonus = bonus;

                            // get required annual training hours
                            if (int.TryParse(requiredHoursTextBox.Text, out requiredHours))
                            {
                                emp.Required_Hours = requiredHours;

                                // get earned annual training hours
                                if (int.TryParse(earnedHoursTextBox.Text, out earnedHours))
                                {
                                    emp.Earned_Hours = earnedHours;
                                }
                                else
                                {
                                    // Display an error message.
                                    MessageBox.Show("Invalid number for earned hours");
                                }
                            }
                            else
                            {
                                // Display an error message.
                                MessageBox.Show("Invalid number for required hours");
                            }
                        }
                        else
                        {
                            // Display an error message.
                            MessageBox.Show("Invalid number for bonus amount");
                        }
                    }
                    else
                    {
                        // Display an error message.
                        MessageBox.Show("Invalid number for hourly rate");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid number for shift number");
                }
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid employee number");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            // Create a worker object.
            TeamLeader myLeader = new TeamLeader();

            // Get the worker data.
            GetEmployeeData(myLeader);

            // Display the worker data.
            nameLabel.Text = myLeader.Name;
            numberLabel.Text = myLeader.Number.ToString();
            shiftLabel.Text = myLeader.Shift.ToString();
            rateLabel.Text = myLeader.Rate.ToString("c");
            bonusLabel.Text = myLeader.Bonus.ToString("c");
            requiredHoursLabel.Text = myLeader.Required_Hours.ToString();
            earnedHoursLabel.Text = myLeader.Earned_Hours.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}