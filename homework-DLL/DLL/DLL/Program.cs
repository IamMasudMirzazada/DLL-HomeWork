using DLLLibrary1;
using System;

namespace DLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine(cal.Ferq(10,7));
            Console.WriteLine(cal.Sum(2,3));
            Console.WriteLine(cal.Vurma(4,5));
            Console.WriteLine(cal.Qismet(30,6));
        }
    }
}
