using System;
using System.Diagnostics;

namespace Program;

class Program
{
    static void Main()
    {
        Printer uaPrinter = new UAPrinter();
        uaPrinter.Print("test");
    }
}