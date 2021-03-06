import java.util.Scanner;

public class LeibnizPi {
	// This program will find the value of pi with the amount of iterations a user wants.
    // By Ethan Lawrence 11/13/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// Defining variables
		Scanner userInput = new Scanner(System.in);
		double pi = 0, denom = 1;
		
		// Showing what the program is for
		System.out.println("This program will find the value of pi with the amount of iterations a user wants.");
		
		// Getting the number of iterations as per the user's request
		System.out.print("Please enter the amount of times you want to iterate Pi (Whole number): ");
		int iterations = userInput.nextInt();
		
        // This will calculate Pi based on the number of iterations given
	    for (int i = 0; i < iterations; i++) {
	    	if (i % 2 == 0) 
	    		pi += 1 / denom;
	    	else 
	    		pi -= 1 / denom;
	    	denom += 2;
	    	}
	    pi *= 4;
	    
	    

        
        if (iterations < 0)
        	// Positive number check for the user input
        	System.out.println("Please restart the program and enter a valid number of iterations."); 
        else 
        	// Displays the final value of pi and shows how many iterations were requested
        	System.out.println("The value of Pi over " + iterations + " iterations is: " + pi);
        	
	}

}
