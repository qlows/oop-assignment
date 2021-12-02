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
        private oopAssignment.Booking[] blist;
        private int numCustomer;
        private int numBookings;
        private int maxBookings;
        private int maxCustomer;

        public Manager()
        {
            numCustomer = 0;
            numBookings = 0;
            maxCustomer = 100;
            maxBookings = 99999;
            clist = new Customer[maxCustomer];
            blist = new Booking[maxBookings];
        }

        public bool addCustomer(string fnam, string lName, long phone)
        {
            if (numCustomer < maxCustomer)
            {
                Random rnd = new Random();
                int id = rnd.Next(10000, 99999);
                clist[numCustomer] = new Customer(id, fnam, lName, phone);
                numCustomer++;
                return true;
            }
            return false;
        }

        public bool addBooking(int customerID, int flightID)
        {
            if (numBookings < maxBookings)
            {
                Random rnd = new Random();
                int bID = rnd.Next(100, 999);
                string date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
                blist[numBookings] = new Booking(date, bID, customerID, flightID);
                numBookings++;
                return true;
            }
            return false;
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

        public int findCustomer(int custId)
        {
            for (int x = 0; x < maxBookings; x++)
            {
                if (clist[x].getCustomerID() == custId)
                    return x;
            }
            return -1;
        }

        public bool deleteCustomer(int custId)
        {
            int loc = findCustomer(custId);
            if (loc == -1) return false;
            clist[loc] = clist[numCustomer - 1];
            numCustomer--;
            return true;
        }
    }
}
