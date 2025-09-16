using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conveter_Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1º Passo declarar as variaveis
            float temperaturaC, temperaturaF;

            //2º passo - Receber os valores (ENTRADAS)
            Console.WriteLine("conversor de temperatura");


            Console.Write("entre com uma temperatura em Cº:");

            temperaturaC = float.Parse(Console.ReadLine()); 

            //3º passo - processamento 
            temperaturaF = (9 * temperaturaC + 160) / 5;

            //4º passo - saída
            Console.Write(" a temperatura em Fahrenheit é:  " + temperaturaF);





          Console.ReadKey();

        }
    }
}
