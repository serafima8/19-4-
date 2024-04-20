using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1__КП_4_
{
    class TravelAgency : IComparable<TravelAgency>
    {
        /// <summary>
        /// Создание поля Название
        /// </summary>
        private string name;
        /// <summary>
        /// Создвание поля Год создания 
        /// </summary>
        private int year;
        /// <summary>
        /// Создание поля ИНН
        /// </summary>
        private string inn;
        /// <summary>
        /// Создание поля Прибыль за текущий год
        /// </summary>
        private double profit;
        /// <summary>
        /// Свойство Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Свойство Год создания
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Свойство ИНН
        /// </summary>
        public string Inn { get; set; }
        /// <summary>
        /// Свойство Прибыль за текущий год
        /// </summary>
        public double Profit { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public TravelAgency() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="year"></param>
        /// <param name="inn"></param>
        /// <param name="profit"></param>
        public TravelAgency(string name, int year, string inn, double profit)
        {
            this.Name = name;
            this.Year = year;
            this.Inn = inn;
            this.Profit = profit;
        }
        /// <summary>
        /// Метод для получения информации о фирме 
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Название: {Name}\nГод создания: {Year}\nИНН: {Inn}\nПрибыль за текущий год: {Profit}");
        }
        /// <summary>
        /// Метод для сортировки информации туристических фирмах города, по размеру прибыли за текущий год.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(TravelAgency obj)
        {
            return Profit.CompareTo(obj.Profit);
        }
    }
}
