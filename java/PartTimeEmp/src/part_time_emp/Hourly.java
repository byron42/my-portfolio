/*
 * Subclass for setting up the Hourly empType
 */
package part_time_emp;

public class Hourly extends Name implements PartTimeEmployee{
    private int workHours;
    private double payRate;
    private double paycheck;
    
    //for interface
    private double partTime;
    
    public Hourly(String firstName, String lastName, int hours, double rate, double check){    
        
        // inherited from Name
        super(firstName, lastName);
        
        // added here for Hourly subclass
        workHours = hours;
        payRate = rate;
        paycheck = check;
    } 
    
    // calculate pay method
    public double calcPay (int hours, double pay){
       
        if (hours > 20){
            return paycheck = (hours * pay);
        }
        else
            return paycheck = PT_H;
    }
    
   public String payPrint(){
       if (workHours > 20){
           return String.format("HOURLY (Full Time):      %s made $%.2f this week!%n", super.empName(), paycheck );
       }
       else 
           return String.format("HOURLY (Part Time):      %s made $%.2f this week!%n", super.empName(), paycheck );
    }
   
    @Override
   public String toString(){
       return payPrint();
   }
   
   public void PartTimeEmployee(){
       this.partTime = PT_H;
    }
}