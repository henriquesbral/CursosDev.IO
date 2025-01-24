using System;
using System.Diagnostics;

namespace Application
{
    public class Program
    {

        static void Main(string[] args)
        {
            //TrabalhandoComDatas();
            //TrabalhandoComDiffDeDatas();
            TrabalhandAddDeDatas();
        }
        
        private static void TrabalhandoComDatas()
        {
            var dateT = new ModuloDatas.TrabalhandoComDatas();
            dateT.AulaDateTime();
        }
        private static void TrabalhandoComDiffDeDatas()
        {
            var dateT = new ModuloDatas.TrabalhandoComDatas();
            dateT.AulaSubtraindoDatas();
        }
        private static void TrabalhandAddDeDatas()
        {
            var dateT = new ModuloDatas.TrabalhandoComDatas();
            dateT.AulaAddDiasMesAno();
        }


    }
}