using System;
using System.Diagnostics;

namespace Application
{
    public class Program
    {

        static void Main(string[] args)
        {
            AulaArquivos();
        }

        private static void AulaArquivos()
        {
            var arquivo = new ModuloArquivos.Arquivos();
            arquivo.AulaCriandoArquivos();
        }
    }
}