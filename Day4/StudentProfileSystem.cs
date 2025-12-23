// EXTENDED TASK: Advanced Properties in C#
// Task Title

// Student Profile System – Advanced Property Types

// Objective

// To understand and implement:

// Normal properties with validation

// Auto-implemented properties

// Read-only properties

// Write-only properties

// Base Scenario

// You are developing a Student Profile System for a college application.

// Each student has:

// Name

// Age

// Marks

// Student ID

// Password

// Different data requires different access rules.

// PART A: Auto-Implemented Property
// Requirement

// Store the Student ID.

// Rules:

// No validation required

// Direct get and set allowed

// Task Instruction

// Use an auto-implemented property.

// Hint

// Auto-implemented properties do not require a private backing field.

// PART B: Read-Only Property
// Requirement

// Calculate Result Status based on marks.

// Rules:

// Marks ≥ 40 → “Pass”

// Marks < 40 → “Fail”

// Value should be readable

// Value should NOT be set from outside

// Task Instruction

// Create a read-only property.

// PART C: Write-Only Property
// Requirement

// Store Password securely.

// Rules:

// Password can be set

// Password must NOT be readable

// Password length must be at least 6 characters

// Task Instruction

// Create a write-only property.

// PART D: Normal Property with Validation (Revision)
// Requirement

// Name cannot be empty

// Age must be greater than 0

// Marks must be between 0 and 100





using System;
class Student
{
    public int RegNo{get;private set;}
    public Student(int reg)
    {
        RegNo=reg;
    }
    public int StudentId{get;set;}

    private int marks;
    public int Marks
    {
        get{return marks;}
        set
        {
            if(value>=0 && value <= 100)
            {
                marks=value;
            }
        }
    }
    public string ResultStatus
    {
        get
        {
            return marks>=40?"Pass":"Fail";
        }
    }
    private string name=""; //no null value allowed
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if(!string.IsNullOrEmpty(value)){
                name=value;
            }
        }
    }
    private int age;
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value > 0)
            {
                age=value;
            }
        }
    }
    private string password=""; //no null value allowed
    public string Password
    {
        set
        {
            if (value.Length >= 6)
            {
                password=value;
            }
        }
    }
    public int AddYear{get;init;}
    public double Percentage => (Marks/100.00)*100;
}