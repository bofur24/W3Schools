using System.Runtime.CompilerServices;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Strings");
            Console.WriteLine("Strings are used for storing text.");
            Console.WriteLine("A string variable contains a collection of characters surrounded by double quotes:");
            string greeting = "Hello";
            Console.WriteLine("string greeting = " + greeting);
            Console.WriteLine("A string variable can contain many words, if you want:");
            string greeting2 = "Nice to meet you!";
            Console.WriteLine("string greeting2 = " + greeting2);
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("String Length");
            Console.WriteLine("A string in C# is actually an object, which contain properties and methods that can perform certain operations on strings. For example, the length of a string can be found with the Length property:");
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " +txt.Length);
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Other Methods");
            Console.WriteLine("There are many string methods available, for example ToUpper() and ToLower(), which returns a copy of the string converted to uppercase or lowercase:");
            string txt1 = "Hello World";
            Console.WriteLine(txt1.ToUpper());
            Console.WriteLine(txt1.ToLower());
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("String Concatenation");
            Console.WriteLine("The + operator can be used between strings to combine them. This is called concatenation:");
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine("firstName + lastName = " + name);
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine(("You can also use the string.Concat() method to concatenate two strings:"));
            name = string.Concat(firstName, lastName);
            Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Adding Numbers and Strings");
            Console.WriteLine("If you add two numbers, the result will be a number:");
            int x = 10;
            int y = 20;
            int z = x + y; // Z will be 30 (an integer / number)
            Console.WriteLine("int z = x + y; = " + z);
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("If you add two strings, the result will be a string concatenation:");
            string a = "10";
            string b = "20";
            string c = a + b; // z will be 1020 (a string)
            Console.WriteLine("string c = a + b; = 1020");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("C# String Interpolation");
            Console.WriteLine("Another option of string concatenation, is string interpolation, which substitutes values of variables into placeholders in a string. Note that you do not have to worry about spaces, like with concatenation:");
            Console.WriteLine($"My full name is: {firstName} {lastName}");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("C# Access Strings");
            Console.WriteLine("You can access the characters in a string by referring to its index number inside square brackets []");
            Console.WriteLine("This example prints the first character in myString:");
            string myString = "Hello";
            Console.WriteLine(myString[0]); //Outputs "H"
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("This example prints the second character (1) in myString");
            Console.WriteLine(myString[1]); //Outputs "e"
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("You can also find the index position of a specific character in a string, by using the IndexOf() method:");
            Console.WriteLine(myString.IndexOf("e")); // Outputs "1"
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Another useful method is Substring(), which the characters from a string, starting from the specified character position/index," +
                "and returns a new string.");
            Console.WriteLine("This method is often used together with IndexOf() to get the specific character position:");
            int charPos = name.IndexOf("D");
            string newLastName = name.Substring(charPos);
            Console.WriteLine($"The substring of name at IndexOf D is = \"{newLastName}\"");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("C# Special Characters");
            Console.WriteLine("Becasue strings must be written within quots, C# will misundrstand strings with quote with in the statement");
            Console.WriteLine("The solution to avoi this problem, is to us the backslash escape character.");
            Console.WriteLine("The backslash (\\) escape character turns special characters into string characters:");
            Console.WriteLine();
            Console.WriteLine("Escape character\t\tResult\t\tDescription\n" +
                "\\\'\t\t\t\t\'\t\tSingle quote\n" +
                "\\\"\t\t\t\t\"\t\tDouble quote\n" +
                "\\\\\t\t\t\t\\\t\tBackslash");
            Console.WriteLine("The sequence\\\" inserts a double quote in a string");
            Console.WriteLine("The sequence\\\' inserts a single quote in a string");
            Console.WriteLine("The sequence \\\\ inserts a single backslash in a string");
            Console.WriteLine("Other useful escape characters in C# are:");
            Console.WriteLine();
            Console.WriteLine("Code\t\tResult\n" +
                "\\n\t\tNew Line\n" +
                "\\t\t\tTab\n" +
                "\\b\t\tBackspace");



        }
    }
}
