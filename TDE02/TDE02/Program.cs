// Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato:
// Aluno tem anos e nota usando a concatenação e a interpolação de strings.
// Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.

string nome = "Paulo";
int idade = 17;
double nota = 7.5;
System.Console.WriteLine($"Interpolação: {nome} tem {idade} anos e nota {nota}");
System.Console.WriteLine("Concatenação: " + nome + " tem " + idade + " anos e nota " + nota);
System.Console.WriteLine($"{nome} tem {idade} anos\n e \nnota {nota}");
 

// Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// (X) double
// ( ) long
// (X) decimal 
 

// Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// ( ) int para long
// (X) double para long
// (X) double para float
// (X) decimal para float
// (X) long para int
// (X) double para decimal
 

// Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
// a concatenação e também a interpolação de strings
System.Console.WriteLine("Insira uma letra: ");
char letra1 = char.Parse(Console.ReadLine());

System.Console.WriteLine("Insira outra letra: ");
char letra2 = char.Parse(Console.ReadLine());

System.Console.WriteLine("Insira mais uma letra: ");
char letra3 = char.Parse(Console.ReadLine());

System.Console.WriteLine($"Interpolação: {letra3}, {letra2}, {letra1}");
System.Console.WriteLine("Concatenação: " + letra3 + ", " + letra2 + ", " + letra1);
 

// Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32;
// (v) var nome = “Maria”;
// (V) string resultado = 100.ToString();
// (V) A sequência de escape \n inclui uma nova linha
// (F) float f = 5.45;
// (V) decimal valor = (decimal) 10.99f;
// (F) var status = null;
// (V) object o = 12.45m;
// (V) string titulo = true.ToString();
// (F) A sequencia \t inclui uma tabulação vertical
 

// Escreva um programa para receber dois valores via teclado do tipo double e a seguir
// realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
// exibindo o resultado:
 
System.Console.WriteLine("Digite um numero: ");
double n1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Digite outro numero: ");
double n2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"A soma de n1 + n2 = {n1+n2}");
System.Console.WriteLine($"A subtração de n1 - n2 = {n1-n2}");
System.Console.WriteLine($"A multiplicação de n1 * n2 = {n1*n2}");
System.Console.WriteLine($"A divisão de n1 / n2 = {(double) n1/n2}");
System.Console.WriteLine($"O módulo de n1 % n2 = {n1%n2}");
System.Console.WriteLine($"A potencia de n1 elevado a n2 = {Math.Pow(n1,n2)}");

// Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
// Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
// então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
// inválido’: (use o operador condicional ternário)

System.Console.WriteLine("Insira seu nome: ");
string nome = Console.ReadLine();

System.Console.WriteLine("Insira sua senha: ");
int senha = int.Parse(Console.ReadLine());

string aviso = (nome == "admin" || nome == "maria" && senha == 123 ? "Login feito com sucesso" : "Login Inválido");

System.Console.WriteLine(aviso);
 

// Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
// console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

System.Console.WriteLine("Digite um numero: ");
int x = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite outro numero: ");
int y = int.Parse(Console.ReadLine());

string verifica_x = (x % 2 == 0 ? "X é par!" : "X é impar!");
string verifica_y = (y % 2 == 0 ? "Y é par!" : "Y é impar!");

System.Console.WriteLine(verifica_x);
System.Console.WriteLine(verifica_y);
