using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello1
{
    class Program
    {
        //Methods
        static void Greet(string name)
        {
            Console.WriteLine("Good morning" +  name);
        }
        // Method overloading
        static int Inticheck(int a, int b) {
            return a + b;
        }
        static int Inticheck(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {

            // Single line comment
            /* Multiline comment
             * starts
             * ends
             */

            /* Variables and datatypes and its size
             
             * integer - int goutham = 22; -> 4 bytes
             * long - size -> 8 bytes
             * floating point number - float f1 = 2F; -> 4 bytes
             * double - double a = 5.99D; -> 8 bytes
             * char letter = 'D'; -> 2 bytes
             * string mytext = "hello"; -> 2 bytes
             * boolean - bool isTrue = true; -> needs 1 bit stores 1 byte
             
             */

            //Console.WriteLine("Hello world"); // printing statements
            //Console.Write("Hi how are you");
            //Console.WriteLine("Hello world 2");
            //int goutham = 22;  // Variables and datatypes
            //double a = 5.99D;
            //float f1 = 2F;
            //char letter = 'D';
            //string mytext = "hello";
            //bool isTrue = true;
            //string input = Console.ReadLine(); // taking input from user
            //Console.WriteLine(f1);
            //Console.WriteLine(goutham);
            //Console.WriteLine(a);
            //Console.WriteLine(letter);
            //Console.WriteLine(mytext);
            //Console.WriteLine(isTrue);
            //Console.WriteLine(input); // printing the input from user

            //int a = 34;
            //float b = 34.4F;
            //double c = 34.4D;
            //char d = 'g';
            //string e = "gmp";
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);

            //Type Casting
            //There are two types of type casting:
            //1. Implicit casting

            //  char to int to long to float to double

            //char typ = 'r';
            //int typ1 = typ;
            //Console.WriteLine(typ1); //ascii value of r will be given
            //long typ2 = typ1;
            //Console.WriteLine(typ2);
            //float typ3 = typ2;
            //Console.WriteLine(typ3);
            //double typ4 = typ3;
            //Console.WriteLine(typ4);


            //2. Explicit Casting

            //    int x = (int) 3.7;


            //Type Casting using different methods.

            //char typ = (char)Convert.ToInt32('r');
            //long typ1 = Convert.ToChar(114);
            //float typ2 = Convert.ToInt32(3.55);
            //double typ3 = Convert.ToInt64(114);
            //int typ4 = 32;
            //string typ5 = typ4.ToString();
            //Console.WriteLine(typ);
            //Console.WriteLine(typ1);
            //Console.WriteLine(typ2);
            //Console.WriteLine(typ3);
            //Console.WriteLine(typ5);

            // Understanding inputs

            //Console.WriteLine("Enter your name please: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi my name is " + name); // Concatination
            //Console.WriteLine("Enter your anything here : ");
            //string any = Console.ReadLine();
            //Console.WriteLine("Hi my name is " + name + " You will get 4 extra anyways " + (Convert.ToInt32(any) + 4));

            // Operators in C#

            //1. Arithmetic operators.

            //int a = 5;
            //int b = 4;
            //Console.WriteLine("The value of "  + a +  "+"  + b +  " is " + (a + b));
            //Console.WriteLine("The value of "  + a +  "-"  + b +  " is " + (a - b));
            //Console.WriteLine("The value of "  + a +  "*"  + b +  " is " + (a * b));
            //Console.WriteLine("The value of "  + a +  "/"  + b +  " is " + (a / b));


            //2. Assignment operators.

            //int a1 = 5;
            //int b1 = a1;
            //int c1 = b1;
            //int d1 = c1;
            //int e1 = d1;
            //b1 += 4;
            //c1 -= 4;
            //d1 *= 4;
            //e1 /= 4;

            //Console.WriteLine("The value of addition is " + b1);
            //Console.WriteLine("The value of subtraction is " + c1);
            //Console.WriteLine("The value of multiplication is " + d1);
            //Console.WriteLine("The value of division is " + e1);


            //3. Logical operators.

            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);
            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);
            //Console.WriteLine(!false);
            //Console.WriteLine(!true);


            //4. Comparision operators.

            //int a = 5;
            //int b = 10;
            //Console.WriteLine(a > b);
            //Console.WriteLine(a >= b);
            //Console.WriteLine(a < b);
            //Console.WriteLine(a <= b);
            //Console.WriteLine(a != b);
            //Console.WriteLine(a == b);

            //5. Bitwise operators

            //1. AND 

            //int a = 5;
            //int b = 3;

            //int result = a & b;

            //Console.WriteLine(result);

            //2. OR

            //int a1 = 6;
            //int b1 = 7;

            //int result1 = a1 | b1;
            //Console.WriteLine(result1);

            //3. XOR

            //int a2 = 5;
            //int b2 = 6;

            //int result2 = a2 ^ b2;
            //Console.WriteLine(result2);

            //4. NOT

            //int a3 = 5;
            //int result3 = ~a3;

            //Console.WriteLine(result3);

            //5. Left Shift

            //int a4 = 7;

            //Console.WriteLine(a4 << 1);

            //6. Right Shift

            //int a5 = 8;

            //Console.WriteLine(a5 >> 1);

            // Using Math in C#

            //int a = Math.Max(34, 35);
            //double b = Math.Sqrt(36);
            //int c = Math.Abs(-35);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //String methods

            //string name = "CristianoRonaldo";
            //Console.WriteLine(name.Length);
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());
            //Console.WriteLine("Hi my name is " + name); // Concatination
            //Console.WriteLine(string.Concat("Hi my name is", name));

            //String formatting

            //string name = Console.ReadLine();
            //string role = Console.ReadLine();
            //Console.WriteLine($"Hi my name is {name} and my role is {role}");

            // Indexing

            //string hello = "Hi this is my youtube channel";
            //Console.WriteLine(hello[1]);
            //Console.WriteLine(hello.IndexOf("this"));
            //Console.WriteLine(hello.Substring(5));

            // Escape sequence

            //string hello = "Hi this is my \" youtube channel";
            //string hello = "Hi this is my \n youtube channel";
            //string hello = "Hi this is my \t youtube channel";
            //Console.WriteLine(hello);

            // Conditional statements

            //Console.WriteLine("Enter your name here buddy");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter you age here buddy");
            //string agestr = Console.ReadLine();
            //int age = Convert.ToInt32(agestr);

            //if (age > 18 | age == 18) {
            //    Console.WriteLine("You can vote");
            //}
            //else if (age < 18)
            //{
            //    Console.WriteLine("You cannot vote");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            //switch (age)
            //{
            //    case 18:
            //        Console.WriteLine("You are eligible to vote");
            //        break;
            //    case 20:
            //        Console.WriteLine("You are 20 years old now");
            //        break;
            //    default:
            //        Console.WriteLine("Dont forget to vote guys.");
            //        break;
            //}


            // LOOPS in C#

            //While loops

            //int i = 0;
            //while(i<10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            // Do while

            //do
            //{
            //    Console.WriteLine(i); // wether the condition is true or false it will run atleast once.
            //    i++;
            //} while (i > 5);

            //For loops with break and continue
            //for (int i=1 ; i < 5 ; i++)
            //{
            //    if (i == 0)
            //    {
            //continue; // Go to the next iteration
            //}
            //Console.WriteLine(i);
            //break; // Exit the loop
            //}

            //Greet(); =  Methods

            Greet("Goutham");
            Greet("Umesh");
            Console.WriteLine(Inticheck(5,9));
            Console.WriteLine(Inticheck(7, 6, 7)); // method overloading (same function name different parameters)
            Console.ReadLine();
            
          
        }
    }
}
