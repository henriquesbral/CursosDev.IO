using System;
using System.Diagnostics;

namespace Application
{
    public class Program
    {

        static void Main(string[] args)
        {
            //AulaCriandoArquivos();
            //AulaLendoArquivos();
            AulaExcluirArquivos();
        }

        private static void AulaCriandoArquivos()
        {
            var arquivo = new ModuloArquivos.Arquivos();
            arquivo.AulaCriandoArquivo();
        }
        private static void AulaLendoArquivos()
        {
            var arquivo = new ModuloArquivos.Arquivos();
            arquivo.AulaLendoUmArquivo();
        }
        private static void AulaExcluirArquivos()
        {
            var arquivo = new ModuloArquivos.Arquivos();
            arquivo.AulaExcluindoArquivo();
        }
    }
}