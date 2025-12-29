using System;
class Analyzer
{
    public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
    {
        try{
            double riskFactor;
            if (machineryState == "Worn")
            {
                riskFactor=1.3;
            }
            else if (machineryState == "Faulty")
            {
                riskFactor=2.0;
            }
            else if (machineryState == "Critical")
            {
                riskFactor=3.0;
            }
            else
            {
                throw new RobotSafetyException("Error: Unsupported machinery state.");
            }
            if(armPrecision<0.0 || armPrecision > 1.0)
            {
                throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0");
            }
            if(workerDensity<1 || workerDensity > 20)
            {
                throw new RobotSafetyException("Error: Worker density must be 1-20.");
            }
            
            double risk=((1.0-armPrecision)*15.0)+(workerDensity*riskFactor);
            return risk;
        }catch(RobotSafetyException ex)
        {
            ex.Print();
            return -1;
        }
    }
}

class RobotSafetyException : Exception
{
    public RobotSafetyException(string message) : base(message){}
    public void Print()
    {
        Console.WriteLine(Message);
    }
}