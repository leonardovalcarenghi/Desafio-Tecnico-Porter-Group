// See https://aka.ms/new-console-template for more information
using Core;
using Core.Interfaces;

Console.WriteLine("Hello, World!");


//string expressaoMatemarica = "1 + 1 * 2";
//double resultadoDaExpressao = Methods.CalcularExpressao(expressaoMatemarica);

int resultado1 = Methods.SomarArray(10, 10, 10, 10, 10);
Console.WriteLine($"Resultado da Soma 01: {resultado1}");

int[] numerosParaSomar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int resultado2 = Methods.SomarArray(numerosParaSomar);
Console.WriteLine($"Resultado da Soma 02: {resultado2}");




List<Object01> list01 = new() { new Object01(), new Object01(), new Object01() };
List<Object02> list02 = new() { new Object02(), new Object02() };
List<Object03> list03 = new() { new Object03(), new Object03(), new Object03(), new Object03() };
List<IObject> list = new();
list.AddRange(list01);
list.AddRange(list02);
list.AddRange(list03);

List<IObject> result = Methods.ObterObjetosUnicos(list);

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
