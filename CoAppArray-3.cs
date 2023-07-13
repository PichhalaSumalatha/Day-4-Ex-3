using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppArray_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] studMarks = new string[5, 5]
            {
            {"Roll No", "Sem1", "Sem2", "Sem3", "Sem4"},
            {"1", "85", "90", "78", "92"},
            {"2", "92", "88", "95", "90"},
            {"3", "78", "86", "80", "85"},
            {"4", "90", "92", "88", "95"}
            };

            // Print the array headers
            for (int j = 0; j < 5; j++)
            {
                Console.Write(studMarks[0, j] + "\t");
            }
            Console.WriteLine("Total");

            // Print student details and total marks
            for (int i = 1; i < 5; i++)
            {
                int totalMarks = 0;
                for (int j = 1; j < 5; j++)
                {
                    Console.Write(studMarks[i, j] + "\t");
                    totalMarks += Convert.ToInt32(studMarks[i, j]);
                }
                Console.Write(totalMarks);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

}   
