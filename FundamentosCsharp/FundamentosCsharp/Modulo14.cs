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
        public void AulaTake() 
        {
            var numeros = new int[] { 1, 2, 3, 4, 5, 6 };
            var resultado = numeros.Take(3); //pegando os tres primeiros numeros
            var resultado2 = numeros.Take(3).OrderBy(x => x); //pegando os tres primeiros numeros e ordernando crescente
            var resultado3 = numeros.Where(x => x > 3).Take(3).OrderBy(x => x); //filtrando numeros maior que 3, pegando os tres após esse filtro e ordenando em crescente
        }
        public void AulaCount()
        {
            var numeros = new int[] { 1, 2, 3, 4, 5, 6 };
            var resultado = numeros.Count();
            Console.WriteLine(resultado);

            var resultado2 = numeros.Count(x => x > 2);
        }
        public void AulaFirsteFirstOrDefault()
        {
            var numeros = new int[] { 1, 2, 3, 4, 5, 6 };
            var resultado = numeros.First();
            Console.WriteLine(resultado);

            var resultado2 = numeros.FirstOrDefault(x => x > 2);
            Console.WriteLine(resultado2);
        }
    }
}
