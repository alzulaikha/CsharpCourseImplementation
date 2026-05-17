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
                Console.WriteLine("Age Category");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Select your option: ");
                int option = int.Parse(Console.ReadLine());
            }


            }
        }
    }
    

















