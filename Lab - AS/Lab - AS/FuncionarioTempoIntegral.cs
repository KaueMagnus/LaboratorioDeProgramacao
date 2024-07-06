public class FuncionarioTempoIntegral : Funcionario
{
    // Atributos
    private double salarioMensal;

    // Construtor que inicializa o atributo e chama o construtor da classe base Funcionario
    public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base(nome, matricula) {
        this.salarioMensal = salarioMensal; 
    }

    // Implementação do método abstrato CalcularSalario da classe base Funcionario
    public override double CalcularSalario() {
        return salarioMensal; // Retorna o salário mensal
    }

    // Implementação do método abstrato ExibirInformacoes da classe base Funcionario
    public override void ExibirInformacoes() {
        // Exibe as informações do funcionário de tempo integral
        Console.WriteLine($"\nNome: {nome}\nMatricula: {matricula}\nTipo: Integral\nSalario Mensal: R${salarioMensal}");
        Console.WriteLine($"Salario com bonus: {CalcularBonus()}");
    }

    // Método para calcular o bônus do funcionário de tempo integral
    public double CalcularBonus() {
        return (CalcularSalario() * 0.1) + salarioMensal; // Calcula o bônus como 10% do salário mensal mais o salário mensal
    }
}
