using System;
using System.Diagnostics;

namespace Application
{
    public class Program
    {

        static void Main(string[] args)
        {
            //AulasWhere();
            //AulasOrderBys();
            //AulaTakes();
            //AulaCounts();
            AulaFirts();
        }

        private static void AulasWhere()
        {
            var wherer = new ModuloLinq.TrabalhandoComLinq();
            wherer.AulaWhere(); 
        }
        private static void AulasOrderBys()
        {
            var wherer = new ModuloLinq.TrabalhandoComLinq();
            wherer.AulaOrderBy(); 
        }
        private static void AulaTakes()
        {
            var wherer = new ModuloLinq.TrabalhandoComLinq();
            wherer.AulaTake(); 
        }
        private static void AulaCounts()
        {
            var wherer = new ModuloLinq.TrabalhandoComLinq();
            wherer.AulaCount(); 
        }
        private static void AulaFirts()
        {
            var wherer = new ModuloLinq.TrabalhandoComLinq();
            wherer.AulaFirsteFirstOrDefault(); 
        }
    }
}