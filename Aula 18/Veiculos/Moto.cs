public class Moto : Veiculo {
    public override void acelerar() {
        Console.WriteLine("Moto acelerando...");
        velocidade += 15;
    }

    public override void frear()
    {
        Console.WriteLine("Moto acelerando...");
         velocidade -= 10;
    }

}