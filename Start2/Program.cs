using System;


namespace Start2
{
    class Program
    {
        static void Sum3(int a, int b, int c)
        {
            Console.WriteLine($"summ - {a + b + c}");
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
            //n! = 1 * 2 * 3 * 4...* n
            int n = int.Parse(Console.ReadLine());
            int res = 1;
            for (int i = 1; i <= n; i = i + 1)
            {
                res = res * i;
            }
            Console.WriteLine(res);
            
            
            //Peasant peasant = new Peasant("Vasiliy", 100, 30, 5, 1, 3, 500);
            //Peasant peasant2 = new Peasant("Ivan", 100, 30, 6, 1, 3, 500);

            //peasant.InflictDamage(pesant2);
            //peasant2.ShowInfo();
            //Peasant peasant3 = new Peasant("Denis", 100, 5, 5, 1, 3, 500);
            //Peasant peasant4 = new Peasant("Panteleymon", 100, 27, 5, 1, 3, 500);

            //peasant.ShowInfo();
            //peasant4.ShowInfo();
            //peasant2.ShowInfo();

            //Max(5464, 78, 1323);
            //Sum3(132, 5, 5);

        }
    }


}

