public abstract class Mamifero {

    public string nome;

    public Mamifero(string nome)
    {
        this.nome = nome;
    }

    public abstract void caminhar();

    public void Respirar() {
        Console.WriteLine("Mamifero respirando...");
    }

    public virtual void exibirInformacoes() {
        Console.WriteLine("Nome: " + nome);
    }

}