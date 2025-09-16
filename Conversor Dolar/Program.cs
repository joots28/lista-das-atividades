using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1º passo - Declarar as variaveis
            float cotacaoDolar, quantiaDolar, totalReais;

            //2º passo - receber os valores (entrada)
            Console.WriteLine(" bem vindo ao conversor de Dolares para Reais");

            Console.Write("digite a cotação atual do dolar");
            cotacaoDolar = float.Parse(Console.ReadLine());

            Console.Write("digite a quantia a ser convertida");
            quantiaDolar = float.Parse(Console.ReadLine());

            //3º passo - processamento 
            totalReais = quantiaDolar * cotacaoDolar;

            // 4º passo (saída)
            Console.WriteLine(" o valor convertido é : " + totalReais);




            Console.ReadKey();
            
           




        }
    }
}
