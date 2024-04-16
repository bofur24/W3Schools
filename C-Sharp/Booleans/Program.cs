namespace Booleans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Booleans");
            Console.WriteLine("Very often, in programming, you will need a data type that can only have one of two values, like:");
            Console.WriteLine("YES / NO\n" +
                "ON / OFF\n" +
                "TRUE / FALSE");
            Console.WriteLine("For this, C# has a bool data type, which can take the values true or false.");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Boolean Values");
            Console.WriteLine("A boolean type is declared with the bool keyword and can only take the values true or false:");
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine($"bool isCsharpFun = {isCSharpFun}");
            Console.WriteLine($"bool isFishTasty = {isFishTasty}");
            Console.WriteLine("However, it is more common to return boolean values from boolean expressions, for conditional testing");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Boolean Expression");
            Console.WriteLine("A boolean expression returns a boolean value: True or False, by comparing values/variables.");
            Console.WriteLine("This is useful to build logic, and find answers.");
            Console.WriteLine("For example, you can use a comparison operator, such as the greater than (>) operator to find out if an expression (or variable) is ture:");
            int x = 10;
            int y = 9;
            Console.WriteLine($"int x = 10; int y = 9; x > y = {x > y}"); // Returns, True, becasue 10 is higher than 9
            Console.WriteLine("Or even easier:");
            Console.WriteLine();
            Console.WriteLine($"10 > 9 = {10 > 9}");
            Console.WriteLine();
            Console.WriteLine("In the examples below, we use the equal to (==) operator to evaluate an expression:");
            Console.WriteLine($"int x = 10; x == 10 = {x == 10}");
            Console.WriteLine($"10 == 15 = {10 == 15}");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Real Life Example");
            Console.WriteLine("Let's think of a \"real life example\" where we need to find out if a person is old enough to vote.");
            Console.WriteLine("In the example below, we use the >= comparison operator to find out if the age (25) is greater than OR equal to the voting age limit, which is set to 18:");
            int myAge = 25;
            int votingAge = 18;
            Console.WriteLine($"int myAge = 25; int votingAge = 18; myAge >= votingAge = {myAge >= votingAge}");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Cool, right? An even better approach (since we are on a roll now), would be to wrap the code above in an if...else statement, so we can perform different actions depending on the result:");
            Console.WriteLine();
            Console.WriteLine("EXAMPLE");
            Console.WriteLine("Output \"Old enough to vote!\" if myAge is greater than or equal to 18. Otherwise output \"Not old enough to vote.\"");
            if (myAge >= votingAge)
            {
                Console.WriteLine($"{myAge >= votingAge} Old enough to vote!");
            }
            else
            {
                Console.WriteLine($"{votingAge >= myAge} Not old enough to vote.");
            }
        }
    }
}
