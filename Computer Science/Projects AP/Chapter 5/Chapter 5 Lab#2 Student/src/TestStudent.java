import java.text.ParseException;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

public class TestStudent {
	public static String studentName, studentBirthday, studentSSN, studentMotherMaidenName, studentHomeAddress, studentEmail, 
	    studentPhoneNumber;
	public static double studentGPA;
	public static int studentDressSize, studentGradYear;
	
	// Accessors
	public String GetStudentName() {
		return studentName;
	}
	public String GetStudentBirthday() {
		return studentBirthday;
	}
	public String GetStudentSSN() {
		return studentSSN;
	}
	public String GetStudentMotherMaidenName() {
		return studentMotherMaidenName;
	}
	public String GetStudentHomeAddress() {
		return studentHomeAddress;
	}
	public String GetStudentEmail() {
		return studentEmail;
	}
	public String GetStudentPhoneNumber() {
		return studentPhoneNumber;
	}
	public double GetStudentGPA() {
	    return studentGPA;
	}
	public int GetStudentDressSize() {
	    return studentDressSize;
	}
	public int GetStudentGradYear() {
	    return studentGradYear;
	}
	public TestStudent(){
		studentName = "John Deer";
		studentBirthday = "07/19/2001";
		studentSSN = "111-11-1111";
		studentMotherMaidenName = "Deer";
		studentHomeAddress = "123 Bob Builder's Street PA 18966";
		studentEmail = "elawrence152@gmail.com";
		studentPhoneNumber = "215-730-4920";
		studentGPA = 4.0;
		studentDressSize = 40;
		studentGradYear = 2019;
	}
	
	public TestStudent(String SomeStudentName){
		TestStudent.studentName = SomeStudentName;
	}
	
	public TestStudent(String SomeName, String SomeBirthday, String SomeSSN, String SomeMaidenName, String SomeHomeAddress,
			String SomeEmail, String SomePhoneNumber, double SomeGPA, int SomeDressSize, int SomeGradYear){
		TestStudent.studentName = SomeName;
		TestStudent.studentBirthday = SomeBirthday;
		TestStudent.studentSSN = SomeSSN;
		TestStudent.studentMotherMaidenName = SomeMaidenName;
		TestStudent.studentHomeAddress = SomeHomeAddress;
		TestStudent.studentEmail = SomeEmail;
		TestStudent.studentPhoneNumber = SomePhoneNumber;
		TestStudent.studentGPA = SomeGPA;
		TestStudent.studentDressSize = SomeDressSize;
		TestStudent.studentGradYear = SomeGradYear;
	}
	
	public LocalDate BirthdayNumber() throws ParseException {
		DateTimeFormatter formatter1 = DateTimeFormatter.ofPattern("MM/dd/yyyy");
	    LocalDate parsedDate = LocalDate.parse(studentBirthday, formatter1);
	    return parsedDate;
        
	}
}
