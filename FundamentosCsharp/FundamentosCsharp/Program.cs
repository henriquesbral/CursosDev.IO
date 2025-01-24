using System;
using System.Diagnostics;

namespace Application
{
    public class Program
    {

        static void Main(string[] args)
        {
            TrabalhandoComDatas();
        }
        
        private static void TrabalhandoComDatas()
        {
            var dateT = new ModuloDatas.TrabalhandoComDatas();
            dateT.AulaDateTime();
        }
    }
}