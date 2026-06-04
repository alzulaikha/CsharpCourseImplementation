namespace stack
{
    internal class Program
    {
        // main menu
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
        //Browser History Tracker function
        public static void browserHistoryTracker()
        {
         Stack<string> browserHistory = new Stack<String>();
            browserHistory.Push("google.com");
            browserHistory.Push("github.com");
            browserHistory.Push("amazon.com");
            browserHistory.Push("netflix.com");
            browserHistory.Push("linkedin.com");

            Console.WriteLine("== browser History ==");
            foreach (var browser in browserHistory)
            {

                Console.WriteLine(browser);
            }
            Console.WriteLine("TopItem after peek:");
            var topItem = browserHistory.Peek();
            Console.WriteLine(topItem);

            Console.WriteLine("first removed page: ");
            var removedItem = browserHistory.Pop();
            Console.WriteLine(removedItem);

            Console.WriteLine("second removed page: ");
            var removedItem2=browserHistory.Pop();
            Console.WriteLine(removedItem2);


            Console.WriteLine(" Browser history after both pops: ");
            foreach (var browser in browserHistory)
            {
                Console.WriteLine(browser);
            }


            string checkItem = "amazon.com";
            if (browserHistory.Contains(checkItem))
            {
                Console.WriteLine("URL still in the history");

            }
            else
            {
                Console.WriteLine("URL not found");
            }
            Console.WriteLine(" total number of pages:" + browserHistory.Count);

        }
        // Hotel Check-In Queue
        public static void hotelCheckInQueue()
        {
         Queue<string> checkInQueue = new Queue<string>();
            checkInQueue.Enqueue("Ali");
            checkInQueue.Enqueue("Omar");
            checkInQueue.Enqueue("Amal");
            checkInQueue.Enqueue("Ahmed");
            checkInQueue.Enqueue("Noor");

            Console.WriteLine("== all waiting guests ==");
            foreach (var queue in checkInQueue)
            {
                Console.WriteLine(queue);
            }

            Console.WriteLine("== front item after peek: ==");
            var frontItem = checkInQueue.Peek();
            Console.WriteLine(frontItem);

            Console.WriteLine(" first dequeue guest: ");
            var removedGuest = checkInQueue.Dequeue();
            Console.WriteLine(removedGuest);


            Console.WriteLine(" second dequeue guest: ");
            var removedGuest2= checkInQueue.Dequeue();
            Console.WriteLine(removedGuest2);

            Console.WriteLine("== queue after serving ==");
            foreach (var queue in checkInQueue)
            {
                Console.WriteLine(queue);
            }

           
            Console.WriteLine("Guest is still waiting :" +checkInQueue.Contains("Ali"));
            Console.WriteLine(" total number of guests still in the queue: " +checkInQueue.Count);
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
                        browserHistoryTracker();
                        break;
                    case 2:
                        hotelCheckInQueue();
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
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear(); // clear the console for better user experience
            }
        }
    }
}
