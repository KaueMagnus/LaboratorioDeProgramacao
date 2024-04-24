//Crianca < 10 anos
//Adolescente >= 10 anos e < 20 anos
//Adulto >= 20 anos e < 60 anos
//Idoso >= 60 anos

internal class Program
{
    private static void Main(string[] args)
    {
        // Declarando as variáveis utilizadas.
        string nome, classificacaoIMC, classificacaoIdade;
        int idade, iniciadorPrograma = 1;
        double altura, peso, IMC;

        // Loop do-while para possibilitar calcular mais vezes ou sair do programa.
        do
        {
            Console.WriteLine("");
            Console.WriteLine("=====CALCULADORA DE IMC =====");

            // Inputs dos dados: nome, idade, altura e peso.
            Console.WriteLine("Qual seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade? ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua altura (em metros): ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu peso? (em kilos): ");
            peso = double.Parse(Console.ReadLine());

            // Calculo do IMC feito já com os inputs.
            IMC = peso / (altura * altura);

            // Estrutura Condicional para classificar o IMC do usuário.
            if (IMC < 18.5)
            {
                classificacaoIMC = "Abaixo do peso";
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                classificacaoIMC = "Peso Normal";
            }
            else if (IMC >= 25 && IMC <= 29.9)
            {
                classificacaoIMC = "Sobrepeso";
            }
            else
            {
                classificacaoIMC = "Obesidade";
            }

            // Estrutura Condicional para classificar a faixa etária do usuário.
            if (idade < 10)
            {
                classificacaoIdade = "Criança";
            }
            else if (idade >= 10 && idade < 20)
            {
                classificacaoIdade = "Adolescente";
            }
            else if (idade >= 20 && idade < 60)
            {
                classificacaoIdade = "Adulto";
            }
            else
            {
                classificacaoIdade = "Idoso";
            }

            Console.WriteLine("");

            // Exibindo o relatório.
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine($"IMC: {IMC:F2} / {classificacaoIMC}");
            Console.WriteLine($"Faixa etária: {classificacaoIdade}");

            Console.WriteLine("");

            // Possibilidade de gerar um novo relatório ou sair do programa.
            Console.WriteLine("Deseja gerar um novo relatório? (1 - sim / 2 - não): ");
            iniciadorPrograma = int.Parse(Console.ReadLine());
            
        } while (iniciadorPrograma == 1);

        Console.WriteLine("Encerrando programa...");
    }
}