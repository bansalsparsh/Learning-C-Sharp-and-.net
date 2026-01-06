using System;
class Patient
{
    public int PatientId { get; }
    public string Name { get; set; }
    public int Age { get; set; }

    private string medicalHistory;

    public Patient(int id, string name, int age)
    {
        PatientId = id;
        Name = name;
        Age = age;
    }

    public void SetMedicalHistory(string history)
    {
        medicalHistory = history;
    }

    public string GetMedicalHistory()
    {
        return medicalHistory;
    }
}
class Doctor
{
    public static int TotalDoctors;
    public readonly string LicenseNumber;

    public string Name { get; set; }
    public string Specialization { get; set; }

    static Doctor()
    {
        TotalDoctors = 0;
    }

    public Doctor(string name, string specialization, string license)
    {
        Name = name;
        Specialization = specialization;
        LicenseNumber = license;
        TotalDoctors++;
    }
}
class Cardio : Doctor
{
    Cardio(string a, string b, string c) : base(a,b,c){}
    public static void Print()
    {
        Console.WriteLine(TotalDoctors);
    }
}