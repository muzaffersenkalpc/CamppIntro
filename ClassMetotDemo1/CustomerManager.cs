using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo1
{
    internal class CustomerManager
    {
       public void Add(Customer customer)
        {
            Console.WriteLine("Basariyla eklendi : " + customer.Name);
        }
        public void Update(Customer customer) 
        {
            Console.WriteLine("Basariyla gncellendi : " + customer.Name);
        }
    }
}
