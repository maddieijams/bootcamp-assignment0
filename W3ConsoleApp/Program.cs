namespace W3ConsoleApp
{
    using System;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
            /* Syntax */
            // 1. Insert the missing part of the code below to output "Hello World!".
            static void Main2(string[] args)
            {
                Console.WriteLine("Hello World!");
            }

            /* Comments */
            // 1. Comments in C# are written with special characters. Insert the missing parts:
            // single line comment
            /* multi line comment */

            /* Variables */
            // 1. Create a variable named myNum and assign the value 50 to it.
            int myNum = 50;

            // 2. Create a variable named myName and assign the value "John" to it.
            string myName2 = "John";

            // 3. Display the sum of 5 + 10, using two variables: x and y.
            int x = 5;
            int y = 10;
            Console.WriteLine(x + y);

            // 4. Create an int variable called z, assign x + y to it, and display the result.
            int g = 5;
            int h = 10;
            int z = g + h;
            Console.WriteLine(z);

            // 5. Fill in the missing parts to create three variables of the same type, using a comma-separated list:
            int i = 5, j = 6, k = 50;
            Console.WriteLine(i + j + k);

            /* Data Types */
            // 1. Add the correct data type for the following variables:
            int myNewNum = 9;
            double myDoubleNum = 8.99;
            char letter = 'A';
            bool myBoolean = false;
            string myText = "Hello World";

            // 2. Create two boolean variables, named yay and nay, and add appropriate values to them:
            bool yay = true;
            bool nay = false;

            // 3. Create a greeting variable, and display the value of it:
            string greeting = "Hello";
            Console.WriteLine(greeting);

            // 4. Type Casting - Use the correct conversion method to convert the int variable to a string:
            int myInt = 10;
            Console.WriteLine(Convert.ToString(myInt));

            /* User Input */
            // 1. Fill in the missing parts to get user input, stored in the variable userName:
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            // 2. Fill in the missing parts to print a number put in by the user:
            Console.WriteLine("Think of a number:");
            int myNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is: " + myNum1);

            /* Operators */
            // 1. Multiply 10 with 5, and print the result.
            Console.WriteLine(10 * 5);

            // 2. Divide 10 by 5, and print the result.
            Console.WriteLine(10 / 5);

            // 3. Use the correct operator to increase the value of the variable x by 1.
            int c = 10;
            c++;

            // 4. Use the addition assignment operator to add the value 5 to the variable x.
            int d = 10;
            d += 5;

            /* Math */
            // 1. Use the correct method to print the highest value of x and y.
            int e = 1;
            int f = 7;
            Console.WriteLine(Math.Max(e, f));

            // 2. Use the correct method to print the square root of x.
            Console.WriteLine(Math.Sqrt(64));

            // 3. Use the correct method to round the number 2.6 to its nearest integer.
            Console.WriteLine(Math.Round(2.6));

            /* Strings */
            // 1. Fill in the missing part to create a greeting variable of type string and assign it the value Hello.
            string greeting1 = "Hello";

            // 2. Use the correct operator to concatenate two strings:
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);

            // 3. Use the string interpolation method to concatenate two strings:
            string first = "John";
            string last = "Doe";
            string name1 = $"My full name is: {first} {last}";
            Console.WriteLine(name1);

            // 4. Access the first character(H) in myString and print the result:
            string myString = "Hello";
            Console.WriteLine(myString[0]);

            // 5. Use the correct property to print the length of the txt string.
            string txt = "Hello";
            Console.WriteLine(txt.Length);

            // 6. Use the correct method to output the value of the txt string to upper case letters.
            string txt1 = "Hello World";
            Console.WriteLine(txt1.ToUpper());

            /* Booleans */
            // 1. Fill in the missing parts to print the values True and False
            bool isCodingFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCodingFun);
            Console.WriteLine(isFishTasty);

            // 2. Fill in the missing parts to print the value True
            int a = 10;
            int b = 9;
            Console.WriteLine(a > b);

            /* If/Else */
            // 1. Print "Hello World" if x is greater than y.
            if (x > y)
            {
                Console.WriteLine("Hello World");
            }

            // 2. Print "Hello World" if x is equal to y.
            if (x == y)
            {
                Console.WriteLine("Hello World");
            }

            // 3. Print "Yes" if x is equal to y, otherwise print "No".
            if (x == y)
            {
                Console.WriteLine("Hello World");
            }
            else
            {
                Console.WriteLine("No");
            }

            // 4. Print "1" if x is equal to y, print "2" if x is greater than y, otherwise print "3".
            if (x == y)
            {
                Console.WriteLine("1");
            }
            else if (x > y)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("3");
            }

            // 5. Insert the missing parts to complete the following "short hand if...else statement" (ternary operator):
            int time = 20;
            string result = time < 18 ? "Good day" : "Good evening";
            Console.WriteLine(result);

            /* Switch */
            // 1. Insert the missing parts to complete the following switch statement
            int day = 2;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
            }

            // 2. Complete the switch statement, and add the correct keyword at the end to specify some code to run if there is no case match in the switch statement.
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("Not a valid day");
                    break;
            }

            /* Loops */
            // 1. Print i as long as i is less than 6.
            int q = 1;
            while (q < 6)
            {
                Console.WriteLine(q);
                q++;
            }

            // 2. Use the do/while loop to print i as long as i is less than 6.
            do
            {
                Console.WriteLine(q);
                q++;
            }
            while (q < 6);

            // 3. Use a for loop to print "Yes" 5 times
            // 4. Stop the loop if i is 5.
            for (int m = 0; i < 5; m++)
            {
                if (m == 5)
                {
                    break;
                }
                Console.WriteLine("Yes");
            }

            // 5. In the following loop, when the value is "4", jump directly to the next value.
            for (int m = 0; i < 10; m++)
            {
                if (m == 4)
                {
                    continue;
                }
                Console.WriteLine(m);
            }

            /* Arrays */
            // 1. Create an array of type string called cars.
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            // 2. Print the value of the second element in the cars array.
            Console.WriteLine(cars[1]);

            // 3. Change the value from "Volvo" to "Opel", in the cars array.
            cars[0] = "Opel";

            // 4. Loop through the elements in the cars array using the foreach loop.
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            // 5. Use the correct method to sort the cars array.
            Array.Sort(cars);

            /* Methods */
            // 1. Create a method named MyMethod and call it inside Main().
            // 3. Add a fname parameter of type string to MyMethod.
            static void MyMethod(string fName)
            {
                Console.WriteLine("I got called");
                Console.WriteLine(fName + " Refsnes");
            }

            // 2.  Insert the missing parts to call MyMethod two times.
            MyMethod("Maddie");
            MyMethod("Jen");


            // 4. Insert the missing part to print the number 8 in Main, by using a specific keyword inside MyMethod:
            static int MyNewMethod(int x)
            {
                return 5 + x;
            }

            static void NewMain(string[] args)
            {
                Console.WriteLine(MyNewMethod(3));
            }
        }

        /// <summary>
        /// Defines the <see cref="MyClass" />.
        /// </summary>
        internal class MyClass
        {
            /// <summary>
            /// The Main.
            /// </summary>
            internal static void Main()
            {
            }

            /* Exceptions */
            // 1. Fill in the missing parts to output an error message if an error occurs.
            /// <summary>
            /// The HandleError.
            /// </summary>
            internal static void HandleError()
            {
                try
                {
                    int[] myNumbers = { 1, 2, 3 };
                    Console.WriteLine(myNumbers[10]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                // 2. execute some code, after the exception statements, regardless of the result.
                finally
                {
                    Console.WriteLine("The 'try catch' is finished.");
                }
            }
        }

        // 2. Create an object of MyClass called myObj.
        /// <summary>
        /// Defines the myObj.
        /// </summary>
        internal MyClass myObj = new MyClass();

        // 3.Create an object of Car called myObj, and use it to set the value of maxSpeed to 200.
        // 4. Call the fullThrottle() method from the object:
        // 5. Create a constructor of Car, and call it:
        // 6. Use an access modifier to make the model variable NOT accessible from outside its own class.
        // private string model;
        // 7. The Car class should inherit the class members from the Vehicle class. Fill in the missing part to make this possible.
        /// <summary>
        /// Defines the <see cref="Vehicle" />.
        /// </summary>
        internal class Vehicle
        {
            /// <summary>
            /// The Main.
            /// </summary>
            internal static void Main()
            {
            }
        }

        /// <summary>
        /// Defines the <see cref="Car" />.
        /// </summary>
        internal class Car : Vehicle
        {
            /// <summary>
            /// Defines the maxSpeed.
            /// </summary>
            internal int maxSpeed;

            /// <summary>
            /// Defines the color.
            /// </summary>
            internal string color;

            /// <summary>
            /// Defines the model.
            /// </summary>
            public string model;

            /// <summary>
            /// Initializes a new instance of the <see cref="Car"/> class.
            /// </summary>
            public Car()
            {
                model = "Mustang";
            }

            /// <summary>
            /// The fullThrottle.
            /// </summary>
            public void fullThrottle()
            {
                Console.WriteLine("The car is going as fast as it can!");
            }

            /// <summary>
            /// The Main.
            /// </summary>
            /// <param name="args">The args<see cref="string[]"/>.</param>
            internal static void Main(string[] args)
            {
                Car myObj = new Car();
                myObj.maxSpeed = 200;
                Console.WriteLine(myObj.color);
                Console.WriteLine(myObj.maxSpeed);

                myObj.fullThrottle();
            }
        }
    }
}
