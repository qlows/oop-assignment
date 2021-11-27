using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GroupProject
{
    class Customer
    {
        private int customerID;
        private string fName;
        private string lName;
        private int phoneNumber;
        private Booking[] bookings;
        private int numOfBookings;

        public Customer(int id, string fName, string lName, int phone)
        {
            customerID = id;
            this.fName = fName;
            this.lName = lName;
            phoneNumber = phone;
            bookings = new Booking[numOfBookings];
        }

        public int getCustomerID() { return customerID; }
        public string getFirstName() { return fName; }
        public string getLastName() { return lName; }
        public int getPhoneNumber() { return phoneNumber; }

        public string getBookings() {
            string s = "\nBooked Flights: ";
            // Add for-loop to list booked flights when Bookings class is done.
            return s;
        }

        public string toString()
        {
            string s = "Customer ID: " + customerID;
            s += "\nFirst Name: " + fName;
            s += "\nLast Name: " + lName;
            s += "\nPhone Number: " + phoneNumber;
            return s;
        }
    }
}