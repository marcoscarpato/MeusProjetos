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
    }

    private static bool VerificaIdade(string anoNascimento)
    {
        var valorConvertido = int.Parse(anoNascimento);
        var resultado = anoAtual - valorConvertido;

        return idadeMinima <= resultado;
        
    }

}