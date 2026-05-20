using System.Collections.Specialized;

namespace LibraryManagementSystem
{
    internal class Program
    {
        string memberMName = "";
        int memberID = 0;
        string memberEmail = "";
        string memShipExpiryDate = "";
        String memberTire = "";
        string bookTitle = "";
        string boohAuthor = "";
        string bookGenre = "";
        int bookcopiesNum = 0;
        int totalBooks = 0;
        double totalFinesPaid= 0;
        bool isMemberRegistered = false;
        bool isBookRegistered = false;


        public static void PrintMainMenu()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("0. Register Member");
            Console.WriteLine("1. Display Member Profile");
            Console.WriteLine("2. Search Book by Title ");
            Console.WriteLine("3. Borrow a Book");
            Console.WriteLine("4. Return a Book");
            Console.WriteLine("5. Calculate Late Fine");
            Console.WriteLine("6. Apply Member Discount");
            Console.WriteLine("7. Check Borrowing Eligibility");
            Console.WriteLine("8. Register Book ");
            Console.WriteLine("9. Generate Member ID");
            Console.WriteLine("10. Display Book Details ");
            Console.WriteLine("11. Calculate Renewal Fee");
            Console.WriteLine("12. Update Member Email");
            Console.WriteLine("13 Session Summary");
            Console.WriteLine("14. Exit");

            Console.WriteLine("Select your option: ");
            int option = int.Parse(Console.ReadLine());
        }




        static void Main(string[] args)
        {
            
        bool exit = false;
            while (exit) { 
            
            
            PrintMainMenu();

            
            
            }


        }
    }
}
