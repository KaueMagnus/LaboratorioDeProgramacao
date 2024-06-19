public class Livro {
    private String titulo;
    private String autor;
    private double preco;

    public Livro (String titulo, String autor) {
        this.titulo = titulo;
        this.autor = autor;
    }

    public Livro (String titulo, String autor, double preco) {
        this.titulo = titulo;
        this.autor = autor;
        this.preco = preco;
    }

    public void MostrarInfo () {
        System.Console.WriteLine();
        System.Console.WriteLine("========LIVRO========");
        System.Console.WriteLine("Titulo: " + titulo);
        System.Console.WriteLine("Autor: " + autor);
        System.Console.WriteLine("Preço: " + preco);
        System.Console.WriteLine();
    }

    public void AplicarDesconto (double desconto) {
        preco = preco - (preco * (desconto / 100));
    }

    public void AplicarDesconto (int desconto) {
        preco = preco - desconto;
    }

    
    
}

