//Declarando Tipos de Referência

//String

// // // // string curso = "ADS";
// // // // string disciplina = "Laboratório de Programação";

// // // // System.Console.WriteLine("Curso: " + curso);
// // // // System.Console.WriteLine("Disciplina: "+ disciplina);

// // // //Object

// // // // object nota = 10;
// // // // object valor1 = 8.55m;
// // // // object nome1 = "Maria";
// // // // object ativa = true;
// // // // object letra = 'A';

// // // // System.Console.WriteLine(nota);
// // // // System.Console.WriteLine(valor1);
// // // // System.Console.WriteLine(nome1);
// // // System.Console.WriteLine(ativa);
// // // // System.Console.WriteLine(letra);

//Dynamic

dynamic nota = 10;
dynamic valor1 = 8.55m;
dynamic nome1 = "Maria";
dynamic ativa = true;
dynamic letra = 'A';

System.Console.WriteLine(nota);
System.Console.WriteLine(valor1);
System.Console.WriteLine(nome1);
System.Console.WriteLine(ativa);
System.Console.WriteLine(letra);

//Tipos Nulos

Nullable<int> x = null;

int? y = 44;
double? z = 34;

if (y.HasValue) {
    System.Console.WriteLine("Y possui valor!");
} else {
    System.Console.WriteLine("Y não possui valor!");
}
