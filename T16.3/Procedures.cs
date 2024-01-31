using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T16._3
{
    class Procedures
    {
        /// <summary>
        /// Beginning of the first procedure
        /// </summary>
        private TimeSpan procedure_1;
        /// <summary>
        /// Beginning of the second procedure
        /// </summary>
        private TimeSpan procedure_2;
        /// <summary>
        /// Total number of procedures
        /// </summary>
        private int total_num;
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Procedures() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="procedure_1">Initializing the start time of the first procedure</param>
        /// <param name="procedure_2">Initializing the start time of the second procedure</param>
        /// <param name="total_num">Initializing the total number of procedures</param>
        public Procedures(TimeSpan procedure_1, TimeSpan procedure_2, int total_num)
        {
            this.procedure_1 = procedure_1; this.procedure_2 = procedure_2; this.total_num = total_num;
        }
        /// <summary>
        /// Time of medical procedures
        /// </summary>
        public void Output()
        {
            WriteLine("Time of medical procedures: ");

            TimeSpan delta = procedure_2 - procedure_1;
            TimeSpan time = procedure_1;

            for(int i = 0; i < total_num; i++)
            {
                WriteLine($"Procedure n.{i+1}: {time:hh\\:mm}");
                time += delta;
            }
        }
    }
}
