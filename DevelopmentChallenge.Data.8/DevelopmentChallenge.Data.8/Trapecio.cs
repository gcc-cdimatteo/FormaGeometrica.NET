using DevelopmentChallenge.Data._8;

public class Trapecio : FormaGeometrica
{
    decimal baseMenor { get; set; }
    decimal baseMayor { get; set; }
    decimal altura { get; set; }

    public Trapecio(decimal baseMenor, decimal baseMayor, decimal altura) : base(TipoFormaGeometrica.TRAPECIO)
    {
        this.baseMenor = baseMenor;
        this.baseMayor = baseMayor;
        this.altura = altura;
    }

    public override decimal CalcularArea()
    {
        return (baseMenor + baseMayor) * altura / 2;
    }

    public override decimal CalcularPerimetro()
    {
        return (baseMenor + baseMayor) * altura;
    }
}