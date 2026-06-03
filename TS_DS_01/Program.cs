using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Timers;

namespace TS_DS_01
{
    internal class Program
    {
        //Main menu function 
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
            double[] temperatures = { 34.2, 35.9, 35.5, 36.1, 36.8, 36.0, 36.2 };
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine("Day" + (i + 1) + ":" + temperatures[i] + "C");

            }
            Console.WriteLine("Total number of reading:" + temperatures.Length);
        }
        // Student Score Board function
        public static void studentScoreBoard()
        {
            int[] scores = { 80, 87, 93, 76, 83, 97 };

            Console.WriteLine("Original Scores:");
            foreach (int s in scores) //Print all scores in their original order
            {
                Console.WriteLine(s);
            }
            Array.Reverse(scores);

            Console.WriteLine("Reversed Scores:"); //Reverse the array 
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }
        }
         //product price finder function
        public static void productPriceFinder()
        {
            double[] prices = { 2.99, 1.30, 5.32, 1.20, 4.88 };
            Console.WriteLine("Product Prices: ");
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("Product" + (i + 1) + ":" + prices[i]);
            }
            
            int index = Array.IndexOf(prices,1.20);
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
            int[] finishTimes = { 89, 79, 68, 90, 75, 88, 92, 84 };
            Console.WriteLine("Original times: ");
            foreach (int time in finishTimes)
            {
                Console.WriteLine(time);
            }
            Array.Sort(finishTimes);
            Console.WriteLine("Sorted time:");
            foreach (int time in finishTimes)
            {
                Console.WriteLine( time);
            }
            Console.WriteLine("Number of participants: " + finishTimes.Length);
        }
        // Classroom Grade Report 
        public static void classroomGradeReport()
        {
            int[] grades = { 89, 79, 68, 90, 75, 88, 92, 84,100,70 };
            Array.Sort(grades);
            Array.Reverse(grades);
            Console.WriteLine("Rank Grades:");

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Rank" + (i + 1) + ":" + grades[i]);
            }
        }
        // Warehouse Inventory Check function
        public static void warehouseInventoryCheck()
        {
            int[] quantities = { 6, 8, 5, 12, 9, 4, 2, 5 };
            int total = 0;
            
            for (int i = 0; i < quantities.Length; i++)
            {
                
                total += quantities[i];
            }
            Console.WriteLine("total stock:" + total);
            double average= (double)total / quantities.Length;
            Console.WriteLine("average stock: " + average);

            int index1 = Array.IndexOf(quantities,12);
            if (index1 == -1)
            {
                Console.WriteLine(" quantity not found");
            }
            else
            {
                Console.WriteLine("quantity found:"+ index1);
            }

        }
        // Library Book Shelf Scanner function
        public static void libraryBookShelfScanner()
        {
            int[] copies = { 7, 9, 11, 4, 0, 6, 8, 2, 5 };
            Console.WriteLine("original order: ");
            foreach (int copy in copies)
            {
                Console.WriteLine(copy);
            }
            
            Array.Sort(copies);
            Console.WriteLine("sorted order list: ");
            foreach (int copy in copies)
            {
                Console.WriteLine(copy);
            }
          
            Console.WriteLine("Most copies: "+ copies[8]);//accessing most copies after sort
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
                        case 1://Problem 1: Temperature Log
                        temperatureesLog();
                            break;
                        case 2://Problem 2: Student Score Board 
                        studentScoreBoard();
                            break;
                        case 3://Problem 3: Product Price Finder
                        productPriceFinder();
                            break;
                        case 4://Problem 4: Race Finish Times 
                        raceFinishTime();
                            break;
                        case 5://Problem 5: Classroom Grade Report
                        classroomGradeReport();
                            break;
                        case 6://Problem 6: Warehouse Inventory Check 
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


















