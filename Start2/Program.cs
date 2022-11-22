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

            Warrior war1 = new Warrior("Stepan", 100);
            Warrior war2 = new Warrior("Evlampiy");
            Warrior war3 = new Warrior();
            Peasant peasant3 = new Peasant("Denis", 100, 5, 5, 1, 3, 500);
            Peasant peasant4 = new Peasant("Panteleymon", 100, 27, 5, 1, 3, 500);

            peasant3.InflictDamage(peasant4);

            Console.WriteLine(war3.minDamage);




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

