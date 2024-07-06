internal class Program
{
    private static void Main(string[] args)
    {
        // Cria uma nova instância da classe Empresa chamada BiscoitosKaue
        Empresa BiscoitosKaue = new Empresa();

        // Inicia um loop infinito
        while (true)
        {
            // Exibe o menu principal
            Console.WriteLine("\n======Gerenciar Funcionarios======\n");
            Console.WriteLine("1 - Adicionar funcionário de tempo integral.");
            Console.WriteLine("2 - Adicionar funcionário de meio periodo.");
            Console.WriteLine("3 - Remover um funcionário.");
            Console.WriteLine("4 - Exibir informações de todos os funcionários.");
            Console.WriteLine("5 - Adicionar projeto(s) a um funcionário.");
            Console.WriteLine("6 - Sair do programa.");

            // Solicita ao usuário que escolha uma opção do menu
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            // Executa diferentes ações com base na escolha do usuário
            switch (opcao)
            {
                case 1:
                    // Adicionar funcionário de tempo integral
                    Console.WriteLine("\n======Funcionário Integral======");
                    Console.Write("\nNome do funcionario: ");
                    string nomeIntegral = Console.ReadLine();
                    Console.Write("Matricula do funcionario: ");
                    int matriculaIntegral = int.Parse(Console.ReadLine());
                    Console.Write("Salario mensal (R$): ");
                    double salarioMensalIntegral = double.Parse(Console.ReadLine());

                    // Cria uma nova instância de FuncionarioTempoIntegral
                    FuncionarioTempoIntegral funcionarioIntegral = new FuncionarioTempoIntegral(nomeIntegral, matriculaIntegral, salarioMensalIntegral);
                    // Adiciona o funcionário à empresa
                    BiscoitosKaue.AdicionarFuncionario(funcionarioIntegral);

                    Console.WriteLine("Funcionário de Tempo Integral adicionado com sucesso!");
                    break;

                case 2:
                    // Adicionar funcionário de meio período
                    Console.WriteLine("\n======Funcionário Meio Periodo======");
                    Console.Write("\nNome do funcionario: ");
                    string nomeMeioPeriodo = Console.ReadLine();
                    Console.Write("Matricula do funcionario: ");
                    int matriculaMeioPeriodo = int.Parse(Console.ReadLine());
                    Console.Write("Salario por hora (R$): ");
                    double salarioHoraMeioPeriodo = double.Parse(Console.ReadLine());
                    Console.Write("Horas trabalhadas: ");
                    double horasTrabalhadas = double.Parse(Console.ReadLine());

                    // Cria uma nova instância de FuncionarioMeioPeriodo
                    FuncionarioMeioPeriodo funcionarioMeioPeriodo = new FuncionarioMeioPeriodo(nomeMeioPeriodo, matriculaMeioPeriodo, salarioHoraMeioPeriodo, horasTrabalhadas);
                    // Adiciona o funcionário à empresa
                    BiscoitosKaue.AdicionarFuncionario(funcionarioMeioPeriodo);

                    Console.WriteLine("Funcionário de Meio Periodo adicionado com sucesso!");
                    break;

                case 3:
                    // Remover um funcionário
                    Console.WriteLine("\n======Remover Funcionário======");
                    Console.Write("\nMatricula do funcionário a ser removido: ");
                    int matriculaRemover = int.Parse(Console.ReadLine());

                    bool funcionarioRemovido = false;

                    // Procura o funcionário na lista de funcionários da empresa
                    foreach (var funcionario in BiscoitosKaue.listaFuncionarios) {
                        if (funcionario.matricula == matriculaRemover) {
                            // Remove o funcionário se encontrado
                            BiscoitosKaue.RemoverFuncionario(matriculaRemover);
                            funcionarioRemovido = true;
                            Console.WriteLine($"Funcionário com matrícula {matriculaRemover} removido com sucesso!");
                            break;
                        }
                    }

                    if (!funcionarioRemovido) {
                        Console.WriteLine("Funcionário não encontrado!");
                    }
                    break;

                case 4:
                    // Exibir informações de todos os funcionários
                    Console.WriteLine("\n======Exibir Funcionários======");
                    BiscoitosKaue.ExibirFuncionarios();
                    break;

                case 5:
                    // Adicionar projeto a um funcionário
                    Console.WriteLine("======Adicionar Projeto======");
                    Console.Write("\n\nNome do funcionário: ");
                    string nomeProjeto = Console.ReadLine();
                    Console.Write("Nome do projeto a ser adicionado: ");
                    string nomeProjetoAdicionado = Console.ReadLine();

                    bool projetoAdicionado = false;

                    // Procura o funcionário na lista de funcionários da empresa
                    foreach (var funcionario in BiscoitosKaue.listaFuncionarios)
                    {
                        if (funcionario.nome == nomeProjeto)
                        {
                            // Adiciona o projeto ao funcionário se encontrado
                            funcionario.AdicionarProjeto(nomeProjetoAdicionado);
                            Console.WriteLine("Projeto adicionado com sucesso!");
                            projetoAdicionado = true;
                            break;
                        }
                    }

                    if (!projetoAdicionado)
                    {
                        Console.WriteLine("Funcionário não encontrado!");
                    }

                    break;

                case 6:
                    // Sair do programa
                    Console.WriteLine("\nEncerrando programa...");
                    return;

                default:
                    // Opção inválida
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }

        }
    }
}
