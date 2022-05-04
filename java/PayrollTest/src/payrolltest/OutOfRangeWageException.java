/*
 * new exception for wages out of range
 */
package payrolltest;

public class OutOfRangeWageException extends Exception {

    public OutOfRangeWageException() {
         super("Rate is out of range (must be 15-25)!");
    }
}
