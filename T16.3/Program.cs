using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T16._3
{
    internal class Program
    {
            static DateTime Input(string input)
            {
                WriteLine($"Enter {input} date: ");
                Write("Day: ");
                int day = Convert.ToInt32(ReadLine());
                Write("Month: ");
                int month = Convert.ToInt32(ReadLine());
                Write("Year: ");
                int year = Convert.ToInt32(ReadLine());
                return new DateTime(year, month, day);
            }
            static void Main(string[] args)
            {
                try
                {
                    //Task 1

                    /*WriteLine($"Enter date: ");
                    Write("Day: ");
                    int day = Convert.ToInt32(ReadLine());
                    Write("Month: ");
                    int month = Convert.ToInt32(ReadLine());
                    Write("Year: ");
                    int year = Convert.ToInt32(ReadLine());

                    DateClass date1 = new DateClass(year, month, day);
                    Write($"{date1.Output().ToString("d")}\nPrevious day: {date1.Yesterday().ToString("d")}\nNext day: {date1.Tomorrow().ToString("d")}\nNumber of days to the end of the month: {date1.Residue()}");*/


                    //Task 2.
                    //Enter two dates and determine the number of days between them.

                    /*DateTime date_1 = Input("first");
                    DateTime date_2 = Input("second");
                    TimeSpan delta = date_1 - date_2;
                    WriteLine($"First date: {date_1.ToShortDateString()}\nSecond date: {date_2.ToShortDateString()}\nNumber of days between: {delta.Days}");*/


                    //Task 3
                    //Calculate the time of medical procedures. In the program implement the input of values: the time of the first procedure start,
                    //the time of the next procedure start and the total number of assigned procedures.
                    //The program should output a list of times by which the assigned procedures should be performed.
                    //In the calculations, assume that the time between all procedures is the same.

                    Write($"Enter the start time of the first procedure: ");
                    TimeSpan procedure_1 = TimeSpan.Parse(ReadLine());
                    Write($"Enter the start time of the second procedure: ");
                    TimeSpan procedure_2 = TimeSpan.Parse(ReadLine());
                    Write($"Enter the total number of procedures: ");
                    int total_num = Convert.ToInt32(ReadLine());

                    Procedures procedures = new Procedures(procedure_1, procedure_2, total_num);
                    procedures.Output();
            }
            catch (Exception ex)
                {
                    WriteLine($"Исключение: {ex.Message}");
                    WriteLine($"Метод: {ex.TargetSite}");
                    WriteLine($"Трассировка стека: {ex.StackTrace}");
                }
                ReadKey();
        }
    }
}
