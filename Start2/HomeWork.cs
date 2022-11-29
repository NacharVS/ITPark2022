using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2
{
    internal class HomeWork
    {
        public static void ArraysOne()
        {
            int checks = 0;
            int[] GruppaStakanchikov = new int[10];

            for (int i = 0; i < GruppaStakanchikov.Length; i++)
            {
                GruppaStakanchikov[i] = new Random().Next(0, 50);
                Console.WriteLine($"Стаканчик #{i} - {GruppaStakanchikov[i]} мл.");
            }

            for (int i = 0; i < GruppaStakanchikov.Length; i++)
            {
                for (int j = 0; j < GruppaStakanchikov.Length - 1 - i; j++)
                {
                    if (GruppaStakanchikov[j] > GruppaStakanchikov[j + 1])
                    {
                        int ZapasnoiStakanchik = 0;
                        ZapasnoiStakanchik = GruppaStakanchikov[j];
                        GruppaStakanchikov[j] = GruppaStakanchikov[j + 1];
                        GruppaStakanchikov[j + 1] = ZapasnoiStakanchik;
                        
                    }
                    checks++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Отсортировано - ");

            for (int i = 0; i < GruppaStakanchikov.Length; i++)
            {
                Console.WriteLine($"Стаканчик #{i} - {GruppaStakanchikov[i]} мл.");
            }

            Console.WriteLine(checks);



            //Console.WriteLine();

            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > array[i - 1])
            //    {
            //        Console.Write($" {array[i]}");
            //    }
            //}
        }

        public static void ArraySort()
        {

        }
    }
}
