using System.Runtime.CompilerServices;

namespace Dataa_Types_Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Data Types");
            Console.WriteLine("A data type specifies the size and type of variable values.");
            Console.WriteLine("It is important to use the correct data type for the corresponding variable; to avoid errors, to save time and memory, but it will also make your code more maintainable and readable. The most common data types are:");
            Console.WriteLine("int 4 bytes Stores whole numbers from -2,147,483,648 to 2,147,483,647" +
                "\n long 8 bytes Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807" +
                "\n float 4 bytes Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits" +
                "\n double 8 bytes Stores fractional numbers. Sufficient for storing 15 decimal digits" +
                "\n bool 1 bit Stores true or false values" +
                "\n char 2 bytes Stores a single character/letter, surrounded by single quotes" +
                "\n string 2 bytes per character Stores a sequence of characters, surrounded by double quotes");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Numbers");
            Console.WriteLine();
            Console.WriteLine("Int");
            Console.WriteLine("In general the int data type is the preferred data type when we create variables with a numeric value.");
            int myNum = 100000;
            Console.WriteLine("int myNum = 100000 " + myNum);
            Console.WriteLine();
            Console.WriteLine("Long");
            Console.WriteLine("This is used when int is not large enough to store the value. Note that you should end the value with an \"L\"");
            long myNum1 = 15000000000L;
            Console.WriteLine("long myNum1 = 15000000000L " + myNum1);
            Console.WriteLine();
            Console.WriteLine("Floating Point Types");
            Console.WriteLine("You should use a floating point type whenever you need a number with a decimal, such as 9.99 or 3.14515.");
            Console.WriteLine("The float and double data types can store fractional numbers. Note that you should end the value with an \"F\" for floats and \"D\" for doubles:");
            Console.WriteLine("Float Example");
            float myNum2 = 5075F;
            Console.WriteLine("float myNum2 = 5075F " +myNum2);
            Console.WriteLine();
            double myNum3 = 19.99D;
            Console.WriteLine("double myNum3 = 19.99D " + myNum3);
            Console.WriteLine();
            Console.WriteLine("Scientific Numbers");
            Console.WriteLine("A floating point number can also be a scientific number with an \"e\" to indicate the power of 10:");
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine("float f1 = 35e3F " + f1);
            Console.WriteLine("double d1 = 12E4D " + d1);
            Console.WriteLine();
            Console.WriteLine("Booleans");
            Console.WriteLine("A boolean data type is declared with the bool keyword and can only take the value ture or false:");
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine("bool isCSharpFun = true; " + isCSharpFun);
            Console.WriteLine("bool isFishTasty = false; " + isFishTasty);
            Console.WriteLine();
            Console.WriteLine("Characters");
            Console.WriteLine("The char data type is used to store a single character. The character must be surrounded by single quotes, like \'A\' or \'c\':");
            char myGrade = 'B';
            Console.WriteLine("char myGrade = \'B\';" + myGrade);
            Console.WriteLine();
            Console.WriteLine("Strings");
            Console.WriteLine("The string data type is used to store a sequence of characters (text). String values must be surrounded by ouble quotes:");
            string greeting = "Hello World";
            Console.WriteLine("string greeting = \"Hello World\";" + greeting);
            Console.WriteLine();
            Console.WriteLine("Type Casting");
            Console.WriteLine("Type casting is when you assign a value of one data type to another type.");
            Console.WriteLine("In C#, there are two types of casting:" +
                "\n Implicit Casting (automatically) - converting a small type to a larger type size" +
                "\n char -> int -> long -> float -> double ->" +
                "\n Explicit Casting (manually) - converting a larger type to a smaller size type" +
                "\n double -. float -> long -> int -> char");
            Console.WriteLine();
            Console.WriteLine("Implicit Casting");
            Console.WriteLine("Implicit casting is done automatically when passing a smaller size type to a larger size type:");
            int myInt = 9;
            double myDouble = myInt;    // Automatic casting: int to double

            Console.WriteLine("int myInt = 9; double myDouble = myInt; This will cast automatically int to double");
            Console.WriteLine(myInt); // Outputs 9
            Console.WriteLine(myDouble); // Outputs 9
            Console.WriteLine();
            Console.WriteLine("Explicit Casting");
            Console.WriteLine("Explicit casting must be done manually by placing the type in parentheses in from of the Value:");
            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble1;    // Manual castin: double to int
            
            Console.WriteLine("double myDouble1 = 9.78; int myInt1 = (int)myDouble1; This will cast manually by using the (int) casting");
            Console.WriteLine(myDouble1);   // Outputs 9.78
            Console.WriteLine(myInt1);      // Outputs 9
            Console.WriteLine();

            Console.WriteLine("Type Conversion Methods");
            Console.WriteLine("It is also possible to convert data types explicitly by using built-in methods, such as " +
                "\n Convert.ToBoolean" +
                "\n Convert.ToDouble" +
                "\n Convert.ToString" +
                "\n Convert.ToInt32 (int)" +
                "\n Convert.ToInt64 (long)");

            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool2 = true;

            Console.WriteLine("int myInt2 = 10; double myDouble2 = 5.25; bool myBool2 = true;");
            Console.WriteLine(Convert.ToString(myInt2));        // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));         // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble2));      // convert double to int
            Console.WriteLine(Convert.ToString(myBool2));       // convert bool to string












        }
    }
}
