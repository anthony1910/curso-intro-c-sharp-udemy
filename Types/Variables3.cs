using System;

class Variables3
{
    static void Main(string[] args)
    {
        // Testando conversão de tipos de variáveis
        //byte b = 255; //Valor máximo de um byte
        int i = 256; //OK
        byte b = (byte)i;

        Console.WriteLine(b);
        Console.ReadKey();
    }
}
