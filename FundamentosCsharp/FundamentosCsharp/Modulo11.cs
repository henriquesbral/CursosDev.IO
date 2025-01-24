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

        public void AulaSubtraindoDatas()
        {
            var date1 = DateTime.Now;
            var date2 = DateTime.Parse("2024-01-24");

            var diff = date1 - date2; // ou date1.Subtract(date2);

            Console.WriteLine("A diferença de dias é: " + diff.TotalDays);
            Console.WriteLine("A diferença de horas é: " + diff.TotalHours);
        }

        public void AulaAddDiasMesAno()
        {
            var date1 = DateTime.Now;

            Console.WriteLine("Adicionando dia na dataAtual - " + date1.AddDays(1));
            Console.WriteLine("Adicionando mês na dataAtual - " + date1.AddMonths(2));
            Console.WriteLine("Adicionando ano na dataAtual - " + date1.AddYears(1));
        }
        public void AulaAddHoraMinSeg()
        {
            var date1 = DateTime.Now;

            Console.WriteLine("Adicionando hora na dataAtual - " + date1.AddHours(1).ToString("HH:mm:ss"));
            Console.WriteLine("Adicionando minuto na dataAtual - " + date1.AddMinutes(50).ToString("HH:mm:ss"));
            Console.WriteLine("Adicionando segundos na dataAtual - " + date1.AddSeconds(10).ToString("HH:mm:ss"));
        }
    }

}
