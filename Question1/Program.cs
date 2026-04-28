using System;
using System.Globalization;

namespace StudentResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine() ?? string.Empty;

            double[] marks = new double[3];

            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    Console.Write($"Enter mark for Subject {i + 1}: ");
                    string input = Console.ReadLine() ?? string.Empty;

                    if (double.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out marks[i]))
                        break;

                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }

            double total = marks[0] + marks[1] + marks[2];
            double average = total / 3.0;
            string result = average >= 50 ? "PASS" : "FAIL";
            string issuedAt = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");

            Console.WriteLine();
            Console.WriteLine("===== STUDENT RESULTS =====");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {average:N1}");
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Result Issued At: {issuedAt}");
            Console.WriteLine();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
