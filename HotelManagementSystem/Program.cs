

using System.Runtime.CompilerServices;

namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string guestName = "";
            string guestPhone = "";
            int roomNumber = 0;
            string roomType = "";
            double nightlyRate = 0;
            DateTime checkInDate;
            DateTime checkOutDate;
            int numberOfNights = 0;
            string roomNotes = "";
            double discountPercentage = 0;
            double loyaltyPoints = 0;
            bool isRegisteredGuest = false;
            bool isCheckedinGuest = false;





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

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Enter Guest Name :");
                        guestName = Console.ReadLine().Trim();
                        Console.WriteLine("Enter Guest Phone :");
                        guestPhone = Console.ReadLine().Trim();
                        Console.WriteLine("Enter Room Type :S/D/K");
                        roomType = Console.ReadLine().Trim();
                        Console.WriteLine("Enter Nightly Rate");
                        nightlyRate = double.Parse(Console.ReadLine());

                        roomNumber = new Random().Next(0, 100);


                        isRegisteredGuest = true;

                        Console.WriteLine("Guest registered successfully");
                        Console.WriteLine("Room Number: " + roomNumber);

                        break;

                    case 1:
                        if (isRegisteredGuest == false)
                        {
                            Console.WriteLine("No Guest Registered");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Guest Name: " + guestName.ToUpper());

                            Console.WriteLine("Phone: " + guestPhone);

                            Console.WriteLine("Room Number: " + Convert.ToString(roomNumber));

                            Console.WriteLine("Room Type: " + roomType);

                            Console.WriteLine("Nightly Rate: " + Math.Round(nightlyRate, 0));//Math.Round

                        }
                        break;

                    case 2:
                        if (isRegisteredGuest == false)
                        {
                            Console.WriteLine("No guest registered");
                        }
                        else
                        {
                            Console.WriteLine("Enter number of night");
                            numberOfNights = Convert.ToInt32(Console.ReadLine());
                            checkInDate = DateTime.Now;

                            DateTime dt = DateTime.Today;
                            checkOutDate = checkInDate.AddDays(numberOfNights);

                            isCheckedinGuest = true;
                            Console.WriteLine("Checked guest is successfully");

                            Console.WriteLine("Check-in date:" + checkInDate.ToString());

                            Console.WriteLine("Check-out date:" + checkOutDate.ToString());

                        }
                        break;

                    case 3:
                        if(isCheckedinGuest==false)
                        {
                            Console.WriteLine("Guest not checked in");
                        }
                        else
                        {
                            double totalbill;
                            totalbill = numberOfNights * nightlyRate;
                            Console.WriteLine("Total bill:" + Math.Round(totalbill, 0));
                            Console.WriteLine("Customer checked out successfully");
                        }
                        break;
                    case 4:
                        if (isCheckedinGuest== false)
                        {
                            Console.WriteLine("Guest not checked");
                        }
                     
                        Console.WriteLine("Enter discount percentage");
                        
                        discountPercentage= Convert.ToDouble(Console.ReadLine());
                        discountPercentage= Math.Abs(discountPercentage);

                        double totalBill;
                        totalBill= numberOfNights * nightlyRate;

                        double finalBill;

                        finalBill = totalBill - (totalBill * discountPercentage / 100);

                        Console.WriteLine("Original amount discount:" + Math.Round(totalBill, 1));
                        Console.WriteLine("Discounted amount" +Math.Round(finalBill,1));
             

                        break;
                    



                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;

                    default:
                        break;

                }

















                switch (option)
                {

                    case 0: //Register New Guest






                    case 1:



                        break;

                }

                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear(); // clear the console for better user experience

            }
        }
    }
}





    