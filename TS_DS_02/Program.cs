namespace TS_DS_02
{
    internal class Program
    {
        // Problems main menu
        public static void problemsMainMenu()
        {
            Console.WriteLine("== List Practice ==");
            Console.WriteLine("1. Room Service Menu");
            Console.WriteLine("2. Guest Check-In Queue");
            Console.WriteLine("3. Housekeeping Floor Assignment");
            Console.WriteLine("4. Hotel Booking Conflict Resolver ");
            Console.WriteLine("0. Exit");
        }
        static void Main(string[] args)
        {

            bool exit = false;
            while (exit == false)

            {
                problemsMainMenu();
                Console.WriteLine("Select your option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        
                        break;
                    case 2:
                       
                        break;
                    case 3:
                        
                        break;
                    case 4:
                       
                        break;
                   
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("invalid option please try again");
                        break;




                }// closed switch
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear(); // clear the console for better user experience
            }
        }
    }
}
