using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    class Employee
    {
        public string name;
        public string Last_name;
        private int id;
        private static int cur_max_id = 0;
        private string position;
        public Employee(string name, string last_name, string position)
        {
            id = cur_max_id;
            cur_max_id++;
            this.name = name;
            this.Last_name = last_name;
            this.position = position;
        }
        public void print()
        {
            Console.WriteLine("----------------------*");
            Console.WriteLine("Работник№ " + id + ":");
            Console.WriteLine(name + "  " + Last_name + "  " + position);
            Console.WriteLine("----------------------");
        }
        public bool is_compare(Employee employee)
        {
            if (id == employee.id && name == employee.name && Last_name == employee.Last_name)
                return true;
            return false;
        }
    }
}
