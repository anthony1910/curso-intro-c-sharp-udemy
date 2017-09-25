using System;

public class Class2
{
	public Class2()
	{
        char ch = 'A';
        Console.WriteLine(ch);
        Console.ReadKey();

        char ch = '\'';
        Console.WriteLine(ch);
        Console.ReadKey();

        string str = "Hello\nWorld"; // quebra de linha
        Console.WriteLine(str);
        Console.ReadKey();

        Console.WriteLine("Hello\bWorld"); // backspace
        Console.ReadKey();

        Console.WriteLine("Hello\tWorld"); // tab
        Console.ReadKey();
    }
}
