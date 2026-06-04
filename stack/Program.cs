namespace stack
{
    internal class Program
    {
        public static void problemsMainMenu()
        {
            Console.WriteLine("== Stack & Queue  Practice ==");
            Console.WriteLine("1. Browser History Tracker ");
            Console.WriteLine("2. Hotel Check-In Queue");
            Console.WriteLine("3. Text Editor Undo System");
            Console.WriteLine("4. Hospital Emergency Room Triage ");
            Console.WriteLine("5. Parenthesis Validator ");
            Console.WriteLine("6. Print Spooler with Priority Re-Insertion");
            Console.WriteLine("7. Reverse a Sentence Word by Word ");
            Console.WriteLine("8. Multi-Level Undo with Redo ");
            Console.WriteLine("9. Ticket Counter Simulation ");
            Console.WriteLine("10. Order Processing Pipeline with Statistics ");
            Console.WriteLine("0. Exit");
        }
        static void Main(string[] args)
        {
           bool exit=false;
            while (exit == false)
            {
                problemsMainMenu();
                Console.WriteLine("Select your option:");
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


                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("invalid option please try again");
                        break;

                }

            }
        }
    }
}
