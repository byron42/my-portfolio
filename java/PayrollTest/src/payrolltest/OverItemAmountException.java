/*
 * new exception for too many sales items
 */
package payrolltest;

public class OverItemAmountException extends Exception {

    public OverItemAmountException() {
        super("Item amount is over max limit (must be 500 or less)!");
    }
}
