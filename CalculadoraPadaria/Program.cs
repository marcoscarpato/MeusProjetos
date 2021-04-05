using System;
using System.Runtime.ConstrainedExecution;

namespace CalculadoraPadaria
{
    
}
    

 static class Program
{
    private const float pesoPao = 0.25f;
    private const float preçoPao = 5.00f;
    private const float valorPao = 0.125f;


    static void Main(string[] args)
    {
        Console.WriteLine("Eae parceiro, vai levar quantos paozin");
        var numeroDePaes = Console.ReadLine();
        var valorPagar = Calcular(numeroDePaes);
        
        Console.WriteLine("ta ai sua conta chefe");
        Console.WriteLine("R$ " +valorPagar);
        Console.ReadKey();


    }

    private static float Calcular(string numeroDePaes)
    {
        try
        {
            float valorConvertido = float.Parse(numeroDePaes);
            var valorTotal = valorConvertido * valorPao;
            return valorTotal;

        }
        catch (Exception e)
        {
            Console.WriteLine("Fala a quantidade certa ai cuzao");
            var resposta = Console.ReadLine();
            return Calcular(resposta);
        }


    }



}