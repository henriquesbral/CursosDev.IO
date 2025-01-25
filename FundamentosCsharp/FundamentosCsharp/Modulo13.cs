using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloArquivos
{
    public class Arquivos
    {
        public void AulaCriandoArquivos()
        {
            var escrever = new StreamWriter("C:\\Logs\\AulaCriandoArquivos\\Cadastro.txt", true);
            Console.WriteLine("Informe o nome da pessoa: ");
            var nome = Console.ReadLine(); 
            escrever.WriteLine("-------------------Realizando um cadastro de pessoa-------------------");
            escrever.WriteLine("ID...: " + Random.Shared.Next(1, 100)); //Estou gerando um numero aleatório entre 1 e 100
            escrever.WriteLine("Nome...: " + nome);
            escrever.WriteLine("-------------------");
            escrever.Close();
        }
    }
}
