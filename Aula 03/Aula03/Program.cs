// int idade = 25;
// string nome = "Maria";

//////Interpolação
// System.Console.WriteLine($"{nome} tem {idade} anos");


//////PlaceHolders
// System.Console.WriteLine("{0} tem {1} anos", nome, idade);


//////Sequência de escapes

// string local = "c:\\dados\\poesia.txt";

// string frase = "Ele falou: \"Não foi eu\"";

// string pizza = "\nPizza\nde\nMussarela";

// System.Console.WriteLine(local);
// System.Console.WriteLine(frase);
// System.Console.WriteLine(pizza);


//////Conversões de tipos

// int varInt = 100;
// double varDouble = varInt;

// double varDouble = 12.456;
// int varInt = (int) varDouble;

// System.Console.WriteLine(varInt);

// int num1 = 10;
// int num2 = 4;

// double resultado = (double) num1 / num2;

// System.Console.WriteLine(resultado);


//////Conversão usando o método ToString()

// int valorInt = 123;
// double valorDouble = 12.45;
// decimal valorDecimal = 12.3454m;

// string s1 = valorInt.ToString();
// string s2 = valorDouble.ToString();
// string s3 = valorDecimal.ToString();

// System.Console.WriteLine(s1);
// System.Console.WriteLine(s2);
// System.Console.WriteLine(s3);

//////Classe Convert

// int valorInt = 10;
// double valorDouble = 4.254;
// bool valorBool = true;

// System.Console.WriteLine(Convert.ToString(valorInt));
// System.Console.WriteLine(Convert.ToDouble(valorInt));
// System.Console.WriteLine(Convert.ToString(valorBool));
// System.Console.WriteLine(Convert.ToInt32(valorDouble));

// System.Console.WriteLine("Informe seu nome: ");
// string nome = Console.ReadLine();

// System.Console.WriteLine($"Seu nome é {nome}");

// System.Console.WriteLine("Digite sua idade: ");
// int idade = int.Parse(Console.ReadLine());

// System.Console.WriteLine($"Sua idade é {idade}");

// Console.ReadKey();



// System.Console.WriteLine("Informe o valor de x: ");
// int x = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Informe o valor de y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"A raiz quadrada de x = {Math.Sqrt(x)}");
// System.Console.WriteLine($"A potencia de x elevado a y = {Math.Pow(x,y)}");
// System.Console.WriteLine($"A soma de x + y = {x+y}");
// System.Console.WriteLine($"A subtração de x - y = {x-y}");
// System.Console.WriteLine($"A multiplicação de x * y = {x*y}");
// System.Console.WriteLine($"A divisão de x / y = {(double) x/y}");
// System.Console.WriteLine($"O módulo de x % y = {x%y}");


//////tipo var
// var idade = 25;
// var nome = "Maria";

// System.Console.WriteLine($"{nome} tem {idade} anos");

System.Console.WriteLine("Informe a temperatura: ");

var temp = Convert.ToDouble(Console.ReadLine());
var resultado = temp > 27 ? "Quente" : "Normal";

System.Console.WriteLine($"O tempo está {resultado}");