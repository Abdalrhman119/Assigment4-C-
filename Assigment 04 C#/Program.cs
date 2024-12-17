namespace Assigment_04_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 13 Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("enter a string: ");
            //string input = Console.ReadLine();
            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //Console.WriteLine("Reversed string: " + new string(charArray));
            #endregion
            #region 14 Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("enter an integer: ");
            //int num = int.Parse(Console.ReadLine());
            //int reversed = 0;
            //while (num != 0)
            //{
            //    int remainder = num % 10;
            //    reversed = reversed * 10 + remainder;
            //    num /= 10;
            //}
            //Console.WriteLine("Reversed integer: " + reversed);
            #endregion
            #region 15 Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Input starting number of range: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Input ending number of range: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine($"The prime numbers between {start} and {end} are:");

            //for (int i = start; i <= end; i++)
            //{
            //    if (IsPrime(i))
            //        Console.Write(i + " ");
            //}
            //static bool IsPrime(int number)
            //{
            //    if (number < 2) return false;

            //    for (int j = 2; j <= Math.Sqrt(number); j++)
            //    {
            //        if (number % j == 0)
            //            return false;
            //    }
            //    return true;
            //}
            #endregion
            #region 16 Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Enter a number to convert: ");
            //int number = int.Parse(Console.ReadLine());
            //string binary = "";

            //while (number > 0)
            //{
            //    binary = (number % 2) + binary;
            //    number /= 2;
            //}
            //Console.WriteLine("The Binary is: " + binary);
            #endregion
            #region 17 Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.Write("Enter coordinates for Point 1 (x1 y1): ");
            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter coordinates for Point 2 (x2 y2): ");
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter coordinates for Point 3 (x3 y3): ");
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());

            //if ((y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1))
            //    Console.WriteLine("The points are collinear.");
            //else
            //    Console.WriteLine("The points are not collinear.");
            #endregion
            #region 18 Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task
            //Console.Write("Enter the time taken by the worker (in hours): ");
            //double time = double.Parse(Console.ReadLine());

            //if (time >= 2 && time <= 3)
            //    Console.WriteLine("Worker is highly efficient.");
            //else if (time > 3 && time <= 4)
            //    Console.WriteLine("Worker needs to increase their speed.");
            //else if (time > 4 && time <= 5)
            //    Console.WriteLine("Worker is provided with training to enhance speed.");
            //else if (time > 5)
            //    Console.WriteLine("Worker needs to leave the company.");
            //else
            //    Console.WriteLine("Invalid input. Time should be 2 hours or more.");
            #endregion
        }
    }
}
