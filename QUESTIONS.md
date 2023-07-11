# Questões

#### 1. Como você implementou a função que retorna a representação por extenso do número no desafio 1? Quais foram os principais desafios encontrados?

Para resolver o problema eu utilizei a criação de três _arrays_ contendo as nomenclaturas dos nossos números em português.

- Uma _array_ para unidades de 1 à 19.
- Uma _array_ para as dezenas de 20, 30, 40, 50, 60, 70, 80 e 90.
- Uma _array_ para as centenas de 100, 200, 300, 400, 500, 600, 700, 800 e 900.

Após isso, eu fiz validações para:
- Impedir úm número menor que 0;
- Impedir um número maior que 999;

Foi implementado caso o número passado no parâmetro seja zero, ele retorna imediatamente o "zero".

Se o número no parâmetro for menor que 20, ele faz a leitura do nome por extenso usando o próprio número como a _index_ do _array_.

> Todas as arras começam no 1 para facilitar a leitura, ou seja, o _index_ 0 (zero) de todas as _arrays_ é uma _string_ vazia.

Para números entre 20 e 99, eu divido o número do parâmetro por 10, para ter a _index_ da _array_ de dezenas.
Depois utilizando a própria função recursivamente, eu obtanho o restante da dezena e unidade.

> Para isso eu utilizei um _operador de resto_ para ter acesso ao restante da divisão realizada.

Para números entre 100 e 999 a mesma regra sitada acima é aplicada. Somente alturando a divisão por 100 em vez de 10.