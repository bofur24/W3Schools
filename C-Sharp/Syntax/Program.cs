namespace Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("---------");
            Console.WriteLine("C# Syntax");
            Console.WriteLine("Example Explained");
            Console.WriteLine("Line 1: using System means that we can use classes from the System namespace. " +
                "\nLine 2: A blank line. C# ignores white space. However, multiple lines makes the code more readable." +
                "\nLine 3: namespace is used to organize your code, and it is a container for classes and other namespaces. \nLine 4: The curly braces {} marks the beginning and the end of a block of code." +
                "\nLine 5: class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program. " +
                "\nLine 6: Another thing that always appear in a C# program is the Main method. Any code inside its curly brackets {} will be executed. You don't have to understand the keywords before and after Main. you will get to know them bit by bit while reading this tutorial." +
                "\nLine 7: Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text. In our example, it will output \"Hello World!\"");
            Console.WriteLine("If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.");
            Console.WriteLine("Note: Every C# is case-sensitive; \"MyClass\" and \"myclass\" have different meaning.");
            Console.WriteLine("Note: unlike Java, the name of the C# file does not have to match the class name, but they often do (for better organization). When saving the file, save it using a proper name and add\".c\" to the end of the filename. To run the example above on your computer, make sure that C# is properly installed: Go to the Get Started Chaper for how to install C#.The output should be:");
            Console.WriteLine("Hello, World!");
        }
    }
}
