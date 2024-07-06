public class FuncionarioMeioPeriodo : Funcionario
{
    // Atributos
    private double salarioHora;
    private double horasTrabalhadas;

    // Construtor que inicializa os atributos e chama o construtor da classe base Funcionario
    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioHora, double horasTrabalhadas) : base(nome, matricula) {
        this.salarioHora = salarioHora; 
        this.horasTrabalhadas = horasTrabalhadas; 
    }

    // Implementação do método abstrato CalcularSalario da classe base Funcionario
    public override double CalcularSalario() {
        return salarioHora * horasTrabalhadas; // Calcula o salário total com base no salário por hora e nas horas trabalhadas
    }

    // Implementação do método abstrato ExibirInformacoes da classe base Funcionario
    public override void ExibirInformacoes() {
        // Exibe as informações do funcionário de meio período
        Console.WriteLine($"\nNome: {nome}\nMatricula: {matricula}\nTipo: Meio Periodo\nSalario Hora: {salarioHora}\nHoras trabalhadas: {horasTrabalhadas}");
        Console.WriteLine($"Salario Completo: {CalcularSalario()}");
        Console.WriteLine($"Salario com bonus: {CalcularBonus()}");
    }

    // Método para calcular o bônus do funcionário de meio período
    public double CalcularBonus() {
        return (CalcularSalario() * 0.05) + (salarioHora * horasTrabalhadas); // Calcula o bônus como 5% do salário total mais o salário por hora vezes as horas trabalhadas
    }
}
