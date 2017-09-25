using System;

public class Class1
{
	public Class1()
	{
        /*
        string a = "\u0068ello ";
        string b = "world";

        Console.WriteLine(a + b);
        Console.WriteLine(a + b == "Hello World"); // retorna false pois é case-sensitive

        Console.ReadKey();
        */

        string s1 = "Hello ";
        string s2 = s1;
        s1 += "world";

        Console.WriteLine(s2);
        Console.ReadKey();
    }
}
