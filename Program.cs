using System;
using POO_Static.classes;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bem Vindo Ao Mark Conversor");
            Console.WriteLine("Digite um valor :");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());

            Console.WriteLine("Conversão de dolar pra real é : " + Conversor.ConverterDolarParaReal() + " reais");

             Console.WriteLine("Conversão de real pra dolar é : " + Conversor.ConverterRealParaDolar() + " dolares");

             Console.WriteLine("Conversão de euro pra real é : " + Conversor.ConverterEuroParaReal() + " reais");

             Console.WriteLine("Conversão de real pra euro é : " + Conversor.ConverterRealParaEuro() + " euros");
            


            // By:Mark
        }
    }
}