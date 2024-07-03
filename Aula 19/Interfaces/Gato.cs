public class Gato : Mamifero, IAnimal {

    public int nPatas;

    public Gato (int nPatas, string nome) : base(nome) {
        this.nPatas = nPatas;
    }

    public void emitirSom() {
        Console.WriteLine("Miau!");
    }

    public override void caminhar() {
        Console.WriteLine("Gato caminhando...");
    }

    public override void exibirInformacoes() {
        Console.WriteLine($"Nome: {nome}\nNumero de patas: {nPatas}");
    }
}