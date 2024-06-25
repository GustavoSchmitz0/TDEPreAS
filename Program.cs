Carro carro1 = new Carro();
Moto moto1 = new Moto();

List<Veiculo> veiculos = new List<Veiculo>();
veiculos.Add(moto1);
veiculos.Add(carro1);

foreach (var veiculo in veiculos) //PERCORRE A LISTA PARA APLICAR OS MÉTODOS EM TODOS OS OBJETOS
{
    veiculo.Acelerar();
    veiculo.ExibirVelocidade();
    veiculo.Frear();
    veiculo.ExibirVelocidade();
}