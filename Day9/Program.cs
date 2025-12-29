// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         // int a=10,b=0;
//         // try
//         // {
//         //     int res=a/b;
//         // }catch(Exception e)
//         // {
//         //     Console.WriteLine(e.Message);
//         // }



        
//         // BankAccount ba = new BankAccount();
//         // ba.Withdraw(4000);



//         // FileStream file = null!;
//         // try
//         // {
//         //     file = new FileStream("data.txt", FileMode.Open);

//         //     // Perform file operations
//         //     int data = file.ReadByte();
//         //     Console.WriteLine(data);
//         // }
//         // catch (FileNotFoundException ex)
//         // {
//         //     Console.WriteLine("File not found: " + ex.Message);
//         // }
//         // finally
//         // {
//         //     if (file != null)
//         //     {
//         //         file.Close(); // Ensures file is always closed
//         //         Console.WriteLine("File stream closed in finally block.");
//         //     }
//         // }



        


//         // try
//         // {
//         //     try
//         //     {
//         //         File.ReadAllText("transactions.txt");
//         //     }
//         //     catch (IOException ioEx)
//         //     {
//         //         throw new ApplicationException(
//         //             "Unable to load transaction data",
//         //             ioEx
//         //         );
//         //     }
//         // }
//         // catch (Exception ex)
//         // {
//         //     Console.WriteLine("Message: " + ex.Message);
//         //     Console.WriteLine("Root Cause: " + ex.InnerException.Message);
//         // }





//         BankAccount bank = new BankAccount(2000);
//         bank.Withdraw(300);
//     }
// }