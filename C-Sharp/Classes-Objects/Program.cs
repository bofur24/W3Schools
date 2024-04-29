
using Classes_Object;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Classes & Objects");
        Console.WriteLine("OOP");
        Console.WriteLine("What is OOP");
        Console.WriteLine("OOP stands for Object-Oriented Programming.");
        Console.WriteLine("Procedural programming is about writing procedures or methods that perform operations on the data, while object-oriented programming is about creating objects that contain both data and methods.");
        Console.WriteLine("Object-oriented programming has several advantages over procedural programming:");
        Console.WriteLine("OOP is faster and easier to execute\n" +
            "OOP provides a clear structure for the programs\n" +
            "OOP helps to keep the C# code DRY \"Don't Repeat Yourself\", and makes the code easier to maintain, modify and debug\n" +
            "OOP makes it possible to create full reusable applications with less code and shorter development time.");
        Console.WriteLine("Tip: The \"Don't Repeat Yourself\" (DRY) principle is about reducing the repetition of code. You should extract out the codes that are common for the application, and place them at a single place and reuse them instead of repeating it.");
        Console.WriteLine("C# - What are Classes and Objects?");
        Console.WriteLine("Classes and objects are the two main aspects of object-oriented programming.");
        Console.WriteLine("Look at the following illustration to see the difference between class and objects:");
        Console.WriteLine("Class\tObjects\n" +
            "Fruit\tApple\n" +
            "\tBanana\n" +
            "\tMango");
        Console.WriteLine("So, a class is a template for objects, and an object is an instance of a class");
        Console.WriteLine("When the individual objects are created, they inherit all the variables and methods from the class");
        Console.WriteLine();
        Console.WriteLine("----------");
        Console.WriteLine("Classes and Objects");
        Console.WriteLine("You learned from the previous chapter that C# is an object-oriented programming language.");
        Console.WriteLine("Everything is C# is associated with classes and objects, along with its attributes and methods. For example: in real life, a car is an object. The car has attributes, such as weight and color, methods, such as drive and brake.");
        Console.WriteLine("A Class is like an object constructor, or a \"blueprint\" for creating objects.");
        Console.WriteLine();
        Console.WriteLine("Create a Class");
        Console.WriteLine("To create a class, use the class keyword:");
        Console.WriteLine("class Car\r\n{\r\nstring color = \"red\";\r\n}");
        Console.WriteLine();
        Console.WriteLine("Create an Object");
        Console.WriteLine("An object is created from a class. We have already created the class named Car, so now we can use this to create objects.");
        Console.WriteLine("To create an object of Car, specify the class name, followed by the object name, and use the keyword new:");
        Console.WriteLine("Car myObj = new Car();\r\nConsole.WriteLine(value: myObj.color);");
        Car myObj = new Car();
        Console.WriteLine(myObj.color);
        Console.WriteLine();
        Console.WriteLine("--------");
        Console.WriteLine("Multiple Objects");
        Console.WriteLine("You can create multiple objects of one class:");
        Console.WriteLine("Car myObj1 = new Car();\r\nCar myObj2 = new Car();\r\nConsole.WriteLine(myObj1.color);\r\nConsole.WriteLine(myObj2.color);");
        Car myObj1 = new Car();
        Car myObj2 = new Car();
        Console.WriteLine(myObj1.color);
        Console.WriteLine(myObj2.color);
        Console.WriteLine();
        Console.WriteLine("----------");
        Console.WriteLine("Using Multiple Classes");
        Console.WriteLine("You can also create an object of a class and access it in another class. This is often used for better organization of classes (one class has all the fields and methods, while the other class holds the Main() method (code to be executed)).");
        Console.WriteLine("prog2.cs\n" +
            "prog.cs");
        Console.WriteLine("");
        Car myObj3 = new Car();
        Console.WriteLine();
        Console.WriteLine("---------");
        Console.WriteLine("Class Members");
        Console.WriteLine("Fields and methods inside classes are often referred to as \"Class Members\":");
        Console.WriteLine("// Class members\r\npublic string color = \"red\";    // field\r\npublic int maxSpeed = 200;      // field\r\npublic void fullThrottle()      // method\r\n{\r\nConsole.WriteLine(\"The car is going as fast as it can!\");\r\n}");
        Console.WriteLine();
        Console.WriteLine("---------");
        Console.WriteLine("Fields");
        Console.WriteLine("In the previous chapter, you learned that variables inside a clsss are called fields, and that you cna access them by creating an object of the class, and by using the dot syntax (.).");
        Console.WriteLine("The following example will create an object of the Car class, with the name myObj. Then we print the value of the fields color and maxSpeed:");
        Car myObj4 = new Car();
        Console.WriteLine($"The car obj color is {myObj4.color}");
        Console.WriteLine($"The car obj maxspeed is {myObj4.maxSpeed}");
        Console.WriteLine();
        Console.WriteLine("---------");
        Console.WriteLine("You can also leave the fields blank, and modify them when creating the object:");
        Console.WriteLine("This is especially useful when creating multiple objects of one class:");
        Person Female = new Person();
        Female.fName = "Trish";
        Female.lName = "Heffington";
        Female.age = 34;
        Female.gender = "F";

        Person Male = new Person();
        Male.fName = "Keith";
        Male.lName = "Heffington";
        Male.age = 39;
        Male.gender = "M";

        Console.WriteLine($"Female First Name {Female.fName}\n" +
            $"Female Last Name {Female.lName}\n" +
            $"Female Age {Female.age}\n" +
            $"Female Gender {Female.gender}");
        Console.WriteLine();
        Console.WriteLine($"Male First Name {Male.fName}\n" +
            $"Male Last Name {Male.lName}\n" +
            $"Male Age {Male.age}\n" +
            $"Male Gender {Male.gender}");
        Console.WriteLine();
        Console.WriteLine("--------");
        Console.WriteLine("Other Methods");
        Console.WriteLine("You learned from the C# Methods chapter that methods are used to perform certain actions.");
        Console.WriteLine("Methods normally belong to a class, and they define how an object of a class behaves.");
        Console.WriteLine("Just like with fields, you can access methods with the dot syntax. However, note that the method must be public. And remember that we use the name of the method followed by two parentheses () and a semicolon ; to call (execute) the method:");
        Console.WriteLine($"myObj.fullThrottle() will call the method: ");
        myObj4.FullThrottle();
        Console.WriteLine();
        Console.WriteLine("----------");
        Console.WriteLine("Use Multiple Classes");
        Console.WriteLine("Remember from the last chapter, that we can use multiple classes for better organization (one for fields and methods, and another one for execution). This is recommended:");
        Console.WriteLine();
        Console.WriteLine("---------");
        Console.WriteLine("Constructors");
        Console.WriteLine("A constructor is a special method that is used to initialize objects. The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields:");
        Console.WriteLine(" // create a class constructor for the Car class\r\nPublic Car()\r\n{\r\nModel = \"Mustang\"; // Set the initial value for model\r\n}");
        Car Ford = new Car();
        Console.WriteLine(Ford.model);
        Console.WriteLine();
        Console.WriteLine("----------");
        Console.WriteLine("Constructor Parameters");
        Console.WriteLine("Constructors can also take parameters, which is used to initialize fields.");
        Console.WriteLine("The following example adds a string modelName parameter to the constructor. Inside the constructor we set model to modelName (model=modelName). When we call the constructor, we pass a parameter to the constructor (\"Explorer\"), which will set the value of model to \"Explorer\":");
        Car1 Ford1 = new Car1("Explorer");
        Console.WriteLine(Ford1.model);
        Console.WriteLine("You can have as many parameters as you want:");
        Console.WriteLine("Constructors Save Time");
        Console.WriteLine();
        Console.WriteLine("----------");
        Console.WriteLine("Access Modifiers");
        Console.WriteLine("The public keyword is an access modifier, which is used to set the access level/visibility for classes, fields, methods and properties.");
        Console.WriteLine("C# has the following access modifiers:");
        Console.WriteLine("Modifier\t\tDescription\n" +
            "public\t\tThe code is accessible for all classes\n" +
            "private\t\tThe code is only accessible within the same class\n" +
            "protected\t\tThe code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter\n" +
            "internal\t\tThe code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter");
        Console.WriteLine("There's also two combinations: protected internal and private protected.");
        Console.WriteLine("For now, lets focus on public and private modifiers.");
        Console.WriteLine();
        Console.WriteLine("----------");
        Console.WriteLine("Private Modifier");
        Console.WriteLine("If you declare a field with a private access modifier, it can only be accessed within the same class:");
        Console.WriteLine("class Car2\r\n{\r\n    private readonly string model = \"Mustang\";\r\n}");
        Console.WriteLine("Public Modifier");
        Console.WriteLine("If you declare a field with a public access modifier, it is accessible for all classes");
        Console.WriteLine("Properties (Get and Set)");
        Console.WriteLine("Properties and Encapsulation");
        Console.WriteLine("Before we start to explain properties, you should have a basic understanding of \"Encapsulation\".");
        Console.WriteLine("The meaning of Encapsulation, is to make sure that \"sensitive\" data is hidden from users. To achieve this, you must:\n" +
            "declare fields/variables as private\n" +
            "provide public get and set methods, through properties, to access and update the value of a private field");
        Console.WriteLine();
        Console.WriteLine("----------");
        Console.WriteLine("Properties");
        Console.WriteLine("You learned from the previous chapter that private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.");
        Console.WriteLine("A property is like a combination of a variable and a method, and it has two methods: a get and a set method:");
        Console.WriteLine("Class Person\r\n{\r\nprivate string name; // field\r\n\r\npublic string name // property\r\n{\r\nget { return name; } // get method\r\nset { name = value; } // set method\r\n}\r\n}");
        /*Class Person
            {
                private string name; // field
                
                public string name // property
                {
                get { return name; } // get method
                set { name = value; } // set method
                }
            }
        */
        Console.WriteLine();
        Console.WriteLine("Example explained");
        Console.WriteLine("The Name property is associated with the name field. It is a good practice to use the same name for both the property and the private field, but with an uppercase first letter.");
        Console.WriteLine("The get method returns the value of the variable name.");
        Console.WriteLine("The set method assigns a value to the name variable. The value keyword represents the value we assign to the property.");
        Console.WriteLine("Now we can use the Name property to access and update the private field of the Person class:");
        Console.WriteLine("class Person1\r\n{\r\nprivate string name;        // field\r\npublic string Name;         // property\r\n{\r\nget { return name; }\r\nset { name = value; }\r\n}\r\n}");
        Person1 myPerson = new Person1();
        myPerson.Name = "Liam";
        Console.WriteLine(myPerson.Name);
        Console.WriteLine();
        Console.WriteLine("--------");
        Console.WriteLine("Automatic Properties (Short Hand)");
        Console.WriteLine("C# also provides a way to use short-hand / automatic properties, where you do not have to define the field for the property, and you only have to write get; and set; inside the property.");
        Console.WriteLine("The following example will produce the smae result as the example above. The only difference is that there is less code:");
        Console.WriteLine("class Person2\r\n\r\npublic string Name // property\r\n{ get; set; }\r\n}");
        /*
        class Person2
        {
            public string Name // property
            { get; set; }
        }   
         */
        Person2 myPerson2 = new Person2();
        myPerson2.Name = "Keith";
        Console.WriteLine(myPerson2.Name);
        Console.WriteLine();
        Console.WriteLine("Why Encapsulation?");
        Console.WriteLine("Better control of class members (reduce the possibility of yourself (or others) to mess up the code)\n" +
            "Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)\n" +
            "Flexible: the programmer can change one part of the code without affecting other parts\n" +
            "Increased security of data");
        Console.WriteLine();
        Console.WriteLine("---------");
        Console.WriteLine("Inheritance (Derived and Base Class)");
        Console.WriteLine("In C#, it is possible to inherit fields and methods from one class to another. We group the \"inheritance concept\" into two categories:\n" +
            "" +
            "Derived Class (child) - the class that inherits from another class\n" +
            "Base Class (parent) - the class being inherited from");
        Console.WriteLine("To inherit from a class, use the : symbol.");
        Console.WriteLine("In the example below, the Car class (child) inherits the fields and methods from the Vehicle class (parent):");
        
        // Create a myCar object
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();

        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
        Console.WriteLine($"{myCar.brand} {myCar.modelName}");
        Console.WriteLine();
        Console.WriteLine("----------");
        Console.WriteLine("The sealed Keyword");
        Console.WriteLine("If you don't want other classes to inherit from a class, use the sealed keyword:");
        Console.WriteLine("If you try to access a sealed class, C# will generate an error:\r\nsealed class Vehicle\r\n{\r\n....\r\n}\r\n\r\nclass Car : Vehicle\r\n{\r\n...\r\n}\r\nThe error message will be something like this:\r\n'Car': cannot derive from sealed type 'Vehicle'");
        /*
         If you try to access a sealed class, C# will generate an error:
         sealed class Vehicle
        {
        ....
        }

        class Car : Vehicle
        {
        ...
        }
        The error message will be something like this:
        'Car': cannot derive from sealed type 'Vehicle'
         
         */
            
        
    }    
    
}

namespace Classes_Object
{
    class Vehicle // Base class (parent
    {
        public string brand = "Ford";       // Vehicle field
        public void honk()                  // Vehicle method
        {
            Console.WriteLine("Tuut, tutt!");
        }
    }
    
    class Car : Vehicle // derived class (child)
    {
        // Class members
        public string modelName = "Mustang";
        public string color = "red";    // field
        public int maxSpeed = 200;      // field
        public void FullThrottle()      // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        public string model; // Create a field
        public Car()
        {
            model = "Mustang"; // Set the initial value for model
        }
    }

    class Car1
    {
        public string model;

        // Create a class constructor with a parameter
        public Car1(string modelName)
        {
            model = modelName;
        }
    }

    class Person
    {
        public string fName;
        public string lName;
        public int age;
        public string gender;
    }

    class Person1
    {
        private string name;        // field
        public string Name        // property
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Person2
    {
        public string Name // property
        { get; set; }
    }
    
        
    
}
