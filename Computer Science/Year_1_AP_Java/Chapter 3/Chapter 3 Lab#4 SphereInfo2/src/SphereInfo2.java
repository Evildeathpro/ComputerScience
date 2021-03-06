import java.util.Scanner;

public class SphereInfo2 {
	// This program will make a calculation for the information of a sphere
    // By Ethan Lawrence 10/15/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner userInput = new Scanner(System.in);
		System.out.println("This program will find the stats of a sphere.");
		System.out.print("Please enter the unit of length: ");
		String units = userInput.nextLine();
        System.out.print("Please enter the radius of the sphere (double): ");
        double radius = userInput.nextDouble(); 
        double diameter = (double)((int)(radius * 2.000 * 1000)) / 1000, 
        		circumference = (double)((int)(radius * 3.141 * 2.000 * 1000)) / 1000, 
        		area = (double)((int)(radius * 3.141 * radius * 4.000 *1000)) /1000, 
        		volume = (double)((int)(4.000/3.000 * 3.141 * radius * radius * radius * 1000))/1000;
        System.out.println("The diameter is: " + diameter + " " + units + "\n" +
        		"The circumference is: " + circumference + " " + units + "\n" +
        		"The surface area is: " + area + " " + units + " squared" + "\n" +
        		"The volume is: " + volume + " " + units + " cubed" + "\n");
	}

}
