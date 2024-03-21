//Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
int idade = 35;
System.Console.WriteLine("Idade: " + idade);

// Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
System.Console.WriteLine("\nNome: " + nome);

// Crie uma variável chamada altura e atribua a ela o valor 3.45.
double altura = 3.45;
System.Console.WriteLine("\nAltura: " + altura);

// Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor
const int ano = 12;
System.Console.WriteLine("\nO valor da constante ano é: " + ano);

// Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor
Nullable<double> nota = 7.80;
System.Console.WriteLine("\nNota: " + nota);


// Quais as diferenças entre os tipos por valor e os tipos por referência ?
System.Console.WriteLine("\nTipos por valor armazenam diretamente os valores, enquanto tipos por referência armazenam endereços de memória onde os valores estão localizados. Tipos por valor são primitivos e são armazenados na pilha, enquanto tipos por referência são objetos complexos e são armazenados no heap. Ao atribuir um tipo por valor a outra variável, é feita uma cópia do valor, enquanto ao atribuir um tipo por referência, apenas o endereço de memória é copiado."); 


// O que é um nullable type e qual a sua utilidade ?
System.Console.WriteLine("\nNullable Types é um recurso do C# que nos permite atribuir o valor null a um tipo de dado que, por padrão, não aceita valores nulos: os tipos primitivos. Isso é útil em situações onde um valor pode ser desconhecido, inexistente ou inválido.");


// O que é camel Case ? Dê um exemplo de sua aplicação.
System.Console.WriteLine("\nA primeira letra de cada palavra é escrita em maiúscula, exceto a primeira palavra. Em C#, a convenção de nomenclatura camelCase é usada para nomear variáveis, parâmetros de método e propriedades. Ex: idadeDoAluno");


// O que é Pascal Case ? Dê um exemplo de sua aplicação
System.Console.WriteLine("\nEm PascalCase, a primeira letra de cada palavra é escrita em maiúscula. PascalCase é geralmente usada para nomear classes, interfaces, enums e métodos públicos. Ex: MetodosFuncoes");

/*Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a
seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a operação de soma)*/
int x = 77;
int y = 66;
int soma = x + y;

System.Console.WriteLine($"\nSoma de x ({x}) e y ({y}) é igual = {soma}");

// Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
System.Console.WriteLine("\nbool = false\n char = '\0'\n int = 0\n double = 0.0d\n float = 0.0f\n decimal = 0.0m\n string = null");
