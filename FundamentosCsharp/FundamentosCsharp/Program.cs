using System;
using System.Diagnostics;

namespace Application
{
    public class Program
    {

        static void Main(string[] args)
        {
            Conversores();
        }        
        private static void Conversores()
        {
            var convert = new Conversores.Conversor();
            convert.ConvertAndParse();
        }
    }
}