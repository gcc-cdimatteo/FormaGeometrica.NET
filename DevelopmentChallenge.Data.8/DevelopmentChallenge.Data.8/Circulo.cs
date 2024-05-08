using DevelopmentChallenge.Data._8;

public class Circulo : FormaGeometrica
{
    decimal lado { get; set; }

    public Circulo(decimal lado) : base(TipoFormaGeometrica.CIRCULO)
    {
        this.lado = lado;
    }

    public override decimal CalcularArea()
    {
        return (decimal)Math.PI * (lado / 2) * (lado / 2);
    }

    public override decimal CalcularPerimetro()
    {
        return (decimal)Math.PI * lado;
    }
}