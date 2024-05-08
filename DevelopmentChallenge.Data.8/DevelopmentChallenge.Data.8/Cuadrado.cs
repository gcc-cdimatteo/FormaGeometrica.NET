using DevelopmentChallenge.Data._8;

public class Cuadrado : FormaGeometrica
{
    decimal lado { get; set; }

    public Cuadrado(decimal lado) : base(TipoFormaGeometrica.CUADRADO)
    {
        this.lado = lado;
    }

    public override decimal CalcularArea()
    {
        return lado * lado;
    }

    public override decimal CalcularPerimetro()
    {
        return lado * 4;
    }
}