/*
 * Subclass for setting up the Hourly empType
 */
package payrolltest;


// Hourly: Hourly wage is between (and includes) $15.00/hr. and $25.00/hr.

public class Hourly extends Name{
    
    // colors for strings
    String GREEN = "\u001B[32m";
    
    private int workHours;
    private double payRate;
    private double paycheck;
    
    public Hourly(String firstName, String lastName, int hours, double rate, double check) throws OutOfRangeWageException {    
        
        // inherited from Name
        super(firstName, lastName);
        
        // added here for Hourly subclass
        workHours = hours;
        payRate = rate;
        paycheck = check;
        
        if (rate < 15 || rate > 25){
             throw(new OutOfRangeWageException());
        }
    } 
    
    // calculate pay method
    public double calcPay (int hours, double pay){
        return paycheck = (hours * pay);
    }
    
   @Override public void payPrint(){
      System.out.printf(GREEN + "%s made $%.2f this week!%n%n", super.toString(), paycheck );
   }
}