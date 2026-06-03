using System.Diagnostics;

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
            List<double> temperatures = new List<double>()
                { 34.2, 35.9, 35.5, 36.1, 36.8, 36.0, 36.2 }; // Creating a list of integers 
         
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
        // product Price Finder function
        public static void productPriceFinder()
        {
            List<double> prices = new List <double>()
                { 2.99, 1.30, 5.32, 1.20, 4.88 } ;
         
  
            Console.WriteLine("Product Prices: ");
            for (int i = 0; i < prices.Count; i++)
            {
                Console.WriteLine("Product" + (i + 1) + ":" + prices[i]);
            }
           
            int index = prices.IndexOf(1.20);
            if (index == -1)
            {
                Console.WriteLine("Price not found");
            }
            else
            {
                Console.WriteLine("Price found:" + index);
            }
        }
        // Race Finish Times function
        public static void raceFinishTime()
        {
            List<int> finishTimes = new List<int>()
             { 89, 79, 68, 90, 75, 88, 92, 84 }; ;
            
            Console.WriteLine("Original times: ");
            foreach (int time in finishTimes)
            {
                Console.WriteLine(time);
            }
            finishTimes.Sort();   // Sorting the list 
            Console.WriteLine("Sorted time:");
            foreach (int time in finishTimes)
            {
                Console.WriteLine(time);
            }
            Console.WriteLine("Number of participants: " + finishTimes.Count);
        }

        // Classroom Grade Report 
        public static void classroomGradeReport()
        {
            List< int > grades = new List< int >()
                { 89, 79, 68, 90, 75, 88, 92, 84, 100, 70 };

            grades.Sort();
            grades.Reverse();
            
            Console.WriteLine("Rank Grades:");

            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine("Rank" + (i + 1) + ":" + grades[i]);
            }
        }
        // Warehouse Inventory Check function
        public static void warehouseInventoryCheck()
        {
            List<int> quantities= new List< int >()
                { 6, 8, 5, 12, 9, 4, 2, 5 };
            
            int total = 0;

            for (int i = 0; i < quantities.Count; i++)
            {

                total +=quantities[i];
            }
            Console.WriteLine("total stock:" + total);
            double average = (double)total / quantities.Count;
            Console.WriteLine("average stock: " + average);

            
            int index = quantities.IndexOf(12);
          
            if (index == -1)
            {
                Console.WriteLine(" quantity not found");
            }
            else
            {
                Console.WriteLine("quantity found:" + index);
            }

        }

        // Library Book Shelf Scanner function
        public static void libraryBookShelfScanner()
        {
            List <int> copies = new List< int >()
                { 7, 9, 11, 4, 0, 6, 8, 2, 5 };
            
            Console.WriteLine("original order: ");
            foreach (int copy in copies)
            {
                Console.WriteLine(copy);
            }
            copies.Sort();
            Console.WriteLine("sorted order list: ");
            foreach (int copy in copies)
            {
                Console.WriteLine(copy);
            }

            Console.WriteLine("Most copies: " + copies[8]);//accessing most copies after sort
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
                        productPriceFinder();
                        break;
                    case 4:
                        raceFinishTime();
                        break;
                    case 5:
                        classroomGradeReport();
                        break;
                    case 6:
                        warehouseInventoryCheck();
                        break;
                    case 7:
                        libraryBookShelfScanner();
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
