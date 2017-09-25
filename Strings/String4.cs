using System;

public class Class4
{
	public Class4()
	{
        // Substring e Replace
        string s1 = "Visual C# Express";
        Console.WriteLine(s1.Substring(7, 2));

        Console.WriteLine(s1.Replace("C#", "Basic"));

        Console.WriteLine(s1.IndexOf("C"));
        Console.ReadKey();
    }
}
