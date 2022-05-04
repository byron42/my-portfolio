/*
 * Subclass for setting up the Commission empType
 */
package payrolltest;

// Commission:  User cannot sell more than 500 items

public class Commission extends Name{
    
    // colors for strings
    String GREEN = "\u001B[32m";
    String BLACK = "\u001B[30m";
    
    private static int numItems;
    private static double totalSales;
    private static double commRate; 
    private double paycheck;
    private static double weeklyPay;
    
    public Commission (String firstName, String lastName, double sales, double rate, int items, double check) throws OverItemAmountException {    
        
        // inherited from Name
        super(firstName, lastName);
        
        // added here for Comm subclass
        numItems = items;
        totalSales = sales;
        commRate = rate;
        paycheck = check;
        
        if (items < 1 || items > 500){
             throw(new OverItemAmountException());
        }
    } 
    
    // calculate pay method
    public double calcPay (double sales, double rate){
        double percent = rate/100;
        return paycheck = (sales * percent);
    }
    
    @Override public void payPrint(){
      System.out.printf(GREEN + "%s made $%.2f this week!%n%n" + BLACK, super.toString(), paycheck );
   }
}