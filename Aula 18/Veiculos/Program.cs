Carro carro1 = new Carro();
carro1.setVelocidade(120);

Moto moto1 = new Moto();
moto1.setVelocidade(150);


// moto1.exibeVelocidade();



// Criando Listas

List<Veiculo> veiculos = new List<Veiculo>();

veiculos.Add(carro1);
veiculos.Add(moto1);

//veiculos.Remove(carro1);

foreach (var veiculo in veiculos) {
    veiculo.acelerar();
    veiculo.exibeVelocidade();
    veiculo.frear();
    veiculo.exibeVelocidade();
}