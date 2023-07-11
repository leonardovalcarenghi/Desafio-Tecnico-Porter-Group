using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Methods
    {

        public static string ObterNumeroPorExtenso(int numero)
        {
            string[] unidades = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string[] dezenas = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            string[] centenas = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

            if (numero is < 0 or > 999)
                throw new ArgumentException("O número deve estar entre 0 e 999.");

            if (numero is 0)
                return "zero";

            if (numero < 20)
                return unidades[numero];

            if (numero < 100)
                return dezenas[numero / 10] + (numero % 10 == 0 ? "" : $" e {ObterNumeroPorExtenso(numero % 10)}");

            //if (numero < 100)
            //    return dezenas[numero / 10] + (numero % 10 != 0 ? " e " + ObterNumeroPorExtenso(numero % 10) : "");

            return centenas[numero / 100] + (numero % 100 != 0 ? " e " + ObterNumeroPorExtenso(numero % 100) : "");

        }

    }
}
