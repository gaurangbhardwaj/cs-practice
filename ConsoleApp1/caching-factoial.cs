using System;
using System.Collections.Generic;

public class Test
{
    static Dictionary<int, int> cache = new Dictionary<int, int>();
    private int factorial(int num){
        if(num <= 1) return 1;
        if(cache.ContainsKey(num)){ 
            Console.WriteLine("\nShowing Cached value!");
            return cache[num];
        };

        Console.WriteLine("\nWait need to calculate...");

        int fact = 1;
        for(int i=1; i<=num; i++){
            fact *= i;
        }
        cache.Add(num, fact);
        return fact;
    }
    static void Main()
    {
        Console.WriteLine(new Test().factorial(6));
        Console.WriteLine(new Test().factorial(6));
        Console.WriteLine(new Test().factorial(6));
        Console.WriteLine(new Test().factorial(5));
        Console.WriteLine(new Test().factorial(5));
        Console.WriteLine(new Test().factorial(5));
        Console.WriteLine(new Test().factorial(6));
        Console.WriteLine(new Test().factorial(7));

    }
}
