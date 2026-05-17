using Microsoft.Win32;

namespace ClinicManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //rejon 1 : system storage ( variables )
            // store banck account information
            string P1Name = "";
            string P1Number = "";
            int P1Age = 0;
            string P1Phone = "";
            bool P1Active = false;


            //rejon 2 : system processing ( menu functions )
            // print main menu


            bool exit = false;
            while (exit == false)

            {

                Console.Clear();

                Console.WriteLine("CLINIC MANAGEMENT SYSTEM ");
                Console.WriteLine("1.Registeration Patient ");
                Console.WriteLine("2.View Patients");
                Console.WriteLine("3.Edit Patient");
                Console.WriteLine("4.Age Category");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Select your option: ");
                int option = int.Parse(Console.ReadLine());

                switch(option)


                {
                    case 1: //Registeration Patient
                        if (P1Active==true) 
                        { 
                       Console.WriteLine("account information already exists ");
                        }
                        else
                        {
                            Console.WriteLine("Enter Patient name:");
                            P1Name = Console.ReadLine();
                            Console.WriteLine("Enter Patient number:");
                            P1Number = Console.ReadLine();
                            Console.WriteLine("Enter Patient age:");
                            P1Age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Patient Phone Number ");
                            P1Phone = Console.ReadLine();

                            P1Active = true;
                            Console.WriteLine("account information added successfully.");

                        }

                        break;


                }
            }


            }
        }
    }
    

















