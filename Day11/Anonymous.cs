using System;
class Ano
{
    public static (int Sum, int Average, int sub) Calculate (int a, int b)
    {
        //this is tuple storing (a+b) in sum and other in average
        return (a + b, (a + b) / 2, a-b) ;
    }
}