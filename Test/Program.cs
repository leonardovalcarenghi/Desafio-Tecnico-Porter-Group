// See https://aka.ms/new-console-template for more information
using Core;
using Core.Interfaces;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("");
Console.WriteLine("Desafio Porter Group");
Console.WriteLine("Desenvolvido por Leonardo Valcarenghi");


Console.WriteLine("");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("");

{
    // Desafio 01:
    Console.WriteLine("-> DESAFIO 01");
    Console.WriteLine($"Número '01': {Methods.ObterNumeroPorExtenso(1)}");
    Console.WriteLine($"Número '20': {Methods.ObterNumeroPorExtenso(20)}");
    Console.WriteLine($"Número '88': {Methods.ObterNumeroPorExtenso(88)}");
    Console.WriteLine($"Número '537': {Methods.ObterNumeroPorExtenso(537)}");
    Console.WriteLine($"Número '999': {Methods.ObterNumeroPorExtenso(999)}");
}

Console.WriteLine("");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("");

{
    // Desafio 02:
    Console.WriteLine("-> DESAFIO 02");
    Console.WriteLine($" Somar números 2, 4, 6, 8, 10 = {Methods.SomarArray(2, 4, 6, 8, 10)}");
    Console.WriteLine($" Somar números 7, 16, 31 = {Methods.SomarArray(new int[] { 7, 16, 31 })}");
}

Console.WriteLine("");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("");

{
    // Desafio 03:
    Console.WriteLine("-> DESAFIO 03");
    List<IObject> listaDeObjetos = new() {
        new Object01(), new Object01(), new Object01(),
        new Object02(), new Object02(), new Object02(), new Object02(),
        new Object03(), new Object03(), new Object03(), new Object03(), new Object03()
};
    List<IObject> listaDeObjetosUnicos = Methods.ObterObjetosUnicos(listaDeObjetos);

    Console.WriteLine($"Total de objetos na lista: {listaDeObjetos.Count}");
    Console.WriteLine($"Total de objetos unícos na lista: {listaDeObjetosUnicos.Count}");
    listaDeObjetosUnicos.ForEach(objeto => { Console.WriteLine($"Legenda do objeto: {objeto.Legenda}"); });

}

Console.WriteLine("");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("");

{
    // Desafio 04:
    Console.WriteLine("-> DESAFIO 04");
    Console.WriteLine($"Expressão: 2 + 3 * 5 = {Methods.CalcularExpressao("2 + 3 * 5")}");
    Console.WriteLine($"Expressão: 1 + 2 + 3 + 4 + 5 * 2 / 3 = {Methods.CalcularExpressao("1 + 2 + 3 + 4 + 5 * 2 / 3")}");
}


Console.ReadKey();
