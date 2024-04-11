// 1 - Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
// Encontre o maior dentre 3 números:
// Primeiro Número : 65465
// Segundo Número : 64658
// Terceiro Número : 65464
// O primeiro número : 65465 é o maior


int num1, num2, num3;

System.Console.WriteLine("Digite um numero: ");
num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Digite um numero: ");
num2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Digite um numero: ");
num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3) {
    System.Console.WriteLine($"O primeiro número é o maior: {num1}");
} else {
    if(num2 > num1 && num2 > num3) {
        System.Console.WriteLine($"O segundo número é o maior: {num2}");
    } else {
        System.Console.WriteLine($"O terceiro número é o maior: {num3}");
    }
}


// 2- Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop 
// while, do-while e for.
// Os 10 primeiros números naturais são :
// 1 2 3 4 5 6 7 8 9 10
// A soma dos números é : 55

////FOR

int soma = 0;

System.Console.WriteLine("Os 10 primeiros números naturais são: ");
for (int i = 1; i <= 10; i++) {
    System.Console.Write(i + " ");
    soma += i;
}

System.Console.WriteLine("\nA soma dos números é: " + soma);

////WHILE

int contador = 0;
int soma = 0;

System.Console.WriteLine("Os 10 primeiros números naturais são: ");
while (contador < 10) {
    System.Console.Write(contador + 1 + " ");
    contador++;
    soma += contador;
}

System.Console.WriteLine("\nA soma dos números é: " + soma);


////DO WHILE

int contador = 1;
int soma = 0;

System.Console.WriteLine("Os 10 primeiros números naturais são: ");
do
{
    System.Console.Write(contador + " ");
    soma += contador;
    contador++;

} while (contador <= 10);

System.Console.WriteLine("\nA soma dos números é: " + soma);


// 3- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero 
// recebido via teclado 
// - Verifique se o número é maior que zero e emita uma mensagem
// - Considere a tabela de multiplicação de 1 até 10
// - Após exibir a tabela torne a solicitar outro número 
// - Para sair do loop defina uma condição de saída 
// Dica: Use os loop while e for e para sair a instrução break;



while (true) {
    System.Console.Write("Digite o numero a ser multiplicado (999 para sair): ");
    int num1 = int.Parse(Console.ReadLine());

    if (num1 > 0) {
        for (int i = 1; i <= 10; i++) {
            System.Console.WriteLine(num1 + " X " + i + " = " + i * num1);
            } 
    } else if (num1 == 999) {
        break;
    } else {
        System.Console.WriteLine("Apenas números maiores que zero!");
    }
      
}

System.Console.WriteLine("Encerrando programa...");





// 4- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 
// maneiras diferentes:
// - Incrementando 2 em cada passo
// - Incrementando 1 em cada passo 
// - Com e loop infinito (use "break" e "continue")

////1 MÉTODO
for (int i = 10; i <= 20; i+=2) {
    if (i == 16) {
        continue;
    }
    System.Console.WriteLine($"i = {i}");
}
 
////2 MÉTODO
for (int i = 10; i <= 20; i++) {
    if (i % 2 != 1) {
        continue;
    }
    else if (i == 16) {
        continue;
    }
    System.Console.WriteLine($"i = {i}");
} 

////3 MÉTODO
for (int i = 10; ; i+=2) {
    if (i == 16) {
        continue;
    }
    else if (i > 20) {
        break;
    }

    System.Console.WriteLine($"i = {i}");
}



// 5 - Escreva um programa para calcular o fatorial de um número inteiro. 
// O fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1 
// Exemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1

int fatorial = 1;

System.Console.WriteLine("Digite um numero inteiro: ");
int numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= numero; i++) {
    fatorial *= i;
}

System.Console.WriteLine($"O fatorial de {numero} é {fatorial}");

 

// 6 - Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado

// Modelo de saída
// 2 x 1 = 2
// 2 x 2 = 4
// 2 x 3 = 6
// 2 x 4 = 8
// 2 x 5 = 10
// 2 x 6 = 12
// 2 x 7 = 14
// 2 x 8 = 16
// 2 x 9 = 18
// 2 x 10 = 20
// 3 x 1 = 3
// 3 x 2 = 6
// 3 x 3 = 9
// 3 x 4 = 12
// 3 x 5 = 15
// 3 x 6 = 18
// 3 x 7 = 21
// 3 x 8 = 24
// 3 x 9 = 27
// 3 x 10 = 30


int numero = 2;

do {
    int multiplicador = 1;
    do {
        System.Console.WriteLine($"{numero} X {multiplicador} = {numero * multiplicador}");
        multiplicador++;
    } while (multiplicador <= 10);
    System.Console.WriteLine();
    numero++;
} while (numero <= 6);

 

// 7 - Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de 
// um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a 
// instrução switch, break e default em um loop infinito e defina uma condição de saida.)
// image.png

 while (true) {
    System.Console.WriteLine("Informe a nota do aluno (99 p/ sair): ");
    int x = int.Parse(Console.ReadLine());

    if (x == 99) {
        break;
    }

    switch (x) {
        case 10:
            System.Console.WriteLine("A+");
            break;

        case 9:
            System.Console.WriteLine("A");    
            break;   

        case 8:

        case 7:
            System.Console.WriteLine("B");
             break;

        case 6:
            System.Console.WriteLine("C");    
            break; 
        case 5:
        System.Console.WriteLine("D");
        break;

        default: 
            System.Console.WriteLine("F");
            break;
    }       

 }

// 8 - Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números 
// inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e 
// quando isso ocorrer exibir uma mensagem de alerta

double num1, num2;

string operacao;


