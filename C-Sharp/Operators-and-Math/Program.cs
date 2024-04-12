namespace Operators_and_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Operators");
            Console.WriteLine("Operators are used to perform operations on variables and values.");
            Console.WriteLine("In the example below, we use the + operator to add together two values:");
            int x = 100 + 50;
            Console.WriteLine("int x = 100 + 50 " + x);
            Console.WriteLine();
            Console.WriteLine("Although the + operator is often used to add together two values, like in the example above, it can also be used to add together a variable and a value, or a variable and antoher variable:");
            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)
            Console.WriteLine("int sum1 = 100 + 50 " + sum1);
            Console.WriteLine("int sum2 = sum1 + 250 " + sum2);
            Console.WriteLine("int sum3 = sum2 + sum2 " + sum3);
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Arithmetic Operators");
            Console.WriteLine("Arithmetic operators are used to perform common mathematical operations:");
            Console.WriteLine("Operator\tName\t\tDescription\t\t\t\tExample\n" +
                "+\t\tAddition\tAdds together two values\t\tx + y\n" +
                "-\t\tSubtraction\tSubtracts one value from another\tx - y\n" +
                "*\t\tMultiplication\tMultiplies two values\t\t\tx * y\n" +
                "/\t\tDivision\tDivides one value by another\t\tx / y\n" +
                "%\t\tModulus\tReturns the division remainder\t\t\tx % y\n" +
                "++\t\tIncrement\tIncreases the value of a variable by 1\tx++\n" +
                "--\t\tDecrement\tDecreases the value of a variable by 1\tx--");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("C# Asignment Operators");
            Console.WriteLine("Assignment operators are used to assign values to variables.");
            Console.WriteLine("In the example below, we use the assignment operator (=) to assign the value 10 to a variable called a:");
            int a = 10;
            Console.WriteLine("int a = 10 " + a);
            Console.WriteLine();
            Console.WriteLine("The addition assignment operator (+=) adds a value to the variable:");
            a += 5;
            Console.WriteLine("a += 5 " + a);
            Console.WriteLine();
            Console.WriteLine("Operator\t\tExample\t\tSame As\n" +
                "=\t\t\tx = 5\t\tx = 5\n" +
                "+=\t\t\tx += 3\t\tx = x + 3\n" +
                "-=\t\t\tx -= 3\t\tx = x - 3\n" +
                "*=\t\t\tx *= 3\t\tx = x * 3\n" +
                "/=\t\t\tx /= 3\t\tx = x / 3\n" +
                "%=\t\t\tx %= 3\t\tx = x % 3\n" +
                "&=\t\t\tx &= 3\t\tx = x & 3\n" +
                "|=\t\t\tx |= 3\t\tx = x | 3\n" +
                "^=\t\t\tx ^= 3\t\tx = x ^ 3\n" +
                ">>=\t\t\tx >>= 3\t\tx = x >> 3\n" +
                "<<=\t\t\tx <<= 3\t\tx = x <<= 3");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("C# Comparison Operators");
            Console.WriteLine("Comparison operators are used to compare two values (or variables). This is important in programming, becasue it helps us to find answers and make decisions.");
            Console.WriteLine("The return value of a comparison is either True or False. These values are know as Boolean values, and you will learn more about them in the Booleans and If...Else chapter.");
            Console.WriteLine("In the following example, we use the greater than operator (>) to find out if 5 is greater than 3:");
            int b = 5;
            int c = 3;
            bool d = b > c;
            Console.WriteLine("int b = 5; c = 3 b > c " + d);
            Console.WriteLine("A list of all comparison operators:");
            Console.WriteLine("Operator\t\tName\t\t\tExample\n" +
                "==\t\tEqual to\t\t\tx == y\n" +
                "!=\t\tNot equal\t\t\tx != y\n" +
                ">\t\tGreater than\t\t\tx > y\n" +
                "<\t\tLess than\t\t\tx < y\n" +
                ">=\t\tGreater than or equal to\tx >= y\n" +
                "<=\t\tLess than or equal to\t\tx <= y");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("C# Logical Operators");
            Console.WriteLine("As with comparison operators, you can also test for True or False values with logical operators.");
            Console.WriteLine("Logical operators are used to determine the logic between variables or values:");
            Console.WriteLine("Operator\t\tName\t\tDescription\t\t\t\t\t\t\tExample\n" +
                "&&\t\tLogical and\t\tReturns True if both statements are ture\t\t\tx < 5 && x < 10\n" +
                "||\t\tLogical or\t\tReturns True if one of the statements is ture\t\t\tx < 5 || x < 4\n" +
                "!\t\tLogical not\t\tReverse the result, returns False if the result is ture\t\t!(x < 5 && x < 10)");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("C# Math");
            Console.WriteLine("The C# Math class has many methods that allows you to perform mathematical tasks on numbers");
            Console.WriteLine("Math.Max(x,y)");
            Console.WriteLine("The Math.Max(x,y) method can be used to find the highest value of x and y:");
            Console.WriteLine("Math.Max(5,10) = " + Math.Max(5, 10));
            Console.WriteLine();
            Console.WriteLine("Math.Min(x,y)");
            Console.WriteLine("The Math.Min(x,y) method can be used to find the lowest value of of x and y:");
            Console.WriteLine("Math.Min(5,10) = " + Math.Min(5,10));
            Console.WriteLine();
            Console.WriteLine("Math.Sqrt(x)");
            Console.WriteLine("The Math.Sqrt(x) method returns the square root of x:");
            Console.WriteLine("Math.Sqrt(64) = " + Math.Sqrt(64));
            Console.WriteLine();
            Console.WriteLine("Math.Abs(x)");
            Console.WriteLine("The Math.Abs(x) method returns the absolute (positive) value of x:");
            Console.WriteLine("Math.Abs(-4.7) = " + Math.Abs(-4.7));
            Console.WriteLine();
            Console.WriteLine("Math.Round()");
            Console.WriteLine("Math.Round() rounds a number to the nearest whole number:");
            Console.WriteLine("Math.Round(9.99) = " + Math.Round(9.99));








        }
    }
}
