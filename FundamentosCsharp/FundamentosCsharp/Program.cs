using System;
using System.Diagnostics;

namespace Application
{
    public class Program
    {

        static void Main(string[] args)
        {
            //AulasWhere();
            AulasOrderBys();
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
    }
}