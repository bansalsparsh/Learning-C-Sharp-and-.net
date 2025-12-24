using System;
class NullableClass
{
    public static void NullMethod()
    {

        // ?. this prevents null reference access in object
        int? price=3;   // ? represents that price can store either int or null values;
        price=price??100;  // ??(Null coalescing) represents that if price is null assign it the default value(100)
        Console.WriteLine(price);
    }
}