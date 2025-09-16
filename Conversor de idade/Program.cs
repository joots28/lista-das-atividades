using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1º declarar variaveis 
            float ano_de_nascimento, anoAtual, idadeTotal;

            //2º receber os valores - (ENTRADA)
            Console.WriteLine(" Bem vindo ao Conversor de idade!!!");

            Console.Write("digite um ano de nascimento: ");

            ano_de_nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o ano atual :");

            anoAtual = int.Parse(Console.ReadLine());
            //3º passo - processamento 


            idadeTotal = anoAtual - ano_de_nascimento;

            //4º passo - saída
            Console.WriteLine("A idade que você procura é :" + idadeTotal); 
           



            Console.ReadKey();

        }
    }
}
