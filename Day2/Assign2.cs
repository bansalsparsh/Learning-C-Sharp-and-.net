// Mini Project: Finance Management System (C#)

// ⸻

// 1. Problem Statement (Verified)

// The aim of this project is to develop a menu-driven finance management system using C#, demonstrating the use of classes, functions, loops, conditional statements, and switch-case.
// The project is divided into Debit and Credit operations, each handling distinct financial activities related to money outflow and inflow.

// ⸻

// 2. Project Rules (Validated)
// 	1.	Two classes are used:
// 	•	Debit
// 	•	Credit
// 	2.	Each class contains exactly four different functions.
// 	3.	Menu navigation is implemented using switch-case.
// 	4.	Decision making is implemented using if–else and logical operators.
// 	5.	Loops are used for repetitive calculations.
// 	6.	Program executes until the user selects Exit.

// ⸻

// 3. Class: Debit (Money Outflow Operations)

// The Debit class handles financial activities where money is spent, deducted, or restricted.

// ⸻

// Function 1: ATM Withdrawal Limit Validation

// Purpose:
// To verify whether the withdrawal amount is within the daily ATM limit.

// Rules / Logic:
// 	•	User enters withdrawal amount.
// 	•	Daily withdrawal limit is fixed (₹40,000).
// 	•	If withdrawal amount ≤ limit → allowed.
// 	•	If withdrawal amount > limit → rejected.

// Expected Output:
// 	•	“Withdrawal permitted within daily limit.”
// 	•	OR
// 	•	“Daily ATM withdrawal limit exceeded.”

// ⸻

// Function 2: EMI Burden Evaluation

// Purpose:
// To determine whether a customer can manage a loan EMI.

// Rules / Logic:
// 	•	User enters monthly income.
// 	•	User enters EMI amount.
// 	•	EMI must not exceed 40% of monthly income.
// 	•	EMI ≤ 40% → manageable.
// 	•	EMI > 40% → financial burden.

// Expected Output:
// 	•	“EMI is financially manageable.”
// 	•	OR
// 	•	“EMI exceeds safe income limit.”

// ⸻

// Function 3: Transaction-Based Daily Spending Calculator

// Purpose:
// To calculate total spending from multiple debit transactions.

// Rules / Logic:
// 	•	User enters number of transactions.
// 	•	Loop runs for each transaction.
// 	•	Transaction amounts are summed.

// Loop Used:
// 	•	for or while loop

// Expected Output:
// 	•	“Total debit amount for the day: ₹XXXX”

// ⸻

// Function 4: Minimum Balance Compliance Check

// Purpose:
// To check whether the account maintains the required minimum balance.

// Rules / Logic:
// 	•	Minimum balance required: ₹2,000.
// 	•	User enters current balance.
// 	•	Balance < ₹2,000 → penalty applicable.
// 	•	Balance ≥ ₹2,000 → compliant.

// Expected Output:
// 	•	“Minimum balance not maintained. Penalty applicable.”
// 	•	OR
// 	•	“Minimum balance requirement satisfied.”

// ⸻

// 4. Class: Credit (Money Inflow Operations)

// The Credit class manages financial activities where money is earned, credited, or accumulated.

// ⸻

// Function 1: Net Salary Credit Calculation

// Purpose:
// To calculate the net salary credited after deductions.

// Rules / Logic:
// 	•	User enters gross salary.
// 	•	Fixed deduction of 10% is applied.
// 	•	Net salary is calculated.

// Expected Output:
// 	•	“Net salary credited: ₹XXXX”

// ⸻

// Function 2: Fixed Deposit Maturity Calculation

// Purpose:
// To calculate the maturity amount of a fixed deposit.

// Rules / Logic:
// 	•	User enters principal, rate of interest, and time period.
// 	•	Simple interest is calculated.
// 	•	Maturity amount = Principal + Interest.

// Expected Output:
// 	•	“Fixed Deposit maturity amount: ₹XXXX”

// ⸻

// Function 3: Credit Card Reward Points Evaluation

// Purpose:
// To calculate reward points based on spending.

// Rules / Logic:
// 	•	User enters total credit card spending.
// 	•	1 reward point is earned for every ₹100 spent.
// 	•	Reward points are calculated using division.

// Expected Output:
// 	•	“Reward points earned: XXXX”

// ⸻

// Function 4: Employee Bonus Eligibility Check

// Purpose:
// To determine bonus eligibility based on salary and experience.

// Rules / Logic:
// 	•	Annual salary ≥ ₹5,00,000
// 	•	Years of service ≥ 3
// 	•	Both conditions must be satisfied.

// Conditions Used:
// 	•	Logical AND (&&)

