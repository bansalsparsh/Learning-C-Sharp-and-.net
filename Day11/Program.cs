using System;
class Program
{
    static void Main()
    {
        //Garbage Collection
        // Console.WriteLine("Creating objects...");
        // for (int i=0;i<5;i++)
        // {
        //     MyClass obj = new MyClass();
        // }
        // Console.WriteLine("Forcing garbage collection...");
        // GC.Collect();
        // GC.WaitForPendingFinalizers();
        // Console.WriteLine("Garbage collection completed.");





        // // Anonymous
        // (int,string) s1 = (101,"Amit"); //tuple
        // Console.WriteLine(s1.GetType());

        // var s2=(Id:101,Name:"Amit"); //tuple
        // Console.WriteLine(s2.GetType());

        // // Anonymous type
        // var s3 = new
        // {
        //     Id=101,
        //     Name="Amit"
        // };
        // Console.WriteLine(s3.GetType());





        
        // Console.WriteLine(Ano.Calculate(3,2));






        // int[] num = {1,2,3,4,5,6,7,8,9};
        // var x = num.Where(n=> n%2==0);
        // foreach(var a in x)
        // {
        //     Console.WriteLine(a);
        // }



        // List<Employee> l1 = new List<Employee>
        // {
        //     new Employee{Name="Amit",Salary=70000},
        //     new Employee{Name="Amit",Salary=65000},
        //     new Employee{Name="Amit",Salary=75000},
        //     new Employee{Name="Amit",Salary=50000}
        // };
        // var des = l1.OrderByDescending(e=>e.Salary);
        // foreach(var a in des)
        // {
        //     Console.WriteLine(a.Salary);
        // }






        // using (ResourceHandler handler = new ResourceHandler())
        // {
        //     Console.WriteLine("Using resource...");
        // } // dispose will called automatically
        // Console.WriteLine("End of program.");







        // Console.WriteLine($"Total Memory Before GC: {GC.GetTotalMemory(false)} bytes");
        // for (int i = 0; i < 10000; i++)
        // {
        //     object obj = new object(); // Gen 0 allocation
        // }
        // Console.WriteLine($"Total Memory After Object Creation: {GC.GetTotalMemory(false)} bytes");
        // GC.Collect();
        // GC.WaitForPendingFinalizers();
        // Console.WriteLine($"Total Memory After GC: {GC.GetTotalMemory(false)} bytes");
        // Console.WriteLine($"Generation of a new object: {GC.GetGeneration(new object())}");









        
    }
}

class Employee
{
    public string Name{get;set;}
    public int Salary{get;set;}
}