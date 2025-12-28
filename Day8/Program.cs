#pragma warning disable
using System;
class Program
{
    static void Main()
    {
        int option;
        do
        {
            Console.WriteLine("\n================== MediSure Clinic Billing ==================\n");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)\n2. View Last Bill\n3. Clear Last Bill\n4. Exit");
            Console.Write("\nEnter your Option: ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PatientBill bill = new PatientBill();
                    PatientBill.HasLastBill=true;
                    Console.Write("\nBill created successfully.\n");
                    PatientBill.Calculate();
                    Console.WriteLine("-------------------------------------------------------------\n");
                    break;

                case 2:
                    if(PatientBill.HasLastBill) PatientBill.LastBill();
                    else{
                        Console.WriteLine("\n-------------------------------------------------------------");
                        Console.WriteLine("No bill available. Please create a new bill first.");
                        Console.WriteLine("-------------------------------------------------------------\n");
                    }
                    break;

                case 3:
                    Console.WriteLine("\n-------------------------------------------------------------");

                    if(PatientBill.HasLastBill==true){
                        PatientBill.HasLastBill=false;
                        Console.WriteLine("Last bill cleared.");
                    }
                    else Console.WriteLine("No bill available to be cleared.");

                    Console.WriteLine("-------------------------------------------------------------\n");
                    break;

                case 4:
                    Console.WriteLine("\n-------------------------------------------------------------");
                    Console.WriteLine("Thank you. Application closed normally.");
                    Console.WriteLine("-------------------------------------------------------------\n");
                    break;
                default:
                    Console.WriteLine("Invalid Option!!");
                    break;
            }
        }while(option != 4);
        Console.WriteLine("=============================================================");
    }
}