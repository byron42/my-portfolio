/*
 * Subclass for setting up the Salary empType
 */
package payrolltest;

// Salaried:  Yearly salary must be between $35,000 and $65,000.

public class Salary extends Name{
    
    // colors for strings
    String GREEN = "\u001B[32m";
    
    private static double totalSalary;
    private double paycheck;
    private static double weeklyPay;
    
    public Salary (String firstName, String lastName, double salary, double check) throws OutOfRangeSalaryException {    
        
        // inherited from Name
        super(firstName, lastName);
        
        // added here for Salary subclass
        totalSalary = salary;
        paycheck = check;
        
        if (salary < 35000 || salary > 65000){
             throw(new OutOfRangeSalaryException());
        }
    } 
    
    // calculate pay method
    public double calcPay (double salary, int weekksInYear){
        weekksInYear = 50;
        return paycheck = (salary / weekksInYear);
    }
    @Override public void payPrint(){
      System.out.printf(GREEN + "%s made $%.2f this week!%n%n", super.toString(), paycheck );
   }
}