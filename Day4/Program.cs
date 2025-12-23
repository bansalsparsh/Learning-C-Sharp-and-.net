using System;
class Program
{
    static void Main()
    {
        // Bank obj = new Bank(3);



        // FD obj1 = new FD(3,7,50000);
        // obj1.BankBal();


        // FD obj1 = new FD(3,7,50000);
        // obj1.FDDetails();




        // C obj = new C();
        // obj.Display();
        // obj.Show();




        // Y obj = new Y();
        // obj.Xx();







        // //Student Profile System:
        // Student s = new Student(12218467)
        // {
        //     AddYear=2022
        // };
        // s.StudentId=3891;
        // s.Name = "SP";
        // s.Age = 21;
        // s.Marks = 85;
        // s.Password = "hwudwud727623";
        // Console.WriteLine($"Student Registration number is  {s.RegNo}");
        // Console.WriteLine($"Student Name is  {s.Name}");
        // Console.WriteLine($"Student ID is {s.StudentId}");
        // Console.WriteLine($"Student age is {s.Age}");
        // Console.WriteLine($"Student has scored {s.Marks} marks");
        // Console.WriteLine($"Student result status is {s.ResultStatus}");
        // Console.WriteLine($"Student percentage in marks is {s.Percentage}");
        // Console.WriteLine($"Student Admission year is {s.AddYear}");
        // // Console.WriteLine($"Student password is {s.Password}"); we cannot access password because it is writeonly property







        // // Library Management System:
        // Library obj = new Library();
        // for(int i = 101; i <= 104; i++)
        // {
        //     Console.Write($"\nEnter {i-100} subject: ");
        //     obj[i] = Console.ReadLine();
        // }
        // for(int i = 101; i <= 104; i++)
        // {
        //     Console.WriteLine($"The subject present in id {i} is {obj[i]}");
        // }





        

        // Insurance Management System
        Authentication valid = new Authentication();
        valid.Display("Amit","1234");

        PolicyStore list = new PolicyStore();

        InsurancePolicy life = new LifeInsurance()
        {
            PolicyNo=101,
            HolderName="Anita",
            Premium=2000
        };
        InsurancePolicy health = new HealthInsurance()
        {
            PolicyNo=102,
            HolderName="Amit",
            Premium=3000
        };
        list[101]="Anita";
        list[102]="Amit";
        life.DisplayInfo();
        health.DisplayInfo();
    }
}