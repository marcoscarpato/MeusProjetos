using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Contador
{
    static class Program
    {
        private const int index = 0;

        static void Main(string[] args)

        {
            Console.WriteLine("Bem vindo ao Contador Mil Grau");
            Console.WriteLine("Quer contar até que numero?");
            var numeroEscolhido = Console.ReadLine();
            var valorValido = ValidaValor(numeroEscolhido);
            Resolucao(valorValido);
            Console.WriteLine("pressione qualquer tecla para sair");
            Console.ReadKey();
        }

        static int ValidaValor(string numeroEscolhido)

        {
            
            try

            {
                var valorConvertido = int.Parse(numeroEscolhido);
                return valorConvertido;
            }
            catch (Exception e)
            {
                Console.WriteLine("Porfavor digite apenas numeros");
                var numeroNovo = Console.ReadLine();
                return ValidaValor(numeroNovo);
            }
        }

        static void Resolucao(int valorFinal)

        {
            var index = 0;
            Console.WriteLine("Eae chavao, sua contgem vai começar");
            
            while (index <= valorFinal)
            {
                Console.WriteLine(index);
                index++;
            }
            
        }
    }
}