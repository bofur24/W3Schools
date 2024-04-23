namespace Methods
{
    internal class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void MyNameMethod(string fname)
        {
            Console.WriteLine($"{fname} Heffington");
        }

        static void MyNameAgeMethod(string fname, int age) 
        {
            Console.WriteLine($"{fname} is {age}");
        }

        static void MyCountryMethod(string country = "Norway") 
        {
            Console.WriteLine(country);
        }

        static int MyNumberMethod(int x)
        {
            return 5 + x;
        }

        static int MyNumbersMethod(int x, int y) 
        {
            return x + y;
        }

        static void MyChildMethod(string child1, string child2, string child3)
        {
            Console.WriteLine($"The youngest child is: {child3}");    
        }
        static void Main(string[] args)
        {
            Console.WriteLine("C# Methods");
            Console.WriteLine("A method is a block of code which only runs when it is called.");
            Console.WriteLine("You can pass data, known as parameters, into a method.");
            Console.WriteLine("Methods are used to perform certain actions, and they are also known as functions.");
            Console.WriteLine("Why use methods? To reuse code: define the code once, and use it many times.");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Create a Method");
            Console.WriteLine("A method is defined with the name of the method, followed by parentheses (). C# provides some pre-defined methods, which you already are familiar with, such as Main(), but you can also create your own methods to perform certain actions:");
            Console.WriteLine("class Program\r\n            {\r\n                static void MyMethod()\r\n            {\r\n                // code to be executed\r\n            }\r\n            }");
            Console.WriteLine();
            Console.WriteLine("Example Explained");
            Console.WriteLine("MyMethod() is the name of the method");
            Console.WriteLine("static means that the method belongs to the Program class and not an object of the Program class.");
            Console.WriteLine("void means that this method does not have a return value.");
            Console.WriteLine();
            Console.WriteLine("Call a Method");
            Console.WriteLine("To call (execute) a method, write the method's name followed by two parentheses () and a semicolon;");
            Console.WriteLine("In the following example, MyMethod() is used to print a text (the action), when it is called:");
            MyMethod();
            Console.WriteLine();
            Console.WriteLine("A method can be called multiple times:");
            MyMethod();
            MyMethod();
            MyMethod();
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Parameters and Arguments");
            Console.WriteLine("Information can be passed to methods as parameter. Parameters act as variables inside the method.");
            Console.WriteLine("They are specified after the method name, inside the parentheses. You can add as many parameters as you want, just separate them with a comma.");
            Console.WriteLine("The following example has a method that takes a string called fname as parameter. When the method is called, we pass along a first name, which is used inside the method to print the full name:");
            Console.WriteLine("static void MyNameMethod(string fname)\r\n        {\r\n            Console.WriteLine($\"{fname} Heffington\");\r\n        }");
            MyNameMethod("Keith");
            MyNameMethod("Trish");
            MyNameMethod("Leon");
            MyNameMethod("Lucas");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Multiple Parameters");
            Console.WriteLine("You can have as many parameters as you like, just separate them with commas: ");
            Console.WriteLine("");
            MyNameAgeMethod("Keith", 39);
            MyNameAgeMethod("Trish", 34);
            MyNameAgeMethod("Leon", 7);
            MyNameAgeMethod("Lucas", 6);
            Console.WriteLine("Default Parameter Value");
            Console.WriteLine("You can also use a default parameter value, by using the equals sign (=)");
            Console.WriteLine("If we call the method without an argument, it uses the default value (\"Norway\")");
            Console.WriteLine("static void MyCountryMethod(string country = \"Norway\") \r\n        {\r\n            Console.WriteLine(country);\r\n        }");
            MyCountryMethod("Sweden");
            MyCountryMethod("India");
            MyCountryMethod();
            MyCountryMethod("USA");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Return Values");
            Console.WriteLine("In the previous examples, we used the void keyword, which indicates that the method should not return a value.");
            Console.WriteLine("If you want the method to return a value, you can use a primitive data type (such as int or double) instead of void, and use the return keyword inside the method:");
            Console.WriteLine("static int MyNumberMethod(int x)\r\n        {\r\n            return 5 + x;\r\n        }");
            Console.WriteLine(MyNumberMethod(3));
            Console.WriteLine();
            Console.WriteLine("This example returns the sum of a method's two parameters:");
            Console.WriteLine(MyNumbersMethod(5, 3));
            Console.WriteLine();
            Console.WriteLine("You can also store the result in a variable (recommended, as it is easier to read and maintain):");
            Console.WriteLine("");
            int z = MyNumbersMethod(7, 8);
            Console.WriteLine($"int z = MyNumbersMethod(7, 8) = {z}");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Named Arguments");
            Console.WriteLine("It is also possible to send arguments with the key: value syntax.");
            Console.WriteLine("That way, the order of the arguments does not matter:");
            Console.WriteLine("static void MyChildMethod(string child1, string child2, string child3)\r\n        {\r\n            Console.WriteLine($\"The youngest child is: {child3}\");    \r\n        }");
            MyChildMethod(child3: "Lucas", child1: "Liam", child2: "Leon");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Method Overloading");
            Console.WriteLine("With method overloading, multiple methods can have the same name with different parameters:");
            
        }
    }
}
