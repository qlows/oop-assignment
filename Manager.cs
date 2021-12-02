using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAssignment
{
    class Manager
    {
        private oopAssignment.Customer[] clist;
        private int numCustomer;
        private int maxCustomer;

        public Manager()
        {
            numCustomer = 0;
            maxCustomer = 100;
            clist = new Customer[maxCustomer];
        }

        public bool addCustomer(string fnam, string lName, int phone)
        {
            if (numCustomer < maxCustomer)
            {
                Random rnd = new Random();
                int id = rnd.Next(10000, 99999);
                clist[maxCustomer] = new Customer(id, fnam, lName, phone);
                numCustomer++;
                return true;
            }
            return false;
        }

        public string listAllCustomers()
        {
            string s = "=== Customer List ===\n";
            for (int i = 0; i < numCustomer; i++)
            {
                if (clist[i].GetType() == typeof(Customer))
                {
                    s += ((Customer)clist[i]).ToString() + "\n";
                }
            }
            return s;
        }
    }
}
