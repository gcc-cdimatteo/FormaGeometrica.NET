using DevelopmentChallenge.Data._8;

public class Rectangulo : FormaGeometrica
{
    decimal largo { get; set; }
    decimal ancho { get; set; }

    public Rectangulo(decimal largo, decimal ancho) : base(TipoFormaGeometrica.RECTANGULO)
    {
        this.largo = largo;
        this.ancho = ancho;
    }

    public override decimal CalcularArea()
    {
        return largo * ancho;
    }

    public override decimal CalcularPerimetro()
    {
        return 2 * largo + 2 * ancho;
    }
}