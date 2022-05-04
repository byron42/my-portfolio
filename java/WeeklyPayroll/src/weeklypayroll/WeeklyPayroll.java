/* Brian Efflandt
 * CS 121-002 Fall 2019
 * Date Created 10.28.19
 * The purpose of this assignment is to calculate a weekly paycheck based on the
 * employee type, the details of their job, and to offer the user a way to exit 
 * while using the JOptionPane for i/o (by passing values from employee 
 * methods to the main method).
 */
package weeklypayroll;

import javax.swing.JOptionPane;

public class WeeklyPayroll {
    
    // constants
    private static String empType;
    private static String firstName;
    private static String lastName;
    private static String error;
    private static String message;
    private static double totalPay = 0;
    
    // salaried
    private static int salary;
    private static double bonusPercent;
    private static double annualPay;
    private static double weeklyPay;
    private static double weeksInYear = 50;
 
    // hourly
    private static int hours;
    private static double rate;
    private static double normalPay = 0;
    private static double overtimePay = 0;
    private static double overtimeRate = 1.5;
    
    // commissioned
    private static int numItems;
    private static double itemCost;
    private static double basePay = 200;
    private static double commRate = 0;

    

    public static void main(String[] args) { 
       
        int salariedCount = 0;
        int hourlyCount = 0;
        int commissionCount = 0;
         
            do{
                // get an employee type for position
                empType = JOptionPane.showInputDialog( "Please enter a number for your type of employment: \n\nSalaried - 1       Hourly - 2      Commission - 3      Exit - 4");
            
                
                //make sure it's in the right range
                while (Integer.parseInt(empType) < 1 || Integer.parseInt(empType) > 4 ) {
                    error = String.format("You must enter 1-4 to continue!");
                    JOptionPane.showMessageDialog(null, error);

                    // ask for the empType again
                    empType = JOptionPane.showInputDialog( "Please enter a number for your type of employment: \n\nSalaried - 1       Hourly - 2      Commission - 3      Exit - 4");
                }
                 
                
                // calling salaried method
                if (Integer.parseInt(empType) == 1){
                   
                   // get emp name
                   firstName = JOptionPane.showInputDialog( "Please enter your first name");
                   lastName = JOptionPane.showInputDialog( "Please enter your last name"); 
                    
                   salaried(salary, bonusPercent, annualPay, weeklyPay, salariedCount);
                   
                   // count the number of checks
                   salariedCount++;
                }
                
                
                // calling hourly method
                if (Integer.parseInt(empType) == 2){
                    
                   // get emp name
                   firstName = JOptionPane.showInputDialog( "Please enter your first name");
                   lastName = JOptionPane.showInputDialog( "Please enter your last name"); 
                    
                   hourly(hours, rate, normalPay, overtimePay, hourlyCount);
                   
                   // count the number of checks
                   hourlyCount++;
                }
                
                // calling commissioned method
                if (Integer.parseInt(empType) == 3){
                    
                   // get emp name
                   firstName = JOptionPane.showInputDialog( "Please enter your first name");
                   lastName = JOptionPane.showInputDialog( "Please enter your last name"); 
                    
                   commission(numItems, itemCost, basePay, commRate, commissionCount);
                   
                    // count the number of checks
                   commissionCount++;
                }
               
                
        } while(Integer.parseInt(empType) < 4);
         
        // print out the total number of checks from each employee category
        message = String.format("salaried checks = %d\n\nhourly checks = %d\n\ncommissioned checks = %d\n",salariedCount,hourlyCount,commissionCount);
        JOptionPane.showMessageDialog(null, message);
              
    }
    
    
    
