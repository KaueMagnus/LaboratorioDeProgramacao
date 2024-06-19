System.Console.WriteLine("Digite o nome do autor: ");
string autor = Console.ReadLine();
System.Console.WriteLine("Nacionalidade: ");
String nacionalidade = Console.ReadLine();

Autor autor1 = new Autor(autor, nacionalidade);

autor1.MostrarInfo();


System.Console.WriteLine("Qual o titulo do livro: ");
String titulo = Console.ReadLine();
System.Console.WriteLine("Informe o preço do livro: ");
double preco = Convert.ToDouble(Console.ReadLine());


Livro livro = new Livro(titulo, autor, preco);


livro.MostrarInfo();
livro.AplicarDesconto(10);
livro.MostrarInfo();
livro.AplicarDesconto(10.0);
livro.MostrarInfo();

