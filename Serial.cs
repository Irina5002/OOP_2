using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Serial : Info
    {
        public Serial(int a, int b, int c, int d, int e) : base(a)
        {
            film = b;
            score = c;
            genre = d;
            series = e;
        }
        public override void GetInfo()
        {
            Console.Write ($"Название сериала {film}, Оценка {score}, Жанр {genre}, Количество серий {series}\n");
        }
    }
}
