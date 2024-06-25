public class Carro : Veiculo
{
    public override void Acelerar() // SOBRESCREVENDO O MÉTODO ABSTRATO PARA DEFINIR O QUE ELE FAZ
    {
        Velocidade+= 10;
    }
    public override void Frear()
    {
        Velocidade-= 5;
    }
}