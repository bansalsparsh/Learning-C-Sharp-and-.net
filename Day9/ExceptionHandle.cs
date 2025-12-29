using System;
using System.IO;
class InsufficientBalanceException: Exception
{
    public InsufficientBalanceException(string message) : base (message) { }
}
class BankAccount : Exception
{
    public decimal Balance {get; private set;}

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative", nameof(initialBalance));

        Balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("Withdrawal amount must be greater than zero.");
        if (amount > Balance) throw new InsufficientBalanceException("Insufficient balance for withdrawal.");
        Balance-=amount;
        try{
            int serviceCharge=100;
            int divisionCheck = serviceCharge / int.Parse("0");

            // File Access
            string data = File.ReadAllText("account.txt");

            // Business Logic
            Console.WriteLine("Withdrawal successful.");
        }
        catch (FormatException ex)
        {
            LogException(ex);
            Console.WriteLine("Invalid input format.");
        }
        catch (DivideByZeroException ex)
        {
            LogException(ex);
            Console.WriteLine("Arithmetic error occurred.");
            Console.WriteLine(ex.StackTrace);
        }
        catch (FileNotFoundException ex)
        {
            LogException(ex);
            Console.WriteLine("Required file not found.");
        }
        catch (InsufficientBalanceException ex)
        {
            LogException(ex);
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            LogException(ex);
            Console.WriteLine("An unexpected error occurred.");
        }
        finally
        {
            Console.WriteLine("Transaction attempt completed.");
        }
    }
    static void LogException(Exception ex)
    {
        File.AppendAllText("error.log",DateTime.Now+" | "+ex.GetType().Name+" | "+Environment.NewLine);
    }
}
