namespace Loops
{
    internal class Program
    {
        static void Main()
        {
            // Task 1: For Loop
            // Write a program that uses a for loop to print numbers from 1 to 10.
            // Expected output
            // 1 2 3 4 5 6 7 8 9 10
            Console.WriteLine("Task 1: For Loop");
            // Write your code below

            for (int number = 1; number <= 10; ++number)
            { 
                Console.Write(number + " "); 
            }

   // Task 2: While Loop
    // Write a program that uses a while loop to print even numbers between 1 and 20.
    // Expected output
    // 2 4 6 8 10 12 14 16 18 20
    Console.WriteLine("\nTask 2: While Loop");
            // Write your code below     
           
            int number = 2;
            
            while (number <= 20);
            {
                Console.Write(number + " ");
                number += 2;
            }

            // Task 3: Do-While Loop
            // Write a program that uses a do-while loop to reverse the characters of a given string.
            // Expected output
            // POOL
            Console.WriteLine("Task 3: Do-While Loop");
            string input = "LOOP";
            string reversed = "";
            int k = input.Length - 1;
            // Write your code below
            
            do
            {
                reversed += input[k];
                k--;
            } 
            while (k >= 0);
            { 
                Console.WriteLine(reversed);
            }

    // Task 4: Foreach Loop
    // Use a foreach loop to print each fruit on a separate line.
    // Expected output
    // Apple
    // Banana
    // Cherry
    // Date
    // Fig
    Console.WriteLine("Task 4: Foreach Loop");
            List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry", "Date", "Fig" };
            // Write your code below

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

    // Task 5: Nested Loops
    // Use nested for loops to print a pattern of asterisks that forms a square.
    // Expected output
    // *****
    // *****
    // *****
    // *****
    // *****

    Console.WriteLine("Task 5: Nested Loops");
            // Write your code below
            int size = 5;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("* ");
            }
                Console.WriteLine();
        }

    // Task 6: Loop Control Statements
    // Write a program that uses a for loop to print numbers from 1 to 100.
    // However, for multiples of three, print "Fizz" instead of the number, and for the multiples of five, print "Buzz".
    // For numbers which are multiples of both three and five, print "FizzBuzz".
    // Expected output
    // 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16...
    Console.WriteLine("Task 6: Loop Control Statements");
            // Write your code below
    
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FizzBuzz ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Buzz ");
            }
            else
            {
                Console.Write(i + " ");
            }
        }

        }
    }
}