using Core.Interfaces;
using System.Data;
using System.Linq;

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

            return centenas[numero / 100] + (numero % 100 == 0 ? "" : $" e {ObterNumeroPorExtenso(numero % 100)}");
        }


        public static int SomarArray(params int[] array)
        {
            int result = array.Sum();
            return result;
        }

        public static decimal CalcularExpressao(string expressao)
        {
            expressao = expressao.Trim().Replace(" ", "");
            string[] operadoresAritmeticos = { "+", "-", "*", "/" };
            char[] comandos = expressao.ToCharArray();

            bool temLetra = comandos.Any(char.IsLetter);
            if (temLetra)
                throw new ArgumentException("Expressão inválida.");

            bool temComando = comandos.Any(x => operadoresAritmeticos.Contains(x.ToString()));
            if (temComando is false)
                throw new ArgumentException("Expressão inválida.");

            using (DataTable table = new())
            {
                table.Columns.Add("expressao", typeof(string), expressao);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                decimal resultado = decimal.Parse((string)row["expressao"]);
                return resultado;
            }
        }


        public static List<IObject> ObterObjetosUnicos(List<IObject> list)
        {
            if (list is null)
                throw new ArgumentException("Lista é nula.");

            List<IObject> itensUnicos = list.GroupBy(x => x.Legenda).Select(y => y.First()).ToList();
            return itensUnicos;
        }

    }
}
