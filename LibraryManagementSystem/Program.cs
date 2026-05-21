using Microsoft.VisualBasic.FileIO;
using System.Collections.Specialized;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static string memberName = "";
        static int memberID = 0;
        static string memberEmail = "";
        static string memShipExpiryDate;
        static string memberTire = "";
        static string bookTitle = "";
        static string bookAuthor = "";
        static string bookGenre = "";
        static int bookcopiesNum = 0;
        static int totalBooks = 0;
        static double totalFinesPaid = 0;
        static bool isMemberRegistered = false;
        static bool isBookRegistered = false;


        public static void PrintMainMenu()//main menu function
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

        


        public static bool checkregister()//check register function
        {
            if (isMemberRegistered == true)
            {
                Console.WriteLine("Member information already exists ");
                return true;
            }
            else
            {
                return false;
            }
        }


        public static void AddMemberInformation()//add member function
        {

            Console.WriteLine("Enter member name:");
            memberName = Console.ReadLine();
          
            Console.WriteLine("Enter member Id:");
            memberID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter member email:");
            memberEmail = Console.ReadLine();
            Console.WriteLine("Enter member's membership expiry date");
            memShipExpiryDate = Console.ReadLine();
            string dateToday = DateTime.Now.ToString();
            Console.WriteLine("member's membership expiry date:" + dateToday);


            isMemberRegistered = true;
            Console.WriteLine("Member information added successfully.");




        }
        
        public static void displayinformation()//display member information function
        {
            Console.WriteLine("Account Member Name: " + memberName);
            Console.WriteLine("Account Member ID: " + memberID);
            Console.WriteLine("Account Member Email: " + memberEmail);
        }

        static void BorrowBook(ref int copies)//Borrow a Book function
        {
            Console.WriteLine("enter available copy"+copies);
            copies=int.Parse(Console.ReadLine());

            if (copies > 0)
            {
                copies--;
                Console.WriteLine("Book is borrow");

            }
            else { Console.WriteLine("No book availbe");
            }
        }


        public static  int ReturnBook(ref int copies)//Return a Book  function
        {


                copies = copies + 1;
                Console.WriteLine("Book return ");
                return copies;
            }

        public static void AddBook(string title, string author, int numcopy,string genre="")//add book function
        {
            if (isBookRegistered == false)
            {
                Console.WriteLine("No Book Registered");

            }
            else
                Console.WriteLine("Enter book title:");
            bookTitle = Console.ReadLine().Trim();
            Console.WriteLine("Enter author name:");
            bookAuthor= Console.ReadLine().Trim();
            Console.WriteLine("Enter number of book copies:");
            bookcopiesNum=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter book genre");
            bookGenre = Console.ReadLine().Trim();

            isBookRegistered = true;
            Console.WriteLine("Book information added successfully.");
                
                }
        public static int CalculateLateFine(ref int days)
        {
            
            double Fine = Math.Sqrt(days)*3;
           
            return days;
        }

        static void Main(string[] args)
            {

                bool exit = false;
                while (exit == false)
                {


                    PrintMainMenu();
                    Console.WriteLine("Select your option: ");
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 0: ////Registeration Member

                            bool checkResult = checkregister();

                            if (checkResult == false)
                            {
                                AddMemberInformation();
                            }

                            break;

                        case 1://Display Member Profile
                            bool check = checkregister();
                            if (check == true)
                            {
                                displayinformation();
                            }
                            break;
                        case 2:

                            break;
                        case 3://Borrow a Book

                        if (isBookRegistered == false)
                        {
                            Console.WriteLine("No Book Registered");
                            break;
                        }
                        else
                        {


                            BorrowBook(ref bookcopiesNum);

                            Console.WriteLine("Available Copies: " + bookcopiesNum);
                        }
                        break;
                        case 4://Return a Book
                        if (isBookRegistered == false)
                            
                            {
                                Console.WriteLine("No book register");
                            }

                            ReturnBook(ref bookcopiesNum);
                            break;
                        case 5:

                        Console.WriteLine("Enter number of overdue days");
                        int days= int.Parse(Console.ReadLine());

                        double Fine= CalculateLateFine(ref days);
                        totalFinesPaid = totalFinesPaid + Fine;

                        Console.WriteLine("Late Fine:" + Fine);
                        Console.WriteLine("Total of fine:" + totalFinesPaid);


                        break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                        
                        
                            AddBook(bookTitle, bookAuthor, bookcopiesNum,bookGenre);
                        
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