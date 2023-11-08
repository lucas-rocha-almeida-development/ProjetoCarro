Console.WriteLine("##PROJETO CARRO##");

Carro chevrolet = new Carro("Sedan","Chevrolet","Onix",2016,110);

Carro ford = new Carro("SUV","Ford","EcoSport",2018,120);

Console.WriteLine($"Veiculo possui modelo: {chevrolet.Modelo}, motadora: {chevrolet.Motadora} , marca : {chevrolet.Marca} , Ano: {chevrolet.Ano} , Velocidade {chevrolet.Potencia}");
Console.WriteLine($"Veiculo possui modelo: {ford.Modelo}, motadora: {ford.Motadora} , marca : {ford.Marca} , Ano: {ford.Ano} , Velocidade {ford.Potencia}");
chevrolet.Acelarar("Chevrolet");
ford.Acelarar("Ford");
Console.ReadKey();


public class Carro
{
    public string? Modelo;
    public string? Motadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string? modelo, string? motadora, string? marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Motadora = motadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }

    public void Acelarar(string marca)
    {

        Console.WriteLine($"Acelerando meu {marca}....");
    }

}
