using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    public class Conversor
    {
        public void ConvertAndParse()
        {
            //int numero = int.Parse("1");//primeira forma de conversão
            int numero = Convert.ToInt32("1"); //segunda forma de conversão
            Console.WriteLine(numero);
        }
    }
}
