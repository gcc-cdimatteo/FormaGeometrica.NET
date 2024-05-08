using System.Text;
using DevelopmentChallenge.Data._8;

public class Reporte
{
    List<FormaGeometrica> formas;
    Idioma idioma;

    // DB
    Dictionary<TipoFormaGeometrica, int> cantidades;
    Dictionary<TipoFormaGeometrica, decimal> areas;
    Dictionary<TipoFormaGeometrica, decimal> perimetros;

    // BUILDER
    public Reporte(Idioma idioma)
    {
        formas = new();
        this.idioma = idioma;

        // Inicializo la DB
        InicializarCantidades();
        InicializarAreas();
        InicializarPerimetros();
    }

    private void InicializarCantidades()
    {
        cantidades = new();
        cantidades[TipoFormaGeometrica.CUADRADO] = 0;
        cantidades[TipoFormaGeometrica.TRIANGULOEQUILATERO] = 0;
        cantidades[TipoFormaGeometrica.CIRCULO] = 0;
        cantidades[TipoFormaGeometrica.TRAPECIO] = 0;
        cantidades[TipoFormaGeometrica.RECTANGULO] = 0;
    }

    private void InicializarAreas()
    {
        areas = new();
        areas[TipoFormaGeometrica.CUADRADO] = 0;
        areas[TipoFormaGeometrica.TRIANGULOEQUILATERO] = 0;
        areas[TipoFormaGeometrica.CIRCULO] = 0;
        areas[TipoFormaGeometrica.TRAPECIO] = 0;
        areas[TipoFormaGeometrica.RECTANGULO] = 0;
    }

    private void InicializarPerimetros()
    {
        perimetros = new();
        perimetros[TipoFormaGeometrica.CUADRADO] = 0;
        perimetros[TipoFormaGeometrica.TRIANGULOEQUILATERO] = 0;
        perimetros[TipoFormaGeometrica.CIRCULO] = 0;
        perimetros[TipoFormaGeometrica.TRAPECIO] = 0;
        perimetros[TipoFormaGeometrica.RECTANGULO] = 0;
    }

    public void AgregarForma(FormaGeometrica forma)
    {
        formas.Add(forma);

        // Lleno la DB
        cantidades[forma.ObtenerTipo()] += 1;
        areas[forma.ObtenerTipo()] += forma.CalcularArea();
        perimetros[forma.ObtenerTipo()] += forma.CalcularPerimetro();
    }

    public void CambiarIdioma(Idioma nuevoIdioma) => idioma = nuevoIdioma;

    public string Imprimir()
    {

        if (formas.Count == 0) return ImprimirListaVacia();

        StringBuilder sb = new StringBuilder();

        sb.Append(ImprimirCabecera());

        sb.Append(ImprimirFormaGeometrica(TipoFormaGeometrica.CUADRADO));
        sb.Append(ImprimirFormaGeometrica(TipoFormaGeometrica.CIRCULO));
        sb.Append(ImprimirFormaGeometrica(TipoFormaGeometrica.TRIANGULOEQUILATERO));
        sb.Append(ImprimirFormaGeometrica(TipoFormaGeometrica.TRAPECIO));
        sb.Append(ImprimirFormaGeometrica(TipoFormaGeometrica.RECTANGULO));

        sb.Append(ImprimirTotal());
        sb.Append(ImprimirTotalCantidades());
        sb.Append(ImprimirTotalPerimetros());
        sb.Append(ImprimirTotalAreas());

        return sb.ToString();
    }

    private string ImprimirListaVacia()
    {
        return $"<h1>{Traductor.ListaVacia(idioma)}</h1>";
    }

    private string ImprimirCabecera()
    {
        return $"<h1>{Traductor.Cabecera(idioma)}</h1>";
    }

    private string ImprimirFormaGeometrica(TipoFormaGeometrica tipo)
    {
        int cantidad = cantidades[tipo];

        if (cantidad == 0) return string.Empty;

        string nombre = Traductor.Nombre(tipo, cantidades[tipo], idioma);
        decimal area = areas[tipo];
        decimal perimetro = perimetros[tipo];

        return $"{cantidad} {nombre} | {Traductor.Area(idioma)} {area:#.##} | {Traductor.Perimetro(idioma)} {perimetro:#.##} <br/>";
    }

    private string ImprimirTotal()
    {
        return $"{Traductor.Total(idioma)}:<br/>";
    }

    private string ImprimirTotalCantidades()
    {
        return cantidades.Values.Sum().ToString() + " " + Traductor.Formas(idioma) + " ";
    }

    private string ImprimirTotalPerimetros()
    {
        return Traductor.Perimetro(idioma) + " " + perimetros.Values.Sum().ToString("#.##") + " ";
    }

    private string ImprimirTotalAreas()
    {
        return Traductor.Area(idioma) + " " + areas.Values.Sum().ToString("#.##");
    }
}