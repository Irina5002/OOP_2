using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum = 0; //сумма всех оценок
            float count = 0; //количество оценок
            float sr; //средняя оценка
            int max = 0; //максимальная оценка
            int min = 0; //минимальная оценка
            int num; //для проверки жанра
            int pr = 0; //для второй проверки жанра
            int see = 0; //количество просмотров определенного жанра
            float sc = 0; //средняя оценка по жанрам
            string concl = ""; //вывод по жанрам

            Info[] watch = new Info[]
            {
                new Movie(0, 1, 5, 1),
                new Movie(1, 5, 3, 1),
                new Movie(2, 17, 4, 2),
                new Movie(3, 31, 3, 4),
                new Serial(0, 22, 5, 1, 10),
                new Serial(1, 14, 3, 1, 20),
                new Serial(2, 21, 4, 2, 30),
                new Serial(3, 7, 5, 4, 25),
            };

            All[] inform = new All[]
            {
                new Movie(0, 1, 5, 1),
                new Movie(1, 5, 3, 1),
                new Movie(2, 17, 4, 2),
                new Movie(3, 31, 3, 4),
                new Serial(0, 22, 5, 1, 10),
                new Serial(1, 14, 3, 1, 20),
                new Serial(2, 21, 4, 2, 30),
                new Serial(3, 7, 5, 4, 25),
                new People(1),
                new People(2),
                new People(5),
                new People(6),
            };

            //foreach(Info i in watch)
            //{
            //    i.GetInfo();
            //}

            foreach(All i in inform)
            {
                i.GetInfo();
            }

            for (int i = 0; i < watch.Length; i++)
            {
                sum += watch[i].score;
                count = i + 1;

                if (watch[i].score > max)
                {
                    max = watch[i].score;
                    min = max;
                }

                if (watch[i].score < min)
                {
                    min = watch[i].score;
                }
            }

            sr = sum / count;

            Console.WriteLine($"\nСредняя оценка: {sr}");
            Console.WriteLine($"Максимальная оценка: {max}");
            Console.WriteLine($"Минимальная оценка: {min}");

            Console.WriteLine("\nИнформация по жанрам:");
            for (int i = 0; i < watch.Length; i++)
            {
                num = watch[i].genre;

                for (int j = 0; j < watch.Length; j++)
                {
                    if ((num == watch[j].genre) && (watch[j].genre != 0))
                    {
                        sc += watch[j].score;
                        watch[j].genre = 0;
                        see++;
                        pr = 1;
                    }
 
                }

                if (pr == 1)
                {
                    sc = sc / see;
                    concl += "\n";
                    concl += "Жанр " + num + " просмотренно " + see + ", средняя оценка " + sc;
                }

                pr = 0;
                see = 0;
                sc = 0;

            }

            Console.WriteLine(concl);
     
        }
    }
}
    


