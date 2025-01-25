using System;
using System.Diagnostics;

namespace Application
{
    public class Program
    {

        static void Main(string[] args)
        {
            TrabalhandoComException();
        }
        
        private static void TrabalhandoComException()
        {
            var trab = new ModuloExceptions.TrabalhandoComExceptions();

            //trab.AulaGerandoExceptions();
            trab.AulatratandoExceptions();
        }

    }
}