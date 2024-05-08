using DevelopmentChallenge.Data._8;

public static class Traductor
{
    public static string Nombre(TipoFormaGeometrica forma, int cantidad, Idioma idioma)
    {
        if (cantidad == 1) return NombreSingular(forma, idioma);
        return NombrePlural(forma, idioma);
    }
    private static string NombreSingular(TipoFormaGeometrica forma, Idioma idioma)
    {
        switch (forma)
        {
            case TipoFormaGeometrica.CUADRADO:
                switch (idioma)
                {
                    case Idioma.CASTELLANO:
                        return "Cuadrado";
                    case Idioma.ITALIANO:
                        return "Piazza";
                    default:
                        return "Square";
                }
            case TipoFormaGeometrica.TRIANGULOEQUILATERO:
                switch (idioma)
                {
                    case Idioma.CASTELLANO:
                        return "Triángulo";
                    case Idioma.ITALIANO:
                        return "Triangolo";
                    default:
                        return "Triangle";
                }
            case TipoFormaGeometrica.CIRCULO:
                switch (idioma)
                {
                    case Idioma.CASTELLANO:
                        return "Círculo";
                    case Idioma.ITALIANO:
                        return "Cerchio";
                    default:
                        return "Circle";
                }
            case TipoFormaGeometrica.TRAPECIO:
                switch (idioma)
                {
                    case Idioma.CASTELLANO:
                        return "Trapecio";
                    case Idioma.ITALIANO:
                        return "Trapezio";
                    default:
                        return "Trapeze";
                }
            case TipoFormaGeometrica.RECTANGULO:
                switch (idioma)
                {
                    case Idioma.CASTELLANO:
                        return "Rectángulo";
                    case Idioma.ITALIANO:
                        return "Rettangolo";
                    default:
                        return "Rectangle";
                }
            default:
                return "UNDEFINED"; // unrechable
        }
    }

    private static string NombrePlural(TipoFormaGeometrica forma, Idioma idioma)
    {
        switch (forma)
        {
            case TipoFormaGeometrica.CUADRADO:
                switch (idioma)
                {
                    case Idioma.CASTELLANO:
                        return "Cuadrados";
                    case Idioma.ITALIANO:
                        return "Piazze";
                    default:
                        return "Squares";
                }
            case TipoFormaGeometrica.TRIANGULOEQUILATERO:
                switch (idioma)
                {
                    case Idioma.CASTELLANO:
                        return "Triángulos";
                    case Idioma.ITALIANO:
                        return "Triangoli";
                    default:
                        return "Triangles";
                }
            case TipoFormaGeometrica.CIRCULO:
                switch (idioma)
                {
                    case Idioma.CASTELLANO:
                        return "Círculos";
                    case Idioma.ITALIANO:
                        return "Cerchi";
                    default:
                        return "Circles";
                }
            case TipoFormaGeometrica.TRAPECIO:
                switch (idioma)
                {
                    case Idioma.CASTELLANO:
                        return "Trapecios";
                    case Idioma.ITALIANO:
                        return "Trapezio";
                    default:
                        return "Trapezes";
                }
            case TipoFormaGeometrica.RECTANGULO:
                switch (idioma)
                {
                    case Idioma.CASTELLANO:
                        return "Rectángulos";
                    case Idioma.ITALIANO:
                        return "Rettangoli";
                    default:
                        return "Rectangles";
                }
            default:
                return "UNDEFINED"; // unrechable
        }
    }

    public static string Area(Idioma idioma)
    {
        switch (idioma)
        {
            case Idioma.CASTELLANO:
                return "Area";
            case Idioma.ITALIANO:
                return "Zona";
            default:
                return "Area";
        }
    }

    public static string Perimetro(Idioma idioma)
    {
        switch (idioma)
        {
            case Idioma.CASTELLANO:
                return "Perimetro";
            case Idioma.ITALIANO:
                return "Perimetro";
            default:
                return "Perimeter";
        }
    }

    public static string ListaVacia(Idioma idioma)
    {
        switch (idioma)
        {
            case Idioma.CASTELLANO:
                return "Lista vacía de formas!";
            case Idioma.ITALIANO:
                return "Elenco vuoto di forme!";
            default:
                return "Empty list of shapes!";
        }
    }

    public static string Cabecera(Idioma idioma)
    {
        switch (idioma)
        {
            case Idioma.CASTELLANO:
                return "Reporte de Formas";
            case Idioma.ITALIANO:
                return "Rapporto sui Moduli";
            default:
                return "Shapes Report";
        }
    }

    public static string Total(Idioma idioma)
    {
        switch (idioma)
        {
            case Idioma.CASTELLANO:
                return "TOTAL";
            case Idioma.ITALIANO:
                return "TOTALE";
            default:
                return "TOTAL";
        }
    }

    public static string Formas(Idioma idioma)
    {
        switch (idioma)
        {
            case Idioma.CASTELLANO:
                return "formas";
            case Idioma.ITALIANO:
                return "forme";
            default:
                return "shapes";
        }
    }
}