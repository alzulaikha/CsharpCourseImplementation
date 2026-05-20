using Microsoft.VisualBasic.FileIO;
using System.Collections.Specialized;

namespace LibraryManagementSystem
{
    internal class Program
    {
       static string memberName = "";
       static int memberID = 0;
       static string memberEmail = "";
       static DateTime memShipExpiryDate;
       static String memberTire = "";
       static string bookTitle = "";
       static string boohAuthor = "";
       static string bookGenre = "";
       static int bookcopiesNum = 0;
       static int totalBooks = 0;
       static double totalFinesPaid= 0;
       static bool isMemberRegistered = false;
       static bool isBookRegistered = false;
       

        public static void PrintMainMenu()
        {
            Console.Clear();
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

           
        }
      
        public static bool checkisactive()
            {
            if(isMemberRegistered== true)
            {
                Console.WriteLine("No member information found, please add member information ");
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AddMemberInformation()
        {
            Console.WriteLine("Enter member name:");
            memberName = Console.ReadLine();
            string Name  = memberName.Substring(1,4);
            Console.WriteLine("Enter member Id:");
            memberID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter member email:");
            memberEmail = Console.ReadLine();
           
            

            isMemberRegistered = true;
            Console.WriteLine("Member information added successfully.");
        }
        static void Main(string[] args)
        {
            
        bool exit = false;
            while (exit) { 
            
            
            PrintMainMenu();
                Console.WriteLine("Select your option: ");
               int option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 0: ////Registeration Member

                        bool checkResult = checkisactive();

                        if (checkResult == false) //there is no account stored
                        {
                            AddMemberInformation();
                        }


                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
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
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    default:// invalid option
                        Console.WriteLine("invalid option please try again");
                        break;



                }//closed switch
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear(); // clear the console for better user experience
            }//closed while


        }
    }
}
