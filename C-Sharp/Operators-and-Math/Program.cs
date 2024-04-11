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










        }
    }
}
