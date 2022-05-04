/*
 * Subclass for setting up the Salary empType
 */
package part_time_emp;

public class Salary extends Name implements PartTimeEmployee{
    
    private double totalSalary;
    private double paycheck;
    private double weeklyPay;
    
    //for interface
    private double partTime;
    
    public Salary (String firstName, String lastName, double salary, double check){    
        
        // inherited from Name
        super(firstName, lastName);
        
        // added here for Salary subclass
        totalSalary = salary;
        paycheck = check;
    } 
    
    // calculate pay method
    public double calcPay (double salary, int weeksInYear){
        weeksInYear = 50;
        
        if (salary > 15000){
             return paycheck = (salary / weeksInYear);
        }
        else 
            return paycheck = PT_S;
    }
   public String payPrint(){
       if (totalSalary > 15000){
            return String.format("SALARY (Full Time):      %s made $%.2f this week!%n", super.empName(), paycheck );
       }
       else
           return String.format("SALARY (Part Time):      %s made $%.2f this week!%n%n", super.empName(), paycheck );
   }
    
    @Override
   public String toString(){
       return payPrint();
   }
   
    public void PartTimeEmployee(){
        this.partTime = PT_S;
    }
}