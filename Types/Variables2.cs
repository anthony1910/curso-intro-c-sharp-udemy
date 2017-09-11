using System;

class Variable
{
    static void Main(string[] args)
    {
        string result = GetName(-1);
        Console.WriteLine(result);
        Console.ReadKey();
    }

    public static string GetName(int ID)
    {
        if (ID >= 0 && ID < names.Length)
            return names[ID];
        else
            return String.Empty;
    }

    private static string[] names = { "Rafael", "João", "Glaucio" };

}
