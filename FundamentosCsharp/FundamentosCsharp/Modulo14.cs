using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLinq
{
    public class TrabalhandoComLinq
    {
        public void AulaWhere() 
        {
            //string nomeCompleto = "CARLOS SOBRAL";

            //Func<char, bool> filtro = c => c == 'A'; //metodo 1

            ////var resultado = nomeCompleto.Where(i => i == 'A'); //metodo 2 sintaxe de método

            ////var resultado = nomeCompleto.Where(filtro);

            //var resultado = from c in nomeCompleto where c == 'S' select c; //metodo 4 - sintaxe de consulta

            //foreach (var letra in resultado)
            //{
            //    Console.WriteLine(letra);
            //}

            var numeros = new int[] { 1, 2, 3, 4, 5, 6 };
            var resultado = numeros.Where(x => x > 1);

            foreach (var x in resultado)
            {
                Console.WriteLine(x);
            }
        }
        public void AulaOrderBy() 
        {
            var numeros = new int[] { 1, 2, 3, 4, 5, 6 };
            var resultado = numeros.OrderBy(x => x);
            var resultado2 = numeros.OrderByDescending(x => x);

            foreach (var x in resultado)
            {
                Console.WriteLine(x);
            }
            foreach (var x in resultado2)
            {
                Console.WriteLine(x);
            }
        }
    }
}
