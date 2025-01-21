using System;
using System.Diagnostics;

namespace Application
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Conversores();
            Conversores2();
        }
        
        private static void Conversores2()
        {
            var tryParse = new Conversores.Conversor();
            tryParse.AulaTryParse();
        }
        private static void Conversores()
        {
            var convert = new Conversores.Conversor();
            convert.ConvertAndParse();
        }
    }
}