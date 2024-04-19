using System.Reflection.Metadata;

namespace Conditionals_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Conditions an If Statements");
            Console.WriteLine("C# supports the usual logical conditions from mathematics:\n" +
                "Less than: a < b\n" +
                "Less thand or equal to: a <= b\n" +
                "Greater than: a > b\n" +
                "Greater than or equal to: a >= b\n" +
                "Equal to: a == b\n" +
                "Not Equal to: a != b");
            Console.WriteLine("You can use these conditions to perform different actions for different decisions.");
            Console.WriteLine("C# has the following conditional statements:\n" +
                "Use if to specify a block of code to be executed, if a specified condition is true.\n" +
                "Use else to specify a block of code to be executed, if the same condition is false.\n" +
                "Use else if to specify a new condition to test, if the first condition is false.\n" +
                "Us switch to specify many alternative blocks of code to be executed.");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("The if Statement");
            Console.WriteLine("Use the if statement to specify a block of C# code to be executed if a condition is True.");
            Console.WriteLine("In the example below, we test two values to find out if 20 is greater than 18. If the condition is True, print some text");
            Console.WriteLine();
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            Console.WriteLine("We can also test variables:");
            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            Console.WriteLine();
            Console.WriteLine("Example explained");
            Console.WriteLine("In the example above we use two variables, x and y, to test " +
                "whether x is greater than y (using the > operator). As x is 20, and y is 18, " +
                "and we know that 20 is greater than 18, we print to the screen that" +
                "\"x is greater than y\"");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("C# The else Statement");
            Console.WriteLine("Use the else statement to specify a block of code to be executed if the condition is False.");
            int time = 22;
            if (time < 18) 
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            // Outputs "Good evening."
            Console.WriteLine();
            Console.WriteLine("Example explained");
            Console.WriteLine("In the example above, time (22) is greater than 18 so the condition is False." +
                " Becasue of this, we move on to the else condition and print to the screen \"Good evening\"." +
                " If the time was less than 18, the program would print \"Good day\".");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("C# The else if Statement");
            Console.WriteLine("Use the else if statement to specify a new condition if the first condition is False.");
            if (time < 10) 
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20) 
            {
                Console.WriteLine("Good day.");
            }
            else 
            {
                Console.WriteLine("Good evening.");
            }

            // Outputs "Good evening."
            Console.WriteLine();
            Console.WriteLine("Example explained");
            Console.WriteLine("In the example above, time (22) is greater than 10 so the first condition " +
                "is False. The next condition, in the else if statement, is also False, so we move on to " +
                "the else condition sice condition1 and condition2 is both False - and print to the screen " +
                "\"Good evening.\"");
            Console.WriteLine("However, if the time was 14, our program would print \"Good day.\"");
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("C# Short hand If...Else (Ternary Operator)");
            Console.WriteLine("There is also a short-hand if else, which is known as the \bternary operator\b becasue it consists of three operands." +
                "It can be used to replace multiple lines of code with a single line. It is often used to replace simple if else statements:");
            Console.WriteLine("You can simply write:");
            Console.WriteLine();
            Console.WriteLine("string result = (time < 18) ? \"Good day.\" : \"Good evening.\";");
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("C# Switch Statements");
            Console.WriteLine("Use the switch statement to select one of many code locks to be executed.");
            Console.WriteLine("This is how it works: \n" +
                "The switch expression is evaluated once\n" +
                "The value of the expression is compared with the values of each case\n" +
                "If there is a match, the associated block of code is executed\n" +
                "The break and default keywords will be described later in this chapter");
            Console.WriteLine("The example below uses the weekday number to calculate the weekday name:");
            Console.WriteLine();
            Console.WriteLine("            int day = 4;\r\n            switch (day) \r\n            {\r\n                case 1: \r\n                    Console.WriteLine(\"Monday\");\r\n                    break;\r\n                case 2:\r\n                    Console.WriteLine(\"Tuesday\");\r\n                    break;\r\n                case 3:\r\n                    Console.WriteLine(\"Wednesday\");\r\n                    break;\r\n                case 4:\r\n                    Console.WriteLine(\"Thursday\");\r\n                    break;\r\n                case 5:\r\n                    Console.WriteLine(\"Friday\");\r\n                    break;\r\n                case 6:\r\n                    Console.WriteLine(\"Saturday\");\r\n                    break;\r\n                case 7:\r\n                    Console.WriteLine(\"Sunday\");\r\n                    break;\r\n            }\r\n            // Outputs \"Thursday\" (day 4)\r\n\r\n\r\n        }");
            int day = 4;
            switch (day) 
            {
                case 1: 
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)
            Console.WriteLine();
            Console.WriteLine("The break keyword");
            Console.WriteLine("When C# reaches a break keyword, it breaks out of the switch block.");
            Console.WriteLine("This will stop the execution of more coade and case testing inside the block.");
            Console.WriteLine("When a match is found, and the job is done, it's time for a break. There is no need for more testing.");
            Console.WriteLine();
            Console.WriteLine("switch (day)\r\n            {\r\n                case 6:\r\n                    Console.WriteLine(\"Today is Saturday.\");\r\n                    break;\r\n                case 7:\r\n                    Console.WriteLine(\"Today is Sunday\");\r\n                    break;\r\n                default:\r\n                    Console.WriteLine(\"Looking forward to the weekend.\");\r\n                    break;\r\n            }\r\n            // Outputs \"Looking forward to the weekend.");
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the weekend.");
                    break;
            }
            // Outputs "Looking forward to the weekend.
            

        }
    }
}
