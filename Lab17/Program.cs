using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ЗАДАНИЕ 17. ОБОБЩЕННЫЕ ТИПЫ (GENERICS)
            Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
            Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета.
            Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
            Создать несколько экземпляров класса, параметризированного различными типами.
            Заполнить его поля и вывести информацию об экземпляре класса на печать.
            */
            Console.WriteLine("Пожалуйста, выберите тип номера счёта\nНажмите клавишу <Enter> - если номер счета цифровой\nНажмите любую клавишу - если номер счета буквенно-цифровой");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Введите данные банковского счёта\n");
                Console.WriteLine("Введите номер счета, до 15 знаков:");
                long accNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Введите баланс:");
                decimal balance = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Введите ФИО владельца:");
                string owner = Convert.ToString(Console.ReadLine());
                Account<long> accInt = new Account<long>(accNumber, balance, owner);
                Print<long>(accNumber, balance, owner);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Введите данные банковского счёта\n");
                Console.WriteLine("Введите номер счета:");
                string accNumber = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите баланс:");
                decimal balance = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Введите ФИО владельца:");
                string owner = Convert.ToString(Console.ReadLine());
                Account<string> accInt = new Account<string>(accNumber, balance, owner);
                Print<string>(accNumber, balance, owner);
            }
            Console.ReadKey();
        }
        static void Print<T>(T accNumber, decimal balance, string owner)
        {
            Console.Clear();
            Console.WriteLine($"Добрый день {owner}, на вашем счету №{accNumber}: {balance} руб");
        }
    }
    class Account<T>
    {
        private T AccNumber { get; set; }
        private decimal Balance { get; set; }
        private string Owner { get; set; }
        public Account(T accNumber, decimal balance, string owner)
        {
            AccNumber = accNumber;
            Balance = balance;
            Owner = owner;
        }
    }
}
