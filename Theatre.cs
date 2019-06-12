using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Theatre
{
    class Theatre
    {
        List<Show> shows;
        public static string Name { get; private set; }

        public Theatre(string name)
        {
            Name = name;
            shows = new List<Show>();
        }

        public void AddShow(Show show)
        {
            shows.Add(show);
        }

        public void PrintShows()
        {
            Console.WriteLine($"Theatre Name: {Name}");
             Console.WriteLine($"All Shows: ");
            int i = 1;
            foreach (Show show in shows)
            {
                Console.WriteLine($"{i++}.");
                Console.WriteLine(show);
            }
        }

        public void PrintShows(Genre genre)
        {
            Console.WriteLine($"Theatre Name: {Name}");
            Console.WriteLine($"All Shows with the genre: {genre}");
            int i = 1;
            foreach (Show show in shows)
            {
                if (show.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine($"{i++}.");
                    Console.WriteLine(show);
                }
            }
        }

        public void PrintShows(string actor)
        {
            Console.WriteLine($"Theatre Name: {Name}");
            Console.WriteLine($"All Shows with the following actors: {actor}");
            int i = 1;
            foreach (Show show in shows)
            {
                if (show.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine($"{i++}.");
                    Console.WriteLine(show);
                }
            }
        }

        public void PrintShows(Day day)
        {
            Console.WriteLine($"Theatre Name: {Name}");
            Console.WriteLine($"All shows on this day: {day}");
            int i = 1;
            foreach (Show show in shows)
            {
                if (show.Day.Equals(day))
                {
                    Console.WriteLine($"{i++}.");
                    Console.WriteLine(show);
                }
            }
        }

        public void PrintShows(Time time)
        {
            Console.WriteLine($"Theatre Name: {Name}");
            Console.WriteLine($"All Shows on this time: {time}");
            int i = 1;
            foreach (Show show in shows)
            {
                if (show.Time == time)
                {
                    Console.WriteLine($"{i++}.");
                    Console.WriteLine(show);
                }
                else if (show.Time != time)
                {
                    //Console.WriteLine(show);
                }
            }
        }

        public void PrintShows(Day day, Time time)
        {
            Console.WriteLine($"Theatre Name: {Name}");
            Console.WriteLine($"All Shows with this day and time: {day} , {time}");
            int i = 1;
            foreach (Show show in shows)
            {
                if (show.Time == time && show.Day == day)
                {
                    Console.WriteLine($"{i++}.");
                    Console.WriteLine(show);
                }
                else if (show.Time != time)
                {
                    //Console.WriteLine(show);
                }
            }
        }
    }
}
