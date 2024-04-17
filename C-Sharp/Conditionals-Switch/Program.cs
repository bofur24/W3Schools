namespace Conditionals_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Conditions an If Statements");
            Console.WriteLine("C# supports the usual logical conditions from mathematics:\n" +
                "Less than: a < b\n" +
                "Less thand or equal to: a <= b\n" +
                "Greater than: a > b\n" +
                "Greater than or equal to: a >= b\n" +
                "Equal to: a == b\n" +
                "Not Equal to: a != b");
            Console.WriteLine("You can use these conditions to perform different actions for different decisions.");
            Console.WriteLine("C# has the following conditional statements:\n" +
                "Use if to specify a block of code to be executed, if a specified condition is true.\n" +
                "Use else to specify a block of code to be executed, if the same condition is false.\n" +
                "Use else if to specify a new condition to test, if the first condition is false.\n" +
                "Us switch to specify many alternative blocks of code to be executed.");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("The if Statement");
            Console.WriteLine("Use the if statement to specify a block of C# code to be executed if a condition is True.");
            Console.WriteLine("In the example below, we test two values to find out if 20 is greater than 18. If the condition is True, print some text");
            Console.WriteLine();
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            Console.WriteLine("We can also test variables:");
            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            Console.WriteLine();
            Console.WriteLine("Example explained");
            Console.WriteLine("In the example above we use two variables, x and y, to test " +
                "whether x is greater than y (using the > operator). As x is 20, and y is 18, " +
                "and we know that 20 is greater than 18, we print to the screen that" +
                "\"x is greater than y\"");

        }
    }
}
