using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
   class Customer
    {
        public string name;
        public string Last_name;
        private int id;
        private static int cur_max_id = 0;
      public  Customer(string name, string last_name)
        {
            id = cur_max_id;
            cur_max_id++;
            this.name = name;
            this.Last_name = last_name;
        }
        public void print()
        {
            Console.WriteLine("----------------------*");
            Console.WriteLine("Клиент№ " + id + ":");
            Console.WriteLine(name + "  " + Last_name);
            Console.WriteLine("----------------------");
        }
        public bool is_compare(Customer customer)
        {
            if(id == customer.id && name == customer.name && Last_name == customer.Last_name)           
                 return true;
                return false;          
        }       
    }
}
