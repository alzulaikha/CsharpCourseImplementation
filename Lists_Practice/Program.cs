namespace Lists_Practice
{
    internal class Program
    {
        //main menu function
        public static void mainMenu()
        {
            Console.WriteLine("== Arrays Practice ==");
            Console.WriteLine("1. Temperature Log");
            Console.WriteLine("2. Student Score Board");
            Console.WriteLine("3. Product Price Finder");
            Console.WriteLine("4. Race Finish Times");
            Console.WriteLine("5. Classroom Grade Report");
            Console.WriteLine("6. Warehouse Inventory Check");
            Console.WriteLine("7. Library book Shelf Scanner");
            Console.WriteLine("8. Sales Performance Analyzer");
            Console.WriteLine("9. Flight Seat Allocation Display");
            Console.WriteLine("10. Hospital Patient Priority Queue");
            Console.WriteLine("0. Exit");
        }

        // temperaturees Log function
        public static void temperatureesLog()
        {
            List<double> temperatures = new List<double>(); // Creating a list of integers 
            temperatures.AddRange(new double[] { 34.2, 35.9, 35.5, 36.1, 36.8, 36.0, 36.2 });
            for (int i = 0; i < temperatures.Count; i++)
            {
                Console.WriteLine("Day" + (i + 1) + ":" + temperatures[i] + "C");

            }
            Console.WriteLine("Total number of reading:" + temperatures.Count);
        }
        // Student Score Board function
        public static void studentScoreBoard()
        {
            List<int> scores = new List<int>();
            scores.AddRange(new int[] { 80, 87, 93, 76, 83, 97 });
           
            Console.WriteLine("Original Scores:");
            foreach (int s in scores) //Print all scores in their original order
            {
                Console.WriteLine(s);
            }
            scores.Reverse();
            

            Console.WriteLine("Reversed Scores:"); //Reverse the array 
            for (int i = 0; i < scores.Count; i++)
            {
                Console.WriteLine(scores[i]);
            }
        }
        static void Main(string[] args)
        {

            bool exit = false;
            while (exit == false)

            {
                mainMenu();
                Console.WriteLine("Select your option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    
                    case 1:
                        temperatureesLog();
                        break;
                    case 2:
                        studentScoreBoard();
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




                }// closed switch
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear(); // clear the console for better user experience
            }

        }

               
    }
}
