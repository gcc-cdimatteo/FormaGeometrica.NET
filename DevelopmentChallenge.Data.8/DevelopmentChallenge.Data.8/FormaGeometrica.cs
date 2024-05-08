namespace DevelopmentChallenge.Data._8;

public abstract class FormaGeometrica
{
    TipoFormaGeometrica tipo { get; set; }

    public FormaGeometrica(TipoFormaGeometrica tipo)
    {
        this.tipo = tipo;
    }

    public TipoFormaGeometrica ObtenerTipo() => tipo;
    public abstract decimal CalcularArea();
    public abstract decimal CalcularPerimetro();
}