    // salaried method
    public static double salaried(int salary, double bounsPercent, double annualPay, double weeklyPay, int salariedCount){
     
        // get salary
        salary = Integer.parseInt(JOptionPane.showInputDialog("Please enter your yearly salary amount (eg. $40,000 = 40000):"));

            //make sure it's in the right range
            while (salary < 35000 || salary > 65000){
                error = String.format(firstName + " " + lastName +  ", The salary range must be between 35000 and 65000");
                JOptionPane.showMessageDialog(null, error);

                // ask for the salary again
                salary = Integer.parseInt(JOptionPane.showInputDialog("Please enter your yearly salary amount (eg. $40,000 = 40000):"));
            }

        // get bonus percent
        bonusPercent =  Double.parseDouble(JOptionPane.showInputDialog("Please enter last year's annual profit bonus percentage (eg. 5% = .05):"));

        // calculate yearly pay with bonus
        annualPay = (salary + (salary*bonusPercent));

        // calculate weekly pay with bonus
        weeklyPay = (salary + (salary*bonusPercent)) / weeksInYear;

        // create output message
        message = String.format(firstName + " " + lastName + ", your annual pay (with bonus) is $%.2f, your weekly paycheck (with bonus) is $%.2f\n",annualPay,weeklyPay);
        JOptionPane.showMessageDialog(null, message);

        return salariedCount++;
    }
    
    // hourly method
    public static double hourly(int hours, double rate, double normalPay, double overtimePay, int hourlyCount){
      
        // get hourly rate
        rate =  Double.parseDouble(JOptionPane.showInputDialog("Please enter your hourly pay rate (eg. $15/hr = 15):"));

            //make sure it's in the right range
            while (rate < 15 || rate > 25){
                error = String.format(firstName + " " + lastName +  ", Your hourly rate must be between 15 and 25.");
                JOptionPane.showMessageDialog(null, error);

                // ask for the rate again
                rate = Integer.parseInt(JOptionPane.showInputDialog("Please enter your hourly pay rate (eg. $15/hr = 15):"));
            }

        // get hours
        hours = Integer.parseInt(JOptionPane.showInputDialog("Please enter the amount of hours worked:"));

            while (hours < 1){
                error = String.format(firstName + " " + lastName +  ", You have to work at least 1 hour.");
                JOptionPane.showMessageDialog(null, error);

                // ask for the hours again
                hours = Integer.parseInt(JOptionPane.showInputDialog("Please enter the amount of hours worked:"));
            }

        if (hours <= 40)
            normalPay = hours*rate;

        else if (hours > 40)
        {
            normalPay = 40 * rate;
            overtimePay = (hours - 40) * rate * overtimeRate;
        }

        // calculate total pay
        totalPay = normalPay + overtimePay;

        // create output message
        message = String.format(firstName + " " + lastName + ", your regular pay is $%.2f, your overtime pay is $%.2f, your total check is $%.2f\n",normalPay,overtimePay,totalPay);
        JOptionPane.showMessageDialog(null, message);
    
        
        return hourlyCount = 1;
    }
    
    // hourly method
    public static int commission(int numItems, double itemCost, double basePay, double commRate, int commissionCount){
      
        // get amount of items sold
        numItems = Integer.parseInt(JOptionPane.showInputDialog("How many items did you sell this week?"));

            while (numItems < 1 || numItems > 500){
                error = String.format(firstName + " " + lastName + ", Number of items sold must be between 1 and 500!");
                JOptionPane.showMessageDialog(null, error);

                // ask for the amount of items again
                numItems = Integer.parseInt(JOptionPane.showInputDialog("How many items did you sell this week?"));
            }

        // get cost per item
        itemCost = Double.parseDouble(JOptionPane.showInputDialog("What was the cost per item?"));

        // calculate the commission
        commRate = ((double)(numItems * itemCost)) * .10;

        // calculate the total pay
        totalPay = basePay + commRate;

        // create output message
        message = String.format(firstName + " " + lastName + ", you sold %d items, you made $%.2f in commision, and your total check is $%.2f\n",numItems,commRate,totalPay);

        JOptionPane.showMessageDialog(null, message);
    
        return commissionCount = 1;
    }
    
    
}
