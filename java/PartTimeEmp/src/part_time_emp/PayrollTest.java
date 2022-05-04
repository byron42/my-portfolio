/*
 * This program asks for input for various worker type, allows a user to 
 * enter the correspoinding input to calculate a weekly paycheck for each type,
 * then displays the formatted information for each type.
 */
package part_time_emp;

//import java.util.Scanner;

public class PayrollTest {

    public static void main(String[] args) {
 
        int weeksInYear = 50; 
        double paycheck = 0;
        int numChecks;
 
        // HOURLY
        Hourly hft_Check = new Hourly ("Bill", "Jones", 40, 20, paycheck);
        Hourly hpt_Check = new Hourly ("Sal", "Smith", 0, 0, paycheck);
        hft_Check.calcPay(40,20);
        hpt_Check.calcPay(0,0);
        
        
        // SALARY
        Salary sft_Check = new Salary ("Joe", "John", 30000, paycheck);
        Salary spt_Check = new Salary ("Ned", "Flanders", 0, paycheck);
        sft_Check.calcPay(30000,weeksInYear);
        spt_Check.calcPay(15000,weeksInYear);
        
        
        // COMMISSION
        Commission cft_Check = new Commission ("Kyle", "Burns", 10000, 5, paycheck);
        Commission cpt_Check = new Commission ("Hal", "Collins", 0, 0, paycheck);
        cft_Check.calcPay(10000,5);
        cpt_Check.calcPay(0,0);
        
        //spacer
        System.out.printf("%n%n%n"); 
        
        // Abstract class array and polymorhisim
        Name[] employee = new Name [6];
        employee[0] = hft_Check;
        employee[1] = hpt_Check;
        employee[2] = sft_Check;
        employee[3] = spt_Check;
        employee[4] = cft_Check;
        employee[5] = cpt_Check;
        for (Name empName : employee){
            System.out.print(empName);
            if (empName instanceof Hourly && empName == hpt_Check){
                Hourly myHourly = (Hourly)empName;
                System.out.print("\n            (Wow, I need a raise!!!!) \n\n");
            }
        }
       
        System.out.println(); 
 
        numChecks = cft_Check.getCounter();
        System.out.println("\nThe total number of checks made was " + numChecks);
    }
}