/*
 * Abstract Superclass for setting up the employee name
 */
package payrolltest;

public abstract class Name {
    private String fName;
    private String lName;
    private static int counter=0;
  
    public Name(String firstName, String lastName){
        fName = firstName;
        lName = lastName;
        
        //checkCount = counter;
        counter++;
    }
    
    public int getCounter(){
        return counter;
    }

    public String toString(){
       return String.format("%s %s ", fName,lName);
    }
    
    public abstract void payPrint();
}