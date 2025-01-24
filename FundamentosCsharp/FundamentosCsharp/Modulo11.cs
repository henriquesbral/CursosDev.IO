using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDatas
{
    public class TrabalhandoComDatas
    {
        public void AulaDateTime()
        {
            var date1 = new DateTime(2025, 01, 23, 23, 34, 23);
            var date2 = DateTime.Parse("2022/12/23 19:25:25");
            var date3 = DateTime.Now;
            var date4 = DateTime.Today;

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date4);

            Console.WriteLine("Data Formatada: " + date1.ToString("yyyy-dd-MM HH-mm-ss"));
            var dateOffste1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3,0,0)); //transformando a hora no padrao brasileiro
            Console.WriteLine(dateOffste1.LocalDateTime);
            Console.WriteLine(dateOffste1.UtcDateTime);
        }
    }

}
