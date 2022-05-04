/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


package filecreator;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.nio.file.DirectoryStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.Formatter;
import java.util.FormatterClosedException;
import java.util.NoSuchElementException;

public class FileCreator {

    public static void main(String[] args){
    
      Scanner sc = new Scanner(System.in);
      
      
      // GET USER PATH
      System.out.println("Enter file name to create:");
      String userPath = sc.nextLine();
    
      
      try (Formatter output = new Formatter(userPath)){
        
        System.out.println("Enter student ID, First Name, Last Name -- q to quit");
       
        Scanner input = new Scanner(System.in);
        
        // commas or returns acceptable for input
        input.useDelimiter("[,\n]");
        
        // output to file
        output.format("%-7s%-15s%-20s%n%s%n", "ID:", "First Name:", "Last Name:", "---------------------------------------");
      
        while(input.hasNextInt()){
            try{
                output.format("%-7d%-15s%-20s%n", input.nextInt(), input.next(), input.next());
            }
           catch (NoSuchElementException e){
                System.err.println("Invalid input, try again");
                input.nextLine();
            }
            System.out.println("Enter student ID, First Name, Last Name -- q to quit");
        }
        output.format("%s%n",  "---------------------------------------");
        input.close();
      }
      catch(SecurityException | FileNotFoundException | FormatterClosedException e){
          e.printStackTrace();
      }
      
      // PRINT TO CONSOLE
      try(Scanner prettyPrint = new Scanner(Paths.get(userPath))){
           
          while(prettyPrint.hasNext()){
              
            String line = prettyPrint.nextLine();
            System.out.println(line);
          }
          
            // FILE NAME
            Path path = Paths.get(userPath); 
            Path fileName = path.getFileName(); 
            System.out.println("FileName: " + fileName.toString());

            // FILE SIZE
            File file = new File(userPath);
            double bytes = file.length();
            System.out.println("The size of this file is : " + bytes + " bytes.\n");
      }
      catch(IOException | NoSuchElementException | IllegalStateException e){
          e.printStackTrace();
      }
    }
}