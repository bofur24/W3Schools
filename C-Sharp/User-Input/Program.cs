namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Usper Input");
            Console.WriteLine("Get User Input");
            Console.WriteLine("You have already learned that Console.WriteLine() is used to output (print) values. now we will use Console.ReadLine() to get user input.");
            Console.WriteLine("In the following example, the user can input his or hers username, which is stored in the variable userName. Then we print the value of userName:");
            Console.WriteLine();
            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable.
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), wich will display the input value
            Console.WriteLine("Username is: " +  userName);

            Console.WriteLine("---------");
            Console.WriteLine("The Console.ReadLine() method returns a string. Therefore, you cannot get information from another data type, such as int.");
            Console.WriteLine("You can convert any type explicitly, by using one of the Convert.To methods:");

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
        }
    }
}
