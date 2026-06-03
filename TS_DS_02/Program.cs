using System.Diagnostics;

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
        //Room Service Menu function
        public static void roomServiceMenu()
        {
            List<string> menuItems= new List<string>()
            {"Pasta","Pizza","Rice","Salad" };

            Console.WriteLine("== current menu ==");
            for(int i=0;i < menuItems.Count; i++) { 

            Console.WriteLine("Dish" + (i + 1) + ":" + menuItems[i]);
            }
            menuItems.AddRange(new string[] {"Burger","Soup"});
            Console.WriteLine("updated menu");
            for (int i = 0; i < menuItems.Count; i++)
            {

                Console.WriteLine("Dish" + (i + 1) + ":" + menuItems[i]);
            }
            menuItems.RemoveAt(2);
            Console.WriteLine("menu after removed dish");
            for (int i = 0; i < menuItems.Count; i++)
            {

                Console.WriteLine("Dish" + (i + 1) + ":" + menuItems[i]);
            }
            int index = menuItems.IndexOf("Burger");
            if (index == -1)
            {
                Console.WriteLine("dish not found");
            }
            else
            {
                Console.WriteLine("dish found:" + index);
            }
            Console.WriteLine("total number of items:"+menuItems.Count);
        }
        public static void guestCheckInQueue()
        {
            List<string> checkInQueue = new List<string>();
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
                        roomServiceMenu();
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
