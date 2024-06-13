public class PessoaJuridica : Pessoa {
    public string cnpj;

    public override void exibirInfo() {
        Console.WriteLine(cnpj);
        base.exibirInfo();
    }
}