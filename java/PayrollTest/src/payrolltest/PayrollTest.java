/*
 * This program asks for input for various worker type, allows a user to 
 * enter the correspoinding input to calculate a weekly paycheck for each type,
 * then displays the formatted information for each type.
 */
package payrolltest;

import java.util.Random;
import java.util.Scanner;

public class PayrollTest {

    public static void main(String[] args) {
        
        // colors for strings
        String RED = "\u001B[31m";
        String BLACK = "\u001B[30m";
        String BLUE = "\u001B[34m";
       
        String firstName;
        String lastName;
        int weeksInYear = 50; 
        int empType = 0;
        double paycheck = 0;
        int numChecks = 0;
        int errCount = 0;
        
        //exception vars
        double rate = 0;
        double salary = 0;
        int items = 0;
        
        Scanner sc = new Scanner(System.in);
        
        // HOURLY
        System.out.println("HOURLY WORKER:");
        System.out.println("=================================");
        System.out.println("What is the worker's first name?");
        firstName = sc.next();
        System.out.println("What is the worker's last name?");
        lastName = sc.next();
        System.out.println("Please enter how many hours they worked:");
        int hours = sc.nextInt();
        
        // HOURLY EXCEPTION
        do{   
            try{
               System.out.println("Please enter the worker's hourly rate (eg $15/hr = 15):");
               rate = sc.nextDouble();
               System.out.println();

               // create object from subclass
               Hourly h_Check = new Hourly (firstName, lastName, hours, rate, paycheck);
               h_Check.calcPay(hours,rate);
               h_Check.payPrint();
           }
            catch(OutOfRangeWageException orw){
                System.err.println(orw);
                errCount++;
            }
            finally{
                
                if(rate < 15 || rate > 25){
                    System.out.print("");
                }
                else{ 
                    String[] teams = {"Duke","Illinois","Kentucky","Wisconsin","Florida","Northwestern","LSU","Alabama"};
                    Random r = new Random();
                    int randomNumber = r.nextInt(teams.length);
                    System.out.println("------------------------------------------------------------");
                    System.out.println(BLUE + "Who will win the NCAA tourney...will it be " + teams[randomNumber] + "?" + BLACK);
                    System.out.println("------------------------------------------------------------\n");
                }            
            }
        }
        while (rate < 15 || rate > 25);

        // SALARY
        System.out.println();
        System.out.println("SALARY WORKER:");
        System.out.println("=================================");
        System.out.println("What is the worker's first name?");
        firstName = sc.next();
        System.out.println("What is the worker's last name?");
        lastName = sc.next();
       
        // SALARY EXCEPTION
        do{
            try{
                System.out.println("What was the workers annual salary (eg $25,000 = 25000)?");
                salary = sc.nextDouble();
                System.out.println();
                
                // create object from subclass
                Salary s_Check = new Salary (firstName, lastName, salary, paycheck);
                s_Check.calcPay(salary,weeksInYear);
                s_Check.payPrint();
            }
            catch(OutOfRangeSalaryException ors){
                System.err.println(ors);
                errCount++;
            }
            finally{
                
                if(salary < 35000 || salary > 65000){
                    System.out.print("");
                }
                else{ 
                    String[] teams = {"Duke","Illinois","Kentucky","Wisconsin","Florida","Northwestern","LSU","Alabama"};
                    Random r = new Random();
                    int randomNumber = r.nextInt(teams.length);
                    System.out.println("------------------------------------------------------------");
                    System.out.println(BLUE + "Or Will it be " + teams[randomNumber] + "???" + BLACK);
                    System.out.println("------------------------------------------------------------\n");
                }            
            }
        }
        while(salary < 35000 || salary > 65000);

        // COMMISSION
        System.out.println();
        System.out.println("COMMISSION WORKER:");
        System.out.println("=================================");
        System.out.println("What is the worker's first name?");
        firstName = sc.next();
        System.out.println("What is the worker's last name?");
        lastName = sc.next();
        System.out.println("What was the workers total sales this week? (eg $1000 = 1000)?");
        double sales = sc.nextDouble();
        System.out.println("What was their commission rate? (eg 5% = 5)");
        double cRate = sc.nextDouble();
        
        // COMMISSION EXCEPTION
        do{
            try{
                System.out.println("How many items did they sell?");
                items = sc.nextInt();
                System.out.println();

                // create object from subclass
                Commission c_Check = new Commission (firstName, lastName, sales, cRate, items, paycheck);
                c_Check.calcPay(sales,cRate);
                c_Check.payPrint();
                
                // get check counter
                numChecks = c_Check.getCounter();
            }
            catch(OverItemAmountException oie){
                System.err.println(oie);
                errCount++;
            }
            finally{
                
                if(items < 1 || items > 500){
                    System.out.print("");
                }
                else{ 
                    System.out.println("------------------------------------------------------------");
                    System.out.println(BLUE + "I predict covid-19 will win the NCAA tourney!!!");
                    System.out.println("------------------------------------------------------------");
                }            
            }
        }
        while (items < 1 || items > 500);
        
        numChecks = numChecks - errCount;
        System.out.printf("%n"); 
        System.out.println("\nThe total number of checks made was " + numChecks);
    
    }
}