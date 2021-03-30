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

        if (isIdadeValida)
        {
            Console.WriteLine("Você pode comprar bebida alcoolica");
        }
        else
        {
            Console.WriteLine("Você não pode comprar bebida alcoolica");
        }
    }

    private static bool VerificaIdade(string anoNascimento)
    {
        return false;
    }

}