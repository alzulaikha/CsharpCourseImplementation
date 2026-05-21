

namespace ClinicManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //rejon 1 : system storage ( variables )
            // store banck account information
            string PatientNamee = "";
            string PatientIdNumber = "";
            int PatientAge = 0;
            string PatientPhone = "";
            bool PatientActive = false;


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
                Console.WriteLine("5. Delete Patient information:");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Select your option: ");
                int option = int.Parse(Console.ReadLine());

                switch(option)


                {
                    case 1: //Registeration Patient

                        if (PatientActive==true) 
                        { 
                       Console.WriteLine("account information already exists ");
                        }
                        else
                        {
                            Console.WriteLine("Enter Patient name:");
                            PatientNamee = Console.ReadLine();
                            Console.WriteLine("Enter Patient number:");
                            PatientIdNumber = Console.ReadLine();
                            Console.WriteLine("Enter Patient age:");
                            PatientAge = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Patient Phone Number ");
                            PatientPhone = Console.ReadLine();

                            PatientActive = true;
                            Console.WriteLine("account information added successfully.");

                        }

                        break;

                        case 2: //.View Patients Information
                        
                         if (PatientActive == false)
                        {
                            Console.WriteLine("no account information found, please add account information ");
                        }
                        else
                        {
                            Console.WriteLine("Patient Name " + PatientNamee);
                            Console.WriteLine("Patient ID Number: " + PatientIdNumber);
                            Console.WriteLine("Patient Age : " + PatientAge);
                            Console.WriteLine("Patient Phone Number:" + PatientPhone);
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
                            PatientNamee = Console.ReadLine();
                            Console.WriteLine("Patient name updated successfully.");
                        }
                        else if (Option == 2)
                        {
                            Console.WriteLine("Enter new patient phone:");
                            PatientPhone = Console.ReadLine();
                            Console.WriteLine("Patient patient updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("invalid option please try again");
                        }

                        break;


                    case 4: //Age Category


                        Console.WriteLine("Enter Patient age");
                        PatientAge = Convert.ToInt32(Console.ReadLine());
                        if (PatientAge < 18)
                        {
                            Console.WriteLine("Children and teenagers");
                            break;
                        }
                        
                     else if (PatientAge > 1 || PatientAge <= 60)
                    {
                        Console.WriteLine("Adults ");
                        break;
                    }
                        else if (PatientAge > 60 )
                        {
                            Console.WriteLine("Senior");
                        }
                        break;

                    case 5: //Delete Patient information
                        Console.Write("Enter Patient name to delete: ");
                        string PatientName = Console.ReadLine();

                        if (PatientActive && PatientNamee == PatientName)
                        {
                           

                            PatientActive = false;
                            PatientNamee = "";
                            PatientIdNumber = "";
                            PatientAge = 0;
                            PatientPhone = "";
                            

            

                            Console.WriteLine("Patient removed.");
                        }
                        else
                        {
                            Console.WriteLine("Patient not found.");
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


















