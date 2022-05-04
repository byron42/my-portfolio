/* Brian Efflandt
 * CS 121-002 Fall 2019
 * Date Created 9.4.19
 * The purpose of this program is to allow a user to enter a positive number of 
 * miles and gallons of gas used to calculate MPG for a/multiple trips, and then 
 * to give an average MPG for all trips logged, but with an option to log off by 
 * using a -1 at the first prompt.
 */

package milespergallon;

import java.util.Scanner;

public class MilesPerGallon {

    public static void main(String[] args) {
        
        int miles = 1;
        int gallons;
        int trips = 0;
        double mpg; 
        double totalMPG = 0;
        
        Scanner sc = new Scanner(System.in);
       
        // get a positive number for miles driven
        System.out.println("Please enter a positive number for the number of miles driven for a trip, or enter -1 to exit");
        miles = sc.nextInt();
        System.out.println();
        
        // verify the miles entered are a positive
        while (miles < -1){
            System.out.println("I asked nicely for a positive number...");
            System.out.println();
            System.out.println("Please enter a positive number for the number of miles driven for a trip, or enter -1 to exit");
            miles = sc.nextInt();
            System.out.println();
        }
        
        // Loop until told to stop
        while (miles > -1) {
            
            // get a positive number for gallons
            System.out.println("Please enter the number of gallons of gas used for the trip...");
            gallons = sc.nextInt();
            System.out.println();
            
            // verify the gallons entered are a positive
            while (gallons < 0){
                System.out.println("I asked nicely for a positive number...");
                System.out.println();
                System.out.println("Please enter the number of gallons of gas used for the trip...");
                gallons = sc.nextInt();
                System.out.println();
            }
            
            // Calculate MPG
            mpg = (double)miles/gallons;
          
            // Print MPG
            System.out.printf(" --> The MPG for this trip was %.2f%n\n\n", mpg);
            
            // Calculate running total for average MPG
            trips = trips + 1;
            totalMPG = (totalMPG + mpg) / trips;
            
            if (miles > -1) {  

                // Repeat the loop
                System.out.println("Please enter the number of miles driven for a trip, or enter -1 to exit");
                miles = sc.nextInt();
                System.out.println();
                
                // verify the number entered is positive
                while (miles < -1){
                    System.out.println("I asked nicely for a positive number...");
                    System.out.println();
                    System.out.println("Please enter a positive number for the number of miles driven for a trip, or enter -1 to exit");
                    miles = sc.nextInt();
                    System.out.println();
                }
            }
            // Exit if -1 is entered by the user
            else 
                miles = -1;
        } 
        // Print running total
        System.out.printf(" --> The average MPG for all trips was %.2f%n\n", totalMPG);
    }
}
