using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloExceptions
{
    public class TrabalhandoComExceptions
    {
        public void AulaGerandoExceptions() 
        {
            while (true) 
            {
                Console.WriteLine("Informe um número: ");
                var numero = Console.ReadLine();
                
                var resultado = 500 / int.Parse(numero); 
                Console.WriteLine($"O resultado é: {resultado}"); 
            }
        }
        public void AulatratandoExceptions() 
        {
            while (true) 
            {
                try
                {
                    Console.WriteLine("Informe um número: ");
                    var numero = Console.ReadLine();

                    var resultado = 500 / int.Parse(numero);
                    Console.WriteLine($"O resultado é: {resultado}");
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro: " + ex.Message);
                }
            }
        }
    }
}
