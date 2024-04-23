namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Arrays");
            Console.WriteLine("Create an Array");
            Console.WriteLine("Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.");
            Console.WriteLine("To declare an array, define the variable type with square brackets:");
            Console.WriteLine("We have now declared a variable that holds an array of strings.");
            Console.WriteLine("To insert values to it, we can use an array literal - place the values in a comma-separated list, inside curly braces:");
            Console.WriteLine("string[] cars = { \"Volvo\", \"BMW\", \"Ford\", \"Mazda\" };");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[1]);
            Console.WriteLine("To create an array of integers, you could write:");
            Console.WriteLine("int[] myNum = { 10, 20, 30, 40 };");
            int[] myNum = { 10, 20, 30, 40 };
            Console.WriteLine(myNum[2]);
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Access the Elements of an Array");
            Console.WriteLine("You access an array element by referring to the index number.");
            Console.WriteLine("This statement accesses the value of the first element in cars:");
            Console.WriteLine(cars[0]);
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Change an Array Element");
            Console.WriteLine("To change the value of a specific element, refer to the index number:");
            Console.WriteLine("cars[0] = \"Opel\"");
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Array Length");
            Console.WriteLine("To find out how many elements an array has, use the Length property:");
            Console.WriteLine("$\"There are {cars.Length} cars.\"");
            Console.WriteLine($"There are {cars.Length} cars.");
            // Outputs 4
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Other Ways to Create an Array");
            Console.WriteLine("If you are familiar with C#, you might have seen arrays created with the new keyword, and perhaps you have seen arrays with a specified size as well. In C#, there are different ways to create an array:");
            // Create an array of four elements, and add values later
            string[] names = new string[4];
            // Create an array of four elements and add values right away
            string[] lastNames = new string[4] { "Heffington", "Hammer", "Tacket", "Bros" };
            // Create an array of four elements without specifying the size
            string[] firstNames = new string[] { "Keith", "Derrick", "Ronnie", "Mario" };
            // Creat an array of four elements, omitting the new keyword, and without specifying the size
            string[] middleNames = { "Lynn", "Ray", "Tom", "Bros" };
            Console.WriteLine("You should note that if you declare an array and initialize it later, you have to use the new keyword:");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Loop Through an Array");
            Console.WriteLine("You can loop though the array elements with the for loop, and use the Length property to specify how many times the loop should run.");
            Console.WriteLine("The following example outputs all elements in the cars array:");
            Console.WriteLine("for (int i = 0; i < cars.Length; i++)\r\n            {\r\n                Console.WriteLine(cars[i]);\r\n            }");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("The foreach Loop");
            Console.WriteLine("There is also a foreach loop, which is used exclusively to loop through elements in an array:");
            Console.WriteLine("The following example outputs all elements in the cars array, using a foreach loop:");
            Console.WriteLine("foreach (string i in cars)\r\n            {\r\n                Console.WriteLine(i);\r\n            }");
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The example above can be read like this: for each string element (called i - as in index) in cars, print out the value of i.");
            Console.WriteLine("If you compare the for loop and foreach loop, you will see that the foreach method is easier to write, it does not require a counter (using the Length property), and it is more readable.");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Sort Array");
            Console.WriteLine("There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:");
            Console.WriteLine("Array.Sort(cars);\r\n            foreach (string i in cars)\r\n            { \r\n                Console.WriteLine(i);\r\n            }");
            // Sort a string
            Array.Sort(cars);
            foreach (string i in cars)
            { 
                Console.WriteLine(i);
            }
            Console.WriteLine("Array.Sort(myNum);\r\n            foreach (int i in myNum)\r\n            {\r\n                Console.WriteLine(i);\r\n            }");
            // Sort an int
            Array.Sort(myNum);
            foreach (int i in myNum)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("System.Linq Namespace");
            Console.WriteLine("Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:");
            Console.WriteLine($"Max number {myNum.Max()}");
            Console.WriteLine($"Min number {myNum.Min()}");
            Console.WriteLine($"Sum number {myNum.Sum()}");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Multidimensional Arrays");
            Console.WriteLine("In the previous chapter, you learned about arrays, which is also known as single dimension arrays. These are great, and something you will use a lot while programming in C#. However, if you want to store data as a" +
                " tabular form, like a table with rows and columns, you need to get familiar with multidimensional arrays.");
            Console.WriteLine("A multidimensional array is basically an array of arrays.");
            Console.WriteLine("Arrays can have any number of dimensions. The most common are two-dimensional arrays (2D)");
            Console.WriteLine("int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };");
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine("numbers is now an array with two arrays as its elements. The first array element contains three elements: 1, 4 and 2, while the second array element contains 3, 6 and 8. " +
                "To visualize it, think of the array as a table with rows and columns:");
            Console.WriteLine("\t\tCOLUMN 0\tCOLUMN 1\tCOLUMN 2\n" +
                "ROW 0\t\t1\t\t4\t\t2\n" +
                "ROW 1\t\t3\t\t6\t\t8");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Access Elemtns of a 2D Array");
            Console.WriteLine("To access an element of a two-dimensional array, you must specify two indexes: one for the array, and one for the element inside that array. Or better yet, with the table visualization in mind;" +
                " one for the row and one for the column (see example below).");
            Console.WriteLine("This statement accesses the value of the element in the first row (0) and third column (2) of the numbers array:");
            Console.WriteLine($"numbers[0, 2] Outputs {numbers[0, 2]}");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Change Elements of a 2D Array");
            Console.WriteLine("You can change the value of an element.");
            Console.WriteLine("The following example will change the value of the element in the first row (0) and frist column (0):");
            Console.WriteLine($"numbers[0, 0] = 5 // Changes value to {numbers[0,0] = 5} instead of 1");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Loop Through a 2D Array");
            Console.WriteLine("You can easily loop through the elements of a two-dimensional array with a foreach loop:");
            Console.WriteLine("foreach (int i in numbers)\r\n            {\r\n                Console.WriteLine(i);\r\n            }");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("You can also use a for loop. For multidimensional arrays, you need one loop for each of the array's dimensions.");
            Console.WriteLine("Also note that we have to use GetLength() instead of Length to specify how many times the loop should run:");
            Console.WriteLine("for (int i = 0; i < numbers.GetLength(0); i++)\r\n            {\r\n                for (int j = 0; j < numbers.GetLength(1); j++)\r\n                {\r\n                    Console.WriteLine(numbers[i, j]);\r\n                }\r\n            }");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }


        }
    }
}
