using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true){
                //determines a few variables
                bool valid = false;
                bool equilateral = false;
                bool isosceles = false;
                bool scalene = false;

                //welcome message
                Console.WriteLine("Welcome to the valid triangle tester!");

                //user input side a
                Console.WriteLine("please enter the length of side A");
                string aLengthString = Console.ReadLine();
                double aLength = Convert.ToInt32(aLengthString);

                //user input side b
                Console.WriteLine("please enter the length of side B");
                string bLengthString = Console.ReadLine();
                double bLength = Convert.ToInt32(bLengthString);

                // user input side c
                Console.WriteLine("please enter the length of side C");
                string cLengthString = Console.ReadLine();
                double cLength = Convert.ToInt32(cLengthString);

                //checks if triangle is valid
                if (aLength + bLength > cLength)
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                }

                if (aLength + cLength > bLength)
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                }

                if (bLength + cLength > aLength)
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                }

                //checks if the triangle is equilateral
                if (aLength == bLength && cLength == bLength)
                {
                    equilateral = true;
                }
                //checks if the triangle is an isosceles
                if (aLength == bLength && cLength != aLength)
                {
                    isosceles = true;
                }

                if (bLength == cLength && cLength != aLength)
                {
                    isosceles = true;
                }

                if (aLength == cLength && cLength != bLength)
                {
                    isosceles = true;
                }
                //checks if triangle is scalene
                if (aLength != bLength && bLength != cLength && cLength != aLength)
                {
                    scalene = true;
                }

                //Checks if the triangle is true and also checks the type and displays both 
                if (valid = true && equilateral == true)
                {
                    Console.WriteLine("This triangle is valid and it is an equilateral triangle");
                }

                if (valid = true && isosceles == true)
                {
                    Console.WriteLine("This triangle is valid and it is an isosceles triangle");
                }

                if (valid = true && scalene == true)
                {
                    Console.WriteLine("This triangle is valid and it is a scalene triangle");
                }
                //if the triangle is not valid the user is informed
                if (valid == false)
                {
                    Console.WriteLine("This is not a valid triangle");
                }

                Console.WriteLine("Press enter to calcute another triangle:"); 
                Console.ReadLine();
                //clears the console
                Console.Clear();    
               

             
            }


        }
    }   
}
