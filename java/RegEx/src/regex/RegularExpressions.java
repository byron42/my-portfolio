/*
 * This program allows a user to enter some information, is verified/validated
 * using regex, and is output with a variety of StringBuilder and String methods
 */
package regex;

import java.util.Scanner;

public class RegularExpressions {

    public static void main(String[] args) {
       
        Scanner sc = new Scanner(System.in);
        
        // First Name
        System.out.println("Please enter your first name:");
        String fName = sc.next();
        while (!fName.matches("^[A-z]+$")) {
            System.err.println("Invalid entry - name must be only letters!");
            System.out.println("Please enter your first name:");
            fName = sc.next();
        }
        
        // Last Name
        System.out.println("Please enter your last name:");
        String lName = sc.next();
        while (!lName.matches("^[A-z]+$")) {
            System.err.println("Invalid entry - name must be only letters!");
            System.out.println("Please enter your last name:");
            lName = sc.next();
        }
        
        // Phone
        System.out.println("Please enter your telephone number:");
        String tPhone = sc.next();
        while (!tPhone.matches("^\\d{10}+$")) {
            System.err.println("Invalid entry - phone number must contain 10 numbers!");
            System.out.println("Please enter your telephone number:");
            tPhone = sc.next();
        }
        
        // User name
        System.out.println("Please choose a user name:");
        String uName = sc.next();
        while (!uName.matches("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}+$")) {
            System.err.println("Invalid entry - must contain 1 uppercase letter,"
                                + " 1 number, and be at least 8 characters long!");
            System.out.println("Please choose a user name:");
            uName = sc.next();
        }
        
        // Password
        System.out.println("Please choose a password:");
        String pWord = sc.next();
        while (!pWord.matches("^[A-Z](?=.*[A-Za-z])(?=.*\\d)(?=.*_)[A-Za-z\\d_]{10,}+$")) {
            System.err.println("Invalid entry - must start with uppercase letter,"
                                + " have 1 number, 1 underscore and be at least 10 characters long!");
            System.out.println("Please choose a user name:");
            pWord = sc.next();
        }
        
        System.out.println("=========================================================");

        StringBuilder str1 = new StringBuilder(tPhone) .insert(0,"(")  .insert(4,")") .insert(8,"-");
        StringBuilder str2 = new StringBuilder(uName);
        StringBuilder str3 = new StringBuilder(pWord);
       
        // String
        System.out.println("Your full name is: " + fName.concat(" " + lName)); 
        
        // StringBuilder
        System.out.println("Your phone number is: " + str1.toString());


        // StringBuilder
        System.out.println("Your user name is : " + str2.toString() + " \nYour password is:  " + str3.toString()); 

        System.out.println("=========================================================");
    }   
}