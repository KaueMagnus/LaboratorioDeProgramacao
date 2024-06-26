public abstract class Veiculo {
    protected int velocidade;

    public void setVelocidade(int velocidadeAtual) {
        velocidade = velocidadeAtual;
    }
        

    public abstract void acelerar();

    public abstract void frear();
    

    public void exibeVelocidade() {
        Console.WriteLine("Velocidade: " + velocidade);
    }
    

}