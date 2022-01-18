using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Movie : Info
    {
        public Movie(int a, int b, int c, int d) : base(a)
        {
            film = b;
            score = c;
            genre = d;
        }
        public override void GetInfo()
        {
           Console.Write($"Название фильма {film}, Оценка {score}, Жанр {genre}\n");
           
        }
    }
}
