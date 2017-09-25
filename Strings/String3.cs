using System;

public class Class3
{
	public Class3()
	{
        string name = "Rafael";
        string name2 = String.Format("Name: {0} Hour: {1:hh}", name, DateTime.Now);
        Console.WriteLine(name2);
        Console.ReadKey();

        // Tabuada
        Console.WriteLine("Enter a number");
        string input = Console.ReadLine();

        int j;
        System.Int32.TryParse(input, out j);

        string s;
        for (int i = 0; i <= 10; i++)
        {
            s = String.Format("{0} x {1} = {2}", j, i, (i * j));
            Console.WriteLine(s);
        }
        Console.ReadKey();
    }
}
