public class Carro : Veiculo {
    public override void acelerar() {
        Console.WriteLine("Carro acelerando...");
        velocidade += 10;
    }

    public override void frear()
    {
        Console.WriteLine("Carro freando...");
        velocidade -= 5;
    }
}