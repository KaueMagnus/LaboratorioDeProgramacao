public class FuncionarioMeioPeriodo : Funcionario
{
    private double salarioHora;
    private double horasTrabalhadas;

    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioHora, double horasTrabalhadas) : base(nome, matricula) {
        this.salarioHora = salarioHora;
        this.horasTrabalhadas = horasTrabalhadas;
    }

    public override double CalcularSalario() {
        return salarioHora * horasTrabalhadas;
    }

    public override void ExibirInformacoes() {
        Console.WriteLine($"\nNome: {nome}\nMatricula: {matricula}\nTipo: Meio Periodo\nSalario Hora: {salarioHora}");
        Console.WriteLine($"Salario Completo: {CalcularSalario()}");
        Console.WriteLine($"Salario com bonus: {CalcularBonus()}");
    }

    public double CalcularBonus() {
        return CalcularSalario() * 0.05;
    }

}