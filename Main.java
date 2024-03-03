public class Main
{
    // Creating a test case in main
    public static void main(String[] args)
    {
        Factorial newFactorial1 = new Factorial();
        Factorial newFactorial2 = new Factorial();

        // Use long data type -- used to handle larger factorial numbers up to 25
        long returner1 = newFactorial1.factorialRun(25);
        long returner2 = newFactorial2.factorialRun(0);

        // Print the results
        System.out.println(returner1);
        System.out.println(returner2);
    }
}