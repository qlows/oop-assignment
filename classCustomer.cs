using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oopAssignment
{
    class Customer
    {
        private int customerID;
        private string fName;
        private string lName;
        private int phoneNumber;
        
        public string bookingID { get; private set; }
        
        public Customer(int id, string fName, string lName, int phone)
        {
            customerID = id;
            this.fName = fName;
            this.lName = lName;
            phoneNumber = phone;
        }

        public int getCustomerID() { return customerID; }
        public string getFirstName() { return fName; }
        public string getLastName() { return lName; }
        public int getPhoneNumber() { return phoneNumber; }
        public int getBookingID(int bookingID) { return bookingID; }

        public string toString()
        {
            string s = "Customer ID: " + customerID;
            s += "\nFirst Name: " + fName;
            s += "\nLast Name: " + lName;
            s += "\nPhone Number: " + phoneNumber;
            s += "\nbooking ID: " + bookingID; 
            return s;
        }
    }
}
