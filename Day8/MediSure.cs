#pragma warning disable
using System;
class PatientBill
{
    public PatientBill()
    {
        Console.Write("\nEnter Bill Id: ");
        BillId = Console.ReadLine();

        Console.Write("Enter Patient Name: ");
        PatientName = Console.ReadLine();

        Console.Write("Is the patient insured? (Y/N): ");
        string ans = Console.ReadLine();
        HasInsurance = ans.Equals("Y")?true:false;

        while (ConsultationFee <= 0)
        {
            Console.Write("Enter Consultation Fee: ");
            ConsultationFee=Convert.ToDouble(Console.ReadLine());
        }

        while (LabCharges <= 0)
        {   
            Console.Write("Enter Lab Charges: ");
            LabCharges=Convert.ToDouble(Console.ReadLine());
            if (LabCharges == 0) break;
        }
        
        while (MedicineCharges <= 0)
        {
            Console.Write("Enter Medicine Charges: ");
            MedicineCharges=Convert.ToDouble(Console.ReadLine());
            if (MedicineCharges == 0) break;
        }
    }
    public static string BillId;
    public static string PatientName;
    public static bool HasInsurance;
    public static double ConsultationFee=0;
    public static double LabCharges=0;
    public static double MedicineCharges=0;
    public static double GrossAmount;
    public static double DiscountAmount=0;
    public static double FinalPayable;
    public static bool HasLastBill=false;

    public static void Calculate()
    {
        GrossAmount = ConsultationFee+LabCharges+MedicineCharges;
        if (HasInsurance == true)
        {
            DiscountAmount = GrossAmount * 0.10;
        }
        FinalPayable = GrossAmount - DiscountAmount;
        Console.WriteLine($"Gross Amount: {GrossAmount:F2}\nDiscount Amount: {DiscountAmount:F2}\nFinal Payable: {FinalPayable:F2}\n");
                    
    }
    public static void LastBill()
    {
        Console.WriteLine("\n------------------------- Last Bill -------------------------");
        Console.WriteLine($"BillId: {BillId}\nPatient: {PatientName}\nInsured: {HasInsurance}\nConsultation Fee: {ConsultationFee:F2}\nLab Charges: {LabCharges:F2}\nMedicine Charges: {MedicineCharges:F2}\nGross Amount: {GrossAmount:F2}\nDiscount Amount: {DiscountAmount:F2}\nFinal Payable: {FinalPayable:F2}");
        Console.WriteLine("-------------------------------------------------------------\n");
    }
}