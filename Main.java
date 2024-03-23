public class Main
{
    // Creating a test case in main
    public static void main(String[] args) 
    {

        // Use long data type -- used to handle larger factorial numbers up to 25
        long returner1 = Factorial.factorialRun(25);
        long returner2 = Factorial.factorialRun(0);

        // Print the results
        System.out.println(returner1);
        System.out.println(returner2);
    }
}
