/*
 * new exception for salary out of range
 */
package payrolltest;

public class OutOfRangeSalaryException extends Exception {

    public OutOfRangeSalaryException() {
        super("Amount is out of range (must be 35000-65000)!");
    }
}
