using System;

static class Program
{
    private const int anoAtual = 2021;
    private const int idadeMinima = 18;
    
    private static void Main(string[] args)
    {
        Console.WriteLine("Qual ano você nasceu?");
        var anoNascimento = Console.ReadLine();
        var isIdadeValida = VerificaIdade(anoNascimento);

        Console.WriteLine(isIdadeValida
            ? "Você pode comprar bebida alcoolica"
            : "Você não pode comprar bebida alcoolica");
        Console.ReadKey();
        
    }

    private static bool VerificaIdade(string anoNascimento)
    {
        try
        {
            var valorConvertido = int.Parse(anoNascimento);
            var resultado = anoAtual - valorConvertido;
            
            return idadeMinima <= resultado;

        }
        catch (Exception e)
        {
            Console.WriteLine("Porfavor, digite apenas numeros");
            Console.WriteLine("Qual ano você nasceu?");
            var resposta = Console.ReadLine();
            return VerificaIdade(resposta);

        }
        
        
    }

}