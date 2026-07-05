using System; // Allows us to use basic system functions like Console.WriteLine

// Create a class named MathOperations
class MathOperations
{
    // Create a void method that takes two integers as parameters
    public void DoMath(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer (multiply by 2)
        int result = firstNumber * 2;

        // Display the result of the math operation
        Console.WriteLine("The result of the math operation on the first number is: " + result);

        // Display the second integer to the screen
        Console.WriteLine("The second number is: " + secondNumber);
    }
}

// Main program class
class Program
{
    // Entry point of the console application
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class
        MathOperations mathObj = new MathOperations();

        // Call the method by passing in two numbers normally
        mathObj.DoMath(10, 20);

        // Call the method again, specifying the parameters by name
        mathObj.DoMath(firstNumber: 15, secondNumber: 30);

        // Pause the console so the user can see the output before closing
        Console.ReadLine();
    }
}
