using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello1
{
    class Program
    {
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

            char typ = (char)Convert.ToInt32('r');
            long typ1 = Convert.ToChar(114);
            float typ2 = Convert.ToInt32(3.55);
            double typ3 = Convert.ToInt64(114);
            int typ4 = 32;
            string typ5 = typ4.ToString();
            Console.WriteLine(typ);
            Console.WriteLine(typ1);
            Console.WriteLine(typ2);
            Console.WriteLine(typ3);
            Console.WriteLine(typ5);



            Console.ReadLine();
        }
    }
}
