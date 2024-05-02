using classObjects;

namespace Enums_Files_and_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Enums");
            Console.WriteLine("An enum is a special \"class\" that represents a group of constants (unchangeable/read-only variables).");
            Console.WriteLine("To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma:");
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
            Console.WriteLine();
            Console.WriteLine("Enum is short for\"enumerations\", which means \"specifically listed\".");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Enum inside a Class");
            Program1.Level1 myVar1 = Program1.Level1.Medium;
            Console.WriteLine(myVar1);
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Enum Values");
            Console.WriteLine("By default, the first item of an enum has the value 0. The second has the value 1, and so on.");
            Console.WriteLine("To get the integer value from an item, you must explicitly convert the item to an int:");
            int myNum = (int)Months.April;
            Console.WriteLine($"April is month number {myNum}");
            Console.WriteLine();
            Console.WriteLine("You can also assign your own enum values, and the next items will update their numbers accordingly:");
            int myNum1 = (int)Months1.November;
            Console.WriteLine($"November is now set to number {myNum1}");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Enum in a Switch Statement");
            Console.WriteLine("Enums are often used in switch statements to check for corresponding values:");
            switch(myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;
                case Level.High:
                    Console.WriteLine("High Level");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Wy and When to Use Enums?");
            Console.WriteLine("Use enums when you have values that you know aren't going to change, like month days, days, colors, deck or cards, etc.");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Working With Files");
            Console.WriteLine("The File class from the System.IO namespace, allows us to work with files:");
            Console.WriteLine("The File class has many usefull methods for creating and getting information about files. For Example:");
            Console.WriteLine("Method\t\tDescription\n" +
                "AppendText()\t\tAppends text at the end of an existing file\n" +
                "Copy()\t\t\tCopies a file\n" +
                "Create()\t\tCreates or overwrites a file\n" +
                "Delete()\t\tDeletes a file" +
                "Exists()\t\tTests whether the file exists\n" +
                "ReadAllText()\t\tReads the contents of a file\n" +
                "Replace()\t\tReplaces the contents of a file with the contents of another file\n" +
                "WriteAllText()\t\tCreates a new file and writes the contents to it. If the file already exists, it will be overwritten.");
            Console.WriteLine();
            Console.WriteLine("Write To a File and Read It");
            Console.WriteLine("In the following example, we use the WriteAllText() method to create a file named \"filename.txt\" and write some content to it. Then we use the ReadAllText() method to read the contents of the file:");

            string writeText = "Hello World!";                      // Create a text string
            File.WriteAllText("filename.txt", writeText);           // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");     // Read the contents of the file
            Console.WriteLine(readText);                            // Output the content
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Exceptions");
            Console.WriteLine("When executing C# code, different errors can occur: coding errors made by the programmer, errors due to wrong input, or other unforeseeable things.");
            Console.WriteLine("When an error occurs, C# will normally stop and generate an error message. The technical term for this is: C# will throw an exception (throw and error)");
            Console.WriteLine();
            Console.WriteLine("try and catch");
            Console.WriteLine("The try statement allows you to define a block of code to be tested for errors while it is being executed.");
            Console.WriteLine("The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.");
            Console.WriteLine("The try and catch keywords come in pairs:");
            Console.WriteLine("If an error occurs, we can us try...catch to catch the error and execute some code to handle it.");
            Console.WriteLine("In the following example, we use the variable inside the catch block (e) together with the built-in Message property, which outputs a message that describes the exception:");
            Console.WriteLine();
            Console.WriteLine(" try\r\n{\r\nint[] myNumbers = { 1, 2, 3 };\r\nConsole.WriteLine(myNumbers[10]);\r\n}\r\ncatch (Exception e) \r\n{\r\nConsole.WriteLine(e.Message);\r\n}");
            
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("You can also output your own error message:");
            Console.WriteLine();
            Console.WriteLine("try\r\n{\r\nint[] myNumbers = { 1, 2, 3 };\r\nConsole.WriteLine(myNumbers[10]);\r\n}\r\ncatch (Exception e)\r\n{\r\nConsole.WriteLine(\"Something went wrong\");\r\n}");

            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Finally");
            Console.WriteLine("The finally statement lets you execute code, after try...catch, regardless of the result:");
            Console.WriteLine("try\r\n{\r\nint[] myNumbers = { 1, 2, 3 };\r\nConsole.WriteLine(myNumbers[10]);\r\n}\r\ncatch (Exception e)\r\n{\r\nConsole.WriteLine(\"Something went wrong\");\r\n}\r\nfinally\r\n{\r\nConsole.WriteLine(\"The 'try catch' is finished.\");\r\n}");
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
            Console.WriteLine();
            Console.WriteLine("The throw keyword");
            Console.WriteLine("The throw statement allows you to create a custom error.");
            Console.WriteLine("The throw statement is used together with an exception class. There are many exception classes available in C#: ArithmeticException, FileNotFoundException, IndexOutOfRangeException, TimeOutException, etc:");
            Console.WriteLine("static void checkAge(int age)\r\n{\r\nif (age < 18)\r\n{\r\nthrow new ArithmeticException(\"Access denied - You must be at least 18 years old.\");\r\n}\r\nelse\r\n{\r\nConsole.WriteLine(\"Access granted - You are old enough!\");\r\n}\r\n}\r\ncheckAge(15);");
            static void checkAge(int age)
            {
                if (age < 18)
                {
                    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
                }
                else
                {
                    Console.WriteLine("Access granted - You are old enough!");
                }
            }
            Console.WriteLine("When age is below 18 the System.ArithmeticException: 'Access denied - You must be at least 18 years old. is ran");
            checkAge(20);
            Console.WriteLine("If age is over 18 you would not get an exception");
        }
    }
}

namespace classObjects
{
    enum Level
    {
        Low,
        Medium,
        High
    }

    class Program1
    {
        public enum Level1 { Low, Medium, High };
    }

    enum Months
    {
        January,    //0
        February,   //1
        March,      //2
        April,      //3
        May,        //4
        June,       //5
        July        //6
    }

    enum Months1
    {
        August,         //7
        September,      //8
        October,        //9
        November=12,    //12
        December        //13
    }

}