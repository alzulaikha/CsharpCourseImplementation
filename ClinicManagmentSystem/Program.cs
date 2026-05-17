using Microsoft.Win32;
using System.Xml.Linq;

namespace ClinicManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //rejon 1 : system storage ( variables )
            // store banck account information
            string P1Name = "";
            string P1IdNumber = "";
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
                Console.WriteLine("2.View Patients Information");
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
                            P1IdNumber = Console.ReadLine();
                            Console.WriteLine("Enter Patient age:");
                            P1Age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Patient Phone Number ");
                            P1Phone = Console.ReadLine();

                            P1Active = true;
                            Console.WriteLine("account information added successfully.");

                        }

                        break;

                        case 2: //.View Patients Information
                        
                         if (P1Active == false)
                        {
                            Console.WriteLine("no account information found, please add account information ");
                        }
                        else
                        {
                            Console.WriteLine("Patient Name " + P1Name);
                            Console.WriteLine("Patient ID Number: " + P1IdNumber);
                            Console.WriteLine("Patient Age : " + P1Age);
                            Console.WriteLine("Patient Phone Number:" + P1Phone);
                        }
                        break;

                    case 3: //Edit Patient

                        Console.WriteLine("Select option number to edit");
                        Console.WriteLine("1. Edit Patient Name");
                        Console.WriteLine("2. Edit Patient phone");
                        int Option = int.Parse(Console.ReadLine());

                        if (Option == 1)
                        {
                            Console.WriteLine("Enter new patient name:");
                            P1Name = Console.ReadLine();
                            Console.WriteLine("Patient name updated successfully.");
                        }
                        else if (Option == 2)
                        {
                            Console.WriteLine("Enter new patient phone:");
                            P1Phone = Console.ReadLine();
                            Console.WriteLine("Patient patient updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("invalid option please try again");
                        }

                        break;


                    case 4: //Age Category


                        Console.WriteLine("Enter Patient age");
                        P1Age = Convert.ToInt32(Console.ReadLine());
                        if (P1Age < 18)
                        {
                            Console.WriteLine("");
                            break;
                        }
                        
                     else if (P1Age > 1 || P1Age <= 60)
                    {
                        Console.WriteLine("");
                        break;
                    }
                        else if (P1Age > 60 )
                        {
                            Console.WriteLine("");
                        }
                        break;

                    case 0: // exit
                        exit = true;
                        break;

                    default:// invalid option
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
    
    

















