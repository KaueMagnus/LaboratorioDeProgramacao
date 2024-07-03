public class Cachorro : Mamifero, IAnimal
{
    
    public int nPatas;

    public Cachorro (int nPatas, string nome) : base(nome) {
        this.nPatas = nPatas;
    }
    
    public void emitirSom()
    {
        Console.WriteLine("\nAuau!");
    }

    public override void caminhar()
    {
        Console.WriteLine("Cachorro caminhando...");
    }

    public override void exibirInformacoes() {
        Console.WriteLine($"Nome: {nome}\nNumero de patas: {nPatas}");
    }

}