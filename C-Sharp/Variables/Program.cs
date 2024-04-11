namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Variables");
            Console.WriteLine("Variables are containers for storing data values");
            Console.WriteLine("In c#, there are diferent tyeps of variables (defined with differnet keywords), for examples:" +
                "\n int - stores integers (whole nubmers), without decimals, such as 123 or -123" +
                "\n double - stores floating point numbers, with decimals, such as 19.99 or -19.99" +
                "\n char - stores single characters, such as \'a\' or \'B\'. Char values are surrounded by single quotes" +
                "\n string - stores text, such as \"Hello World\". String values are surrounded by double quotes" +
                "\n bool - stores values with two states: ture or false");
            Console.WriteLine("---------");
            Console.WriteLine();
            Console.WriteLine("Declaring ( Creating) Variables");
            Console.WriteLine("To create a variable, you must specify the type and assign it a value:");
            Console.WriteLine();
            Console.WriteLine("A variable that should store text");
            string name = "John";
            Console.WriteLine("String variable name = " + name);
            Console.WriteLine();
            Console.WriteLine("A variable that should store a number");
            int myNum = 15;
            Console.WriteLine("int variable myNum = " + myNum);
            Console.WriteLine();
            Console.WriteLine("Declare a variable without assigning the value, and asign the value later:");
            int myNewNum;
            myNewNum = 15;
            Console.WriteLine("int varaible myNewNum = " + myNewNum);
            Console.WriteLine();
            Console.WriteLine("Note taht if you assign a new value to an existing variable, it will overwrite the previous value:");
            myNewNum = 20; // myNewNum is now 20
            Console.WriteLine("int varaiable myNewNum set as new = " + myNewNum);
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Other Types");
            Console.WriteLine("A demonstration of how to declare variables of other types:");
            int myNums = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("C# Constants");
            Console.WriteLine("If you don't want others (or yourself) to overwrite existing values, you can add the const keyword in front of the variable type.");
            Console.WriteLine("This will declare the variable as \"constant\", wich means unchangeable and read-only");
            const int myNewNumber = 15;
            //myNewNumber = 20;
            Console.WriteLine("const int myNewNumber = " + myNewNumber);
            Console.WriteLine("Trying to change myNewNumber will result in an error.");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Display Variables");
            Console.WriteLine("The WriteLine() method is often used to display variable values to the console window.");
            Console.WriteLine("To combine both text and a variable, use the + character:");
            Console.WriteLine();
            Console.WriteLine("Hello + variable name = Hello " + name);
            Console.WriteLine("You can also use the + character to add a variable to another variable:");
            Console.WriteLine();
            string firstName = "John ";
            string lastName = "Doe";
            Console.WriteLine("variable firstName + variable lastName = " + firstName + lastName);
            Console.WriteLine();
            Console.WriteLine("For numeric values, the + character works as a mathematical operator (notice that we use int (integer) variables here):");
            int x = 5;
            int y = 6;
            Console.Write("int x = 5 + int y = 6 = ");
            Console.WriteLine(x + y);
            Console.WriteLine("From the example above, you can expect:" +
                "\n x stores the value 5" +
                "\n y stores the value 6" +
                "\n Then we us the WriteLine() method to display the value of x + y, which is 11");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("C# Multiple Variables");
            Console.WriteLine("Declare Many Variables");
            Console.WriteLine("To declare more than one variable of the same type, use a comma-separated list:");
            Console.WriteLine();
            int s = 5, t = 6, u = 7;
            Console.Write("int s = 5, t = 6, u = 7 s + t + u = ");
            Console.WriteLine(s + t + u);
            Console.WriteLine("You can assign the same value to multiple variables in one line:");
            s = t = u = 10;
            Console.Write("s = t = u = 10; s + t + u = ");
            Console.WriteLine(s + t + u);
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("C# Identifiers");
            Console.WriteLine("All C# variables must be identified with unique names");
            Console.WriteLine("These unique names are called identifiers.");
            Console.WriteLine("Identifiers can be short names (like x and y) or more descriptive names (age, sum, totalVolume.");
            Console.WriteLine("Note: It is recommended to use descriptive names in order to create understandable and maintainable code:");
            Console.WriteLine();
            // Good 
            int minutesPerHour = 60;
            // Ok, but not so easy to understand what m actually is
            int m = 60;
            Console.WriteLine("int minutesPerHour = 60 descriptive name " + minutesPerHour);
            Console.WriteLine("int m = 60 not so descriptive " + m);
            Console.WriteLine("The general rules for naming variables are: " +
                "\n Names can contain letters, digits and the underscore character(_) " +
                "\n Names must begin with a letter or underscore " +
                "\n Names should start with a lowercase letter, and cannot contain whitespace " +
                "\n Names are case-sensitive (\"myVar\" and \"myvar\" are different variables)" +
                "\n Reserved words (like C# keywords, such as int or double) cannot be used as names");
            Console.WriteLine();
            Console.WriteLine("---------");













        }
    }
}
