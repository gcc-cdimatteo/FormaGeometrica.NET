using DevelopmentChallenge.Data._8;

public class TrianguloEquilatero : FormaGeometrica
{
    decimal lado { get; set; }

    public TrianguloEquilatero(decimal lado) : base(TipoFormaGeometrica.TRIANGULOEQUILATERO)
    {
        this.lado = lado;
    }

    public override decimal CalcularArea()
    {
        return ((decimal)Math.Sqrt(3) / 4) * lado * lado;
    }

    public override decimal CalcularPerimetro()
    {
        return lado * 3;
    }
}