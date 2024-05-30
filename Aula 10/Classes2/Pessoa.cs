public class Pessoa {
    public string? nome;
    public int? idade;
    public string? sexo;

    public Pessoa(string nome, int? idade) {
        this.nome = nome;
        this.idade = idade;
    }

    public Pessoa() {
        nome = "Desconhecido";
        idade = 0;
    }

    public void Falar() {
        System.Console.WriteLine("BLABLABLABLA");
    }
    public string Comer(string comida, int quantidade) {
        return $"{nome} está comendo {comida} e repetiu {quantidade} vezes";
    }
    public string Comer() {
        return $"{nome} está comendo";
    }

}