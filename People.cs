using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class People : All
    {
        public int name;
        public People(int a)
        {
            name = a;
        }

        public void GetInfo()
        {
            Console.Write($"Имя {name}\n");
        }
    }
}
