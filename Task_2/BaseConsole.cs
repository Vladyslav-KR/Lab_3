using System;
using System.Text;

public static class BaseConsole
{
    public static void Initialize()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
    }
}

