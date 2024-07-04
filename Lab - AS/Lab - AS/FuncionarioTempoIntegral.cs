public class FuncionarioTempoIntegral : Funcionario
{

    private double salarioMensal;

    public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base(nome, matricula) {
        this.salarioMensal = salarioMensal;
    }

    public override double CalcularSalario() {
        return salarioMensal;
    }

    public override void ExibirInformacoes() {
        Console.WriteLine($"\nNome: {nome}\nMatricula: {matricula}\nTipo: Integral\nSalario Mensal: R${salarioMensal}");
    }

    public double CalcularBonus() {
        return salarioMensal * 0.1;
    }

}