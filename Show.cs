using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Theatre
{
    enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat }
    class Show
    {
        public double Price { get; private set; }
        public Day Day { get; private set; }
        public Movie Movie { get; private set; }
        public Time Time { get; private set; }

        public Show(Movie movie, Day day, double price, Time time)
        {
            Movie = movie;
            Day = day;
            Price = price;
            Time = time;
        }

        public override string ToString()
        {
            return $"*** Movie ***\n{Movie}\nDay: {Day}\nPrice: {Price:C}\nTime: {Time}\n";
        }

    }
}
