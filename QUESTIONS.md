# Questões

#### 1. Como você implementou a função que retorna a representação por extenso do número no desafio 1? Quais foram os principais desafios encontrados?

Para resolver o problema eu utilizei a criação de três _arrays_ contendo as nomenclaturas dos nossos números em português.

- Uma _array_ para unidades de 1 à 19.
- Uma _array_ para as dezenas de 20, 30, 40, 50, 60, 70, 80 e 90.
- Uma _array_ para as centenas de 100, 200, 300, 400, 500, 600, 700, 800 e 900.

Após isso, eu fiz validações para:
- Impedir um número menor que 0;
- Impedir um número maior que 999;
- Caso um número seja 0, retornar diretamente "zero";


Se o número no parâmetro for menor que 20, ele faz a leitura do nome por extenso usando o próprio número como a _index_ do _array_.

> Todas as arras começam no 1 para facilitar a leitura, ou seja, o _index_ 0 (zero) de todas as _arrays_ é uma _string_ vazia.

Para números entre 20 e 99, eu divido o número do parâmetro por 10, para ter a _index_ da _array_ de dezenas.
Depois utilizando a própria função recursivamente, eu obtenho a unidade.

> Para isso eu utilizei um _operador de resto_ para ter acesso ao restante da divisão realizada.

Para números entre 100 e 999 a mesma regra mencionada acima é aplicada. Somente alterando a divisão por 100 em vez de 10.

```csharp
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
```
<br />
<hr />

### 2. Como você lidou com a performance na implementação do desafio 2, considerando que o array pode ter até 1 milhão de números?

Implementei a soma dos _inteiros_ utilizando _System.Linq_, independente de quantos itens a _array_ possuir, todos serão somados.

```csharp
public static int SomarArray(params int[] array)
{
    int result = array.Sum();
    return result;
}
```

<br />
<hr />

### 3. Como você lidou com os possíveis erros de entrada na implementação do desafio 3, como uma divisão por zero ou uma expressão inválida?

Para implementar, eu utilizei um _System.Data.DataTable_ que consegue receber e resolver expressões aritméticas e retornar como se fosse uma leitura no banco de dados.

Para verificar se a expressão é válida, eu criei uma _array_ contendo os operadores aritméticos que a expressão deveria conter.

Implementei também a validação se a empressão contém letras, para não deixar o método continuar.


```csharp
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
```

<br />
<hr />

### 4. Como você implementou a função que remove objetos repetidos na implementação do desafio 4? Quais foram os principais desafios encontrados?

Eu criei uma _interface_ chamada **IObject** com uma _propriedade_ chamada **Legenda** e 3 _classes_ que implementam essa _interface_.

Fiz um método que recebe uma lista de classes que possue o **IObject** implementado.
<br>
Dentro desse método eu faço:
- Um _GroupBy_ pela **Legenda**.
- Um _Select_ _First_ para obter o primeiro item da lista encontrado.
- Converto tudo em uma nova lista.


```csharp
public static List<IObject> ObterObjetosUnicos(List<IObject> list)
{
    if (list is null)
        throw new ArgumentException("Lista é nula.");

    List<IObject> itensUnicos = list.GroupBy(x => x.Legenda).Select(y => y.First()).ToList();
    return itensUnicos;
}
```