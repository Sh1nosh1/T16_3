using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace T16._3
{
    class DateClass
    {
        /// <summary>
        /// Date field
        /// </summary>
        private DateTime data;
        /// <summary>
        /// Field of the year
        /// </summary>
        public int year;
        /// <summary>
        /// Field of the month
        /// </summary>
        public int month;
        /// <summary>
        /// Field of the day
        /// </summary>
        public int day;
        /// <summary>
        /// Constr. without parameters
        /// </summary>
        public DateClass() { }
        /// <summary>
        /// Constr. with parameters
        /// </summary>
        /// <param name="data">Initializing the date</param>
        public DateClass(int year, int month, int day)
        {
            //this.year = year; this.month = month; this.day = day;
            data = new DateTime(year, month, day);

        }
        /// <summary>
        /// Property that allows you to set or get the value of a class field
        /// </summary>
        public DateTime Data { get => data; set => data = value; }
        /// <summary>
        /// Backdate
        /// </summary>
        /// <returns>Дата предыдущего дня</returns>
        public DateTime Yesterday()
        {
            return data.AddDays(-1);
        }
        /// <summary>
        /// Calculate the next day's date
        /// </summary>
        /// <returns>Дата следующего дня</returns>
        public DateTime Tomorrow()
        {
            return data.AddDays(1);
        }
        /// <summary>
        /// To determine how many days are left until the end of the month.
        /// </summary>
        /// <returns>Number of days remaining until the end of the month</returns>
        public int Residue()
        {
            return DateTime.DaysInMonth(data.Year, data.Month) - data.Day;
        }
        /// <summary>
        /// Output
        /// </summary>
        /// <returns>Date</returns>
        public DateTime Output()
        {
            return data;
        }

    }
}
