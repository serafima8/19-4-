using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1__КП_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Создать коллекцию объектов класса «Туристическая фирма», содержащую информацию о туристических фирмах города.
           List<TravelAgency> travel = new List<TravelAgency>();
            travel.Add(new TravelAgency("Фирма 1", 2001, "F24V", 25000));
            travel.Add(new TravelAgency("Фирма 2", 2010, "U78F", 48000));
            travel.Add(new TravelAgency("Фирма 3", 1998, "JUY8", 38500));
            travel.Add(new TravelAgency("Фирма 4", 2007, "H755", 31000));
            travel.Add(new TravelAgency("Фирма 5", 2002, "G7DL", 55000));

            //3. Для заданной фирмы найти ИНН и прибыль за текущий год.
            Console.Write("Введите название фирмы: ");
            string name = Console.ReadLine();
            bool not_find = false;
            for (int i = 0; i < travel.Count; i++)
            {
                if (travel[i].Name == name)
                {

                    Console.WriteLine($"ИНН: {travel[i].Inn}; Прибыль: {travel[i].Profit}");
                    not_find = true;

                }
                if (not_find == false)
                {
                    Console.WriteLine("Фирма не найдена");
                }
            }

            //4. Нахождение суммарной прибыли всех фирм
            double totalProfit = 0;
            foreach(var elem in travel)
            {
                totalProfit += elem.Profit; 
            }
            Console.WriteLine($"Суммарная прибыль всех фирм: {totalProfit}");

            //5. Выяснить, какая из фирм получила наибольшую прибыль и каков размер этой прибыли.
            TravelAgency profit = null;
            double maxProfit = double.MinValue;
            foreach (var elem in travel)
            {
                if (elem.Profit > maxProfit)
                {
                    maxProfit = elem.Profit;
                    profit = elem;
                }
            }
            if (profit != null)
            {
                Console.WriteLine($"Фирма с наибольшей прибылью: {profit.Name}, Прибыль: {profit.Profit}");
            }
            else
            {
                Console.WriteLine("Фирмы не найдены.");
            }

            //6. Удалить из коллекции информацию об обанкротившейся фирме.
            Console.Write("Введите название обанкротившейся фирмы: ");
            string bankrupt = Console.ReadLine();
            bool removed = false;
            for (int i = 0; i < travel.Count; i++)
            {
                if (travel[i].Name == bankrupt)
                {
                    travel.RemoveAt(i);
                    removed = true;
                }
            }
            if (removed)
            {
                Console.WriteLine($"{bankrupt} удалена.");
            }
            else
            {
                Console.WriteLine($"{bankrupt} не найдена.");
            }
            //7.Добавить в коллекцию информацию о новой фирме.
            travel.Add(new TravelAgency("Фирма 6", 2000, "A55GF", 33000));
            Console.WriteLine("Добавлена новая фирма.");

            //8. Отсортировать коллекцию, содержащую информацию о туристических фирмах города, по размеру прибыли за текущий год.
            Console.WriteLine("\nОтсортированная коллекция по размеру прибыли за текущий год: ");
            travel.Sort();
            foreach(TravelAgency elem in travel)
            {
                Console.WriteLine($"{elem.Name} {elem.Year} {elem.Inn} {elem.Profit}");
            }
            Console.ReadKey();
        }
    }
}
