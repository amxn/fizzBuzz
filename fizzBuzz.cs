/*
 * Author: Mohammed Ameen
 * Date: 8-8-2012
 * FizzBuzz is a program which prints out a series of numbers from a set range, but substitues "Fizz" for numbers divisible by 3
 * "Buzz" for number divisible by 5, and "FizzBuzz" for numbers that are divisible by both 5 and 3.
*/
using System;

namespace FizzB
{    
    class Program
    {
        public void fizzBuzz() //fizzBuzz method which contains the fizzBuzz logic
        {
            for (int i = 1; i <= 100; i++) //for loop with a counter variable "i", which is initialized to 1 and is incremented in steps of 1 until it is greater than or equal to 100.
            {      
	
	            if(i%5 ==0 && i%3==0) // if condition checks if "i" modulus 5 and "i" modulus 3 equate to zero.
	            {
                    Console.WriteLine("FizzBuzz"); //Prints "FizzBuzz" if the number is divisible by 3 and 5.
	            }
	            else if(i%3==0)
	            {
                    Console.WriteLine("Fizz"); //Prints "Fizz" if the number is divisible by 3.
	            }
	            else if(i%5==0)
	            {
	                Console.WriteLine("Buzz"); //Prints "Buzz" if the number is divisible by 5.
	            }
	            else
	            {
	                Console.WriteLine(i); //Prints all other remaining numbers
	            }
            }

            //Console.ReadLine();
        
        }

        
        static void Main(string[] args)
        {
            Program p = new Program(); //Creating object of Class "Program".
            p.fizzBuzz(); //Calling the "fizzBuzz" method on object p.
        }
    }
}
