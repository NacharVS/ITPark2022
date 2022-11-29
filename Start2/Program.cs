using System;


namespace Start2
{
    class Program
    {
        static void Sum()
        {
            Console.WriteLine("Не передали аргументы");
        }

        static void Sum(int a)
        {
            Console.WriteLine(a);
        }

        static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Sum(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        static void Max(int a, int b, int c)
        {
            if(a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                if(b > c)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
        }

        //static void MultiplyTable()
        //{
        //    for (int i = 1; i < 10; i++)
        //    {
        //        for (int j = 1; j < 10; j++)
        //        {
        //            Console.WriteLine($"{i} * {j} = {i * j}");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        static void Main()
        {
            HomeWork.ArraysOne();
            
            //int[] array = new int[20];
            //Random random = new Random();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(1, 1000);

            //}

            //foreach (var item in array)
            //{
            //    Console.Write($"{item} ");
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 7 == 0)
            //    {
            //        array[i] = 0;
            //    }
            //}
            //Console.WriteLine();
            //foreach (var item in array)
            //{
            //    Console.Write($"{item} ");
            //}




















            //for (int i = 0; i < 3; i++)
            //{
            //    peasant.InflictDamage(peasant2);
            //    peasant2.ShowInfo();
            //}


            //peasant.ShowInfo();
            //peasant4.ShowInfo();
            //peasant2.ShowInfo();

            //Max(5464, 78, 1323);
            //Sum3(132, 5, 5);

        }
    }


}

