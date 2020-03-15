using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void print_menu()
        {
            Console.WriteLine("Привет! Это симуляция работы барбершопа");
            Console.WriteLine("Есть такие функции:");
            Console.WriteLine("Добавить клиента - введите add_customer name last_name");
            Console.WriteLine("Добавить услгу - введите add_service name price");
            Console.WriteLine("Вывести инфориацию о Барбершопе - введите print_all");
            Console.WriteLine("Выйти - введите qite");
        }
        public static void add_customer(string[] user_input_array)
        {
            if (user_input_array.Length < 3)
            {    Console.WriteLine("для добавления клиента необходимо имя и фамилия!!!");
                 return;
            }
            if (Barbershop.add_customer(user_input_array[1], user_input_array[2]))
            {
                Console.WriteLine("Клиент добавлен!");
            }
            else
            {
                Console.WriteLine("Клиент не был добавлен:(");
            }
        }
        public static void add_service(string[] user_input_array)
        {
            if (user_input_array.Length < 3)
            {
                Console.WriteLine("для добавления услуги необходимо название и цена!!!");
                return;
            }
            int price = 0;
            try
            {
                price = Convert.ToInt32(user_input_array[2]);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Цена должна быть целым положительным числом ");
                return;
            }
            if(price < 0)
            {
                Console.WriteLine("Цена должна быьб целым положительным числом");
                return;
            }
            if (Barbershop.add_service(user_input_array[1], price))
            {
                Console.WriteLine("Услуга успешно добавлена добавлен!");
            }
            else
            {
                Console.WriteLine("Услуга не была добавлен:(");
            }
        }
    }    
}