// Expected Output:
// 	•	“Employee is eligible for bonus.”
// 	•	OR
// 	•	“Employee is not eligible for bonus.”

// ⸻

// 5. Menu System (Confirmed Correct)

// Main Menu Options:
// 	1.	Debit Operations
// 	2.	Credit Operations
// 	3.	Exit

// Rules:
// 	•	Menu displayed repeatedly using a loop.
// 	•	Selection handled using switch-case.
// 	•	Exit terminates the program.

// ⸻





using System;
class Debit
{
    public static void Choices()
    {
        Console.Write("1. ATM Withdrawal Limit Validation \n2. EMI Burden Evaluation\n3. Transaction-Based Daily Spending Calculator\n4. Minimum Balance Compliance Check\n5. Exit\nEnter your Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Debit.Withdrawal();
                break;
            case 2:
                Debit.EmiEval();
                break;
            case 3:
                Debit.SpendingCal();
                break;
            case 4:
                Debit.MinBalCheck();
                break;
            case 5:
                break;
            default:
                Console.WriteLine("Invalid Choice.");
                break;            
        }
    }
    public static void Withdrawal()
    {
        Console.Write("Enter amount you wish to withdraw from ATM: ₹");
        int amount = Convert.ToInt32(Console.ReadLine());
        if (amount > 40000)
        {
            Console.WriteLine("Daily ATM withdrawal limit exceeded.");
        }
        else
        {
            Console.WriteLine($"Withdrawal permitted within daily limit.");
        }
    }
    public static void EmiEval()
    {
        Console.Write("Enter your monthly income: ₹");
        int income = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter EMI amount: ₹");
        int amount = Convert.ToInt32(Console.ReadLine());
        if (amount == (income * 0.4))
        {
            Console.WriteLine("EMI is financially manageable.");
        }
        else
        {
            Console.WriteLine("EMI exceeds safe income limit.");
        }
    }
    public static void SpendingCal()
    {
        Console.Write("Enter number of transactions: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum=0;
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Enter amount{i}: ₹");
            int amount = Convert.ToInt32(Console.ReadLine());
            sum+=amount;
        }
        Console.WriteLine($"Total debit amount for the day: ₹{sum}");
    }
    public static void MinBalCheck()
    {
        Console.Write("Enter current balance: ₹");
        int bal = Convert.ToInt32(Console.ReadLine());
        if (bal >= 2000)
        {
            Console.WriteLine("Minimum balance requirement of ₹2000 is satisfied.");
        }
        else
        {
            Console.WriteLine("Minimum balance of ₹2000 is not maintained. Penalty applicable.");
        }
    }
}
class Credit
{
    public static void Choices()
    {
        Console.Write("1. Net Salary Credit Calculation\n2. Fixed Deposit Maturity Calculation\n3. Credit Card Reward Points Evaluation\n4. Employee Bonus Eligibility Check\n5. Exit\nEnter your Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Credit.NetSalary();
                break;
            case 2:
                Credit.MaturityCal();
                break;
            case 3:
                Credit.CreditRewardPoint();
                break;
            case 4:
                Credit.EmployeeBonus();
                break;
            case 5:
                break;
            default:
                Console.WriteLine("Invalid Choice.");
                break;            
        }
    }
    public static void NetSalary()
    {
        Console.Write("Enter gross salary: ₹");
        int sal = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Net salary credited: ₹{sal-sal*0.10}");
    }
    public static void MaturityCal()
    {
        Console.Write("Enter Principal amount: ₹");
        int amount = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter rate of interest: ");
        int rate = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter time period(years): ");
        int time = Convert.ToInt32(Console.ReadLine());
        int interest = amount*rate*time/100;
        Console.WriteLine($"Fixed Deposit maturity amount: ₹{amount+interest}");
    }
    public static void CreditRewardPoint()
    {
        Console.Write("Enter total credit card spending: ₹");
        int spend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Reward points earned: {spend/100}");
    }
    public static void EmployeeBonus()
    {
        Console.Write("Enter annual salary: ₹");
        int sal = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter years of experience: ");
        int exp = Convert.ToInt32(Console.ReadLine());
        if(sal>=500000 && exp >= 3)
        {
            Console.WriteLine("Employee is eligible for bonus.");
        }
        else
        {
            Console.WriteLine("Employee is not eligible for bonus.");   
        }
    }
}
class Fin
{
    public static void F()
    {
        while(true)
        {
            Console.Write("1. Debit\n2. Credit\n3. Exit\nEnter your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    Debit.Choices();
                    break;
                case 2:
                    Credit.Choices();
                    break;
                case 3:
                    Console.WriteLine("Closed.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            if(choice == 3) break;
        }
    }
}