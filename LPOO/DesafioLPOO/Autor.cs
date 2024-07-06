public class Autor {
    private String nome;
    private String nacionalidade;

    public Autor (String nome, String nacionalidade) {
        this.nome = nome;
        this.nacionalidade = nacionalidade;
    }

    public void MostrarInfo() {
        Console.WriteLine("========AUTOR========");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Nacionalidade: " + nacionalidade);
        System.Console.WriteLine();
    }

    

}