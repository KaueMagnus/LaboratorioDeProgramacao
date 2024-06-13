public class Pessoa {
    public string nome;
    public string endereco;

    public virtual void exibirInfo() {
        Console.WriteLine($"Nome: {nome}\nEndereço: {endereco}");
    }

    public void setNome(string nome) {
        this.nome = nome;
    }

    public void setEndereco(string endereco) {
        this.endereco = endereco;
    }
}