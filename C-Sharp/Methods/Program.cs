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

        }
    }
}
