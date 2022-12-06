using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2
{
    internal class ListWork
    {

        public static void MultiAddition() // множественное добавление и множественная вставка
        {
            List<string> strings = new List<string>();
            List<string> names = new List<string>();

            strings.Add("qqqqqqqq");
            strings.Add("wwwwwwww");
            strings.Add("eeeeeeee");
            strings.Add("tttttttt");

            names.Add("Vadim");
            names.Add("Aidar");
            names.Add("Aleksey");
            names.Insert(0, "Ivan");

            Console.WriteLine("Random Strings:");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Names:");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");

            // strings.AddRange(names); - добавляет список names в конец списка strings

            strings.InsertRange(2, names); // вставляет список names со 2 индекса

            Console.WriteLine("Unided List:");
            foreach(var item in strings)
            {
                Console.WriteLine(item);
            }
        }


        public static void ListChecking() // проверка сожержимого спискаХ
        {
            List<string> names = new List<string>();
            names.Add("Vadim");
            names.Add("Aidar");
            names.Add("Aleksey");
            names.Insert(0, "Ivan");


            int a = names.IndexOf("Aidar"); // находит индекс элемента Aidar

  

            names[a] = "Boris";

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            //if (names.Contains("Ivan")) // если список names содержит строку Ivan - то будет true
            //{
            //    Console.WriteLine("Есть такой");
            //}
            //else
            //{
            //    Console.WriteLine("Нет такого");
            //}
        }

        public static void DeleteFromList() // удачление из списка
        {
            List<string> names = new List<string>();
            names.Add("Vadim");          
            names.Add("Aidar");
            names.Add("Ivan");
            names.Add("Aleksey");
            names.Add("Ivan");
            names.Add("Aleksey");
            names.Insert(0, "Ivan");

            // names.Remove("Ivan");// удалит первый элемент который совпал с параметром, в данном случае Ivan
            //  names.RemoveAll(x => x == "Ivan"); удалит любое упоминание о Ivan
            names.RemoveAt(2); // удаляет элемент по индексу, в данном случае индекс  2

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
