/*
 * Subclass for setting up the Commission empType
 */
package part_time_emp;

public class Commission extends Name implements PartTimeEmployee{
    private double totalSales;
    private double commRate;
    private double paycheck;
    private double weeklyPay;
    
    //for interface
    private double partTime;
    
    public Commission (String firstName, String lastName, double sales, double rate, double check){    
        
        // inherited from Name
        super(firstName, lastName);
        
        // added here for Comm subclass
        totalSales = sales;
        commRate = rate;
        paycheck = check;
    } 
    
    // calculate pay method
    public double calcPay (double sales, double rate){
        double percent = rate/100;
        
        if (sales > 0){
            return paycheck = (sales * percent);
        }
        else
            return paycheck = PT_C;
    }
    
   public String payPrint(){
       if (totalSales > 0 ){
            return String.format("COMMISSION (Full Time):   %s made $%.2f this week!%n", super.empName(), paycheck );
       }
       else
            return String.format("COMMISSION (Part Time):   %s made $%.2f this week!%n", super.empName(), paycheck );
   }
   
   @Override
   public String toString(){
       return payPrint();
   }
    
    public void PartTimeEmployee(){
        this.partTime = PT_C;
    }
}