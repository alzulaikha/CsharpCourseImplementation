using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string guestName = "";
            string guestPhone = "";
            string roomNumber = "";
            string roomType = "";
            double nightlyRate = 0;
            string checkInDate = "";
            string checkOutDate = "";
            int numberOfNights = 0;
            string roomNotes = "";
            double discountPercentage= 0;
            double loyaltyPoints = 0;
            bool registeredGuest = false;
            bool checkedinGuest = false;





            bool exit = false;
            while (exit == false)

            {

                Console.Clear();

                Console.WriteLine("=== Hotel MANAGEMENT SYSTEM === ");
                Console.WriteLine("0 Register New Guest");
                Console.WriteLine("1 View Guest Information");
                Console.WriteLine("2 Check-In Guest ");
                Console.WriteLine("3 Check-Out & Bill ");
                Console.WriteLine("4 Apply Discount");
                Console.WriteLine("5 Upgrade Room");
                Console.WriteLine("6 Add Room Service Note");
                Console.WriteLine("7 Search Guest by Name");
                Console.WriteLine("8 Calculate Loyalty Points");
                Console.WriteLine("9 Print Receipt ");
                Console.WriteLine("10 Edit Guest Name");
                Console.WriteLine("11 Exit");


                Console.WriteLine("Select your option: ");
                int option = int.Parse(Console.ReadLine());

              


            }
            }
    }
}
