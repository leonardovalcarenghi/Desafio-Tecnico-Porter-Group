// See https://aka.ms/new-console-template for more information
using Core;

Console.WriteLine("Hello, World!");




void DigitarNumero()
{

    Console.WriteLine("Escreva um número:");
    string? numero = Console.ReadLine();
    if (!string.IsNullOrEmpty(numero) && numero.Any(char.IsDigit))
    {
        string numeroPorExtenso = Methods.ObterNumeroPorExtenso(int.Parse(numero));
        Console.WriteLine($"> Resposta: {numeroPorExtenso}");
    }
    Console.WriteLine("");
    DigitarNumero();
}

DigitarNumero();
Console.ReadKey();
