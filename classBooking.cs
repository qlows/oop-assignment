class Booking
{
    private string date;
    private int bookingID;
    public Booking(string date, int bookingID)
    {
        Random Rand = new Random();
        this.date = date;
        bookingID = Rand.Next(10000, 99999);
    }
    public string getDate(String date){
        return date;
    }
    public string toString() {
        string s = "Booking";
        s += "\nBooking id :" + bookingID;
        s += "\nBooking date: " + date;;
        return s;
    }
}