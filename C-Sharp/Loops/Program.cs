namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# While Loop");
            Console.WriteLine("Loops can execute a block of code as long as a specified condition is reached.");
            Console.WriteLine("Loops are handy because they save time, reduce errors, and they make code more readable.");
            Console.WriteLine("The while loop loops through a block of code as long as a specified condition is True:");
            Console.WriteLine("In the example below, the code in the loop will run over and over again, as long as a variable (i) is less than 5");
            Console.WriteLine();
            Console.WriteLine("int i = 0;\r\n            while (i < 5)\r\n            {\r\n                Console.WriteLine(i);\r\n                i++;\r\n            }");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("The Do/While Loop");
            Console.WriteLine("The do/while loop is a variant of the while loop. This loop will execute the code block once, before checking if the condition is true, " +
                "then it will repeat the loop as long as the condition is true.");
            Console.WriteLine("The example below uses a do/while loop. The loop will always be executed at least once, even if the condition is false, " +
                "because the code block is executed before the condition is tested:");
            Console.WriteLine();
            Console.WriteLine("int h = 0;\r\n            do\r\n            {\r\n                Console.WriteLine(h);\r\n                h++;\r\n            }\r\n            while (h < 5); ");
            int h = 0;
            do
            {
                Console.WriteLine(h);
                h++;
            }
            while (h < 5); 

            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("C# For Loop");
            Console.WriteLine("When you know exactly how many times you want to loop though a block of code, use the for loop instead of a while loop:");
            Console.WriteLine();
            Console.WriteLine("Statement 1 is executed (one time) before the execution of the code block.");
            Console.WriteLine("Statement 2 defines the condition for executing the code block.");
            Console.WriteLine("Statement 3 is executed (every time) after the code block has been executed.");
            Console.WriteLine("The example below will print the numbers 0 to 4:");
            Console.WriteLine() ;
            Console.WriteLine("for (int j = 0; j < 5; j++)\r\n            {\r\n                Console.WriteLine(j);\r\n            }");
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("Example explained");
            Console.WriteLine("Statement 1 sets a variable before the loop starts (int j = 0).");
            Console.WriteLine("Statement 2 defines the condition for the loop to run (j must be less than 5). If the condition is ture, " +
                "the loop will start over again, if it is false, the loop will end.");
            Console.WriteLine("Statement 3 increases a value (i++) each time the code block in the loop has been executed.");
            Console.WriteLine("Another Example");
            Console.WriteLine("This example will only print even values between 0 and 10:");
            Console.WriteLine("for (int k = 0; k <= 10; k = k + 2)\r\n            {\r\n                Console.WriteLine(k);\r\n            }");
            for (int k = 0; k <= 10; k = k + 2)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Nested Loops");
            Console.WriteLine("It is also possible to place a loop inside another loop. This is called nested loop.");
            Console.WriteLine("The \"inner loop\" will be executed one time for each iteration of the \"outer loop\":");
            Console.WriteLine("// Outer loop\nfor (int l = 0; l <= 2; l++)\r\n            {\r\n                Console.WriteLine($\"Outer: {l}\");\r\n\r\n                // Inner loop\r\n                for (int m = 1; m <= 3; m++)\r\n                {\r\n                    Console.WriteLine($\" inner: {m}\");\r\n                }\r\n            }");
            // Outer loop
            for (int l = 0; l <= 2; l++)
            {
                Console.WriteLine($"Outer: {l}");

                // Inner loop
                for (int m = 1; m <= 3; m++)
                {
                    Console.WriteLine($" inner: {m}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("C# Foreeach Loop");
            Console.WriteLine("There is also a foreach loop, which is used exclusively to loop through elements in an array.");
            Console.WriteLine("The following example outputs all elements in the cars array, using a foreach loop:");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string n in cars)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            Console.WriteLine("--------");
            Console.WriteLine("C# Break and Continue");
            Console.WriteLine("C# Break");
            Console.WriteLine("You have already seen the break statement used in an earlier chapter of this tutorial. It was used to " +
                "\"jump out\" of a switch statement.");
            Console.WriteLine("The break statement can also be used to jump out of a loop.");
            Console.WriteLine("This example jumps out of the lop when o is equal to 4:");
            Console.WriteLine("for (int o = 0; o < 10; o++)\r\n            {\r\n                if (o == 4)\r\n                {\r\n                    break;\r\n                }\r\n\r\n                Console.WriteLine(o);\r\n            }");
            for (int o = 0; o < 10; o++)
            {
                if (o == 4)
                {
                    break;
                }

                Console.WriteLine(o);
            }

            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("C# Continue");
            Console.WriteLine("The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.");
            Console.WriteLine("This example skips the value of 4:");
            Console.WriteLine("for (int p = 0; p < 10; p++)\r\n            {\r\n                if (p == 4)\r\n                {\r\n                    continue;\r\n                }\r\n                Console.WriteLine(p);\r\n            }");
            for (int p = 0; p < 10; p++)
            {
                if (p == 4)
                {
                    continue;
                }
                Console.WriteLine(p);
            }



            Console.ReadLine();








        }
    }
}
