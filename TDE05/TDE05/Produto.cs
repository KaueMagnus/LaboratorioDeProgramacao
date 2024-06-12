using System.Diagnostics.Tracing;

public class Produto {
    public string nome;
    public double preco;
    public Produto() {
        nome = "Desconhecido";
        preco = 0.0;
    }

    public Produto(string nome, double preco) {
        this.nome = nome;
        this.preco = preco;
    }

    public void ExibirInfo() {
        Console.WriteLine("========================");
        Console.WriteLine("Nome do produto: " + nome);
        Console.WriteLine("Preço: R$" + preco);
    }

    public void ExibirInfo(bool exibirPreco) {
        Console.WriteLine("========================");
        Console.WriteLine("Nome do produto: " + nome);
        if (exibirPreco == true) {
            Console.WriteLine("Preço: R$" + preco);
        }
        
    }
}