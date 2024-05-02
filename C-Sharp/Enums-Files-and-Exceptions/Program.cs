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