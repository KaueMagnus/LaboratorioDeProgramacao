public class PessoaFisica : Pessoa {

    public string cpf;

    public override void exibirInfo() {
        Console.WriteLine(cpf);
        base.exibirInfo();
    }

    public void anularNome() {
        nome = null;
    }

}