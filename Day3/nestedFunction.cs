using System;
class Test
{
    static void Parent()
    {
        static void Child()
        {
            int a=20;
            return (long)a;
        }
    }
}