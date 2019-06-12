using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Theatre
{
    [Flags]
    enum Genre
    {
        Unrated = 0,
        Action = 1,
        Romance = 2,
        Documentary = 4,
        Mystery = 8,
        Musical = 16,
        Horror = 32,
        Comedy = 64,
        Fantasy = 128,
        Animation = 256,
        Adventure = 512
    };
    class Movie
    {
       public int Length { get; private set; }
       public int Year { get; private set; }
       public string Title { get; private set; }
       public Genre Genre { get; private set; }
       public List<string> Cast { get; private set; }

       public Movie(string title, int year, int length)
       {
                Title = title;
                Year = year;
                Length = length;
                Cast = new List<string>();
       }

       public void AddActor(string actor)
       {
                Cast.Add(actor);
       }

       public void SetGenre(Genre genre)
       {
                Genre = genre;
       }

       public override string ToString()
       {
          string castName = string.Empty;
          foreach (string casts in Cast)
          {
              castName = castName + "|" + casts;
          }

          return $"Title: {Title}\nGenre: {Genre}\nCast Members:{castName}";
       }
    }
}
