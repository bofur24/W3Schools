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