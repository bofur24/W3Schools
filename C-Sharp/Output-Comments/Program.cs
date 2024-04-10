namespace Output_Comments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Output");
            Console.WriteLine("To output values or print text in C#, you can use the WriteLine() method:");            
            Console.WriteLine("Hello, World!");
            Console.WriteLine("----------");

            Console.WriteLine("You can add as many WriteLine() methods as you want. Note that it will add a new line for each method");
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learing C#");
            Console.WriteLine("It is awesome!");
            Console.WriteLine("----------");

            Console.WriteLine("You can output numbers, and perform mathematical calculations:");            
            Console.WriteLine(3 + 3);
            Console.WriteLine("----------");

            Console.WriteLine("The Write Method");
            Console.WriteLine("There is also a Write() method, which is similar to WriteLine().");
            Console.WriteLine("The only difference is that it does not insert a new line at the end of the output:");
            Console.Write("Hello World! ");
            Console.Write("I will print on the same line.");
            Console.WriteLine("Note that we add an extra space when needed (after \"Hello World!\" in the example above), for better readability.");
            Console.WriteLine("----------");

            Console.WriteLine("C# Comments");
            Console.WriteLine("Comments can be used to explain C# code, and to make it more readable. It can also be used to prevent execution when testing alternative code.");
            Console.WriteLine("Single-line Comments");
            Console.WriteLine("Single-line comments start with two forward slashes (//). " +
                "\nAny text between // and the end of the line is ignored by C# (will not be executed). " +
                "\nThis example uses a single-line comment before a line of code:");
            // This is a comment
            Console.WriteLine("Hello World!");
            Console.WriteLine("----------");

            Console.WriteLine("This example uses a single-line comment at the end of a line of code:");
            Console.WriteLine("Hello World!"); // This is a comment
            Console.WriteLine("----------");

            Console.WriteLine("C# Multi-line Comments");
            Console.WriteLine("Multi-line comments start with /* and ends with */. " +
                "\nAny text between /* and */ will be ignored by C#." +
                "\nThis example uses a multi-line comment (a comment block) to explain the code:");
            /* The code below will print the words Hello World
             * to the screen, and it is amazing
             */
            Console.WriteLine("Hello World!");
            Console.WriteLine("----------");



        }
    }
}
