// See https://aka.ms/new-console-template for more information
using Core;

Console.WriteLine("Hello, World!");


int resultado1 = Methods.SomarArray(10, 10, 10, 10, 10);
Console.WriteLine($"Resultado da Soma 01: {resultado1}");

int[] numerosParaSomar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int resultado2 = Methods.SomarArray(numerosParaSomar);
Console.WriteLine($"Resultado da Soma 02: {resultado2}");

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
