namespace DevelopmentChallenge.Data.Tests._8;

public class DataTests
{
    [TestCase]
    public void TestResumenListaVaciaCastellano()
    {
        Reporte reporte = new(Idioma.CASTELLANO);

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Lista vacía de formas!</h1>"));
    }

    [TestCase]
    public void TestResumenListaVaciaIngles()
    {
        Reporte reporte = new(Idioma.INGLES);

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Empty list of shapes!</h1>"));
    }

    [TestCase]
    public void TestResumenListaVaciaItaliano()
    {
        Reporte reporte = new(Idioma.ITALIANO);

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Elenco vuoto di forme!</h1>"));
    }

    [TestCase]
    public void TestResumenListaConUnCuadradoCastellano()
    {
        Reporte reporte = new Reporte(Idioma.CASTELLANO);

        reporte.AgregarForma(new Cuadrado(5));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25"));
    }

    [TestCase]
    public void TestResumenListaConUnCuadradoIngles()
    {
        Reporte reporte = new Reporte(Idioma.INGLES);

        reporte.AgregarForma(new Cuadrado(5));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Shapes Report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 shapes Perimeter 20 Area 25"));
    }

    [TestCase]
    public void TestResumenListaConUnCuadradoItaliano()
    {
        Reporte reporte = new Reporte(Idioma.ITALIANO);

        reporte.AgregarForma(new Cuadrado(5));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Rapporto sulle Forme</h1>1 Piazza | Zona 25 | Perimetro 20 <br/>TOTALE:<br/>1 forme Perimetro 20 Zona 25"));
    }

    [TestCase]
    public void TestResumenListaConUnCirculoCastellano()
    {
        Reporte reporte = new Reporte(Idioma.CASTELLANO);

        reporte.AgregarForma(new Circulo(5));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Reporte de Formas</h1>1 Circulo | Area 19,63 | Perimetro 15,71 <br/>TOTAL:<br/>1 formas Perimetro 15,71 Area 19,63"));
    }

    [TestCase]
    public void TestResumenListaConUnCirculoIngles()
    {
        Reporte reporte = new Reporte(Idioma.INGLES);

        reporte.AgregarForma(new Circulo(5));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Shapes Report</h1>1 Circle | Area 19,63 | Perimeter 15,71 <br/>TOTAL:<br/>1 shapes Perimeter 15,71 Area 19,63"));
    }

    [TestCase]
    public void TestResumenListaConUnCirculoItaliano()
    {
        Reporte reporte = new Reporte(Idioma.ITALIANO);

        reporte.AgregarForma(new Circulo(5));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Rapporto sulle Forme</h1>1 Cerchio | Zona 19,63 | Perimetro 15,71 <br/>TOTALE:<br/>1 forme Perimetro 15,71 Zona 19,63"));
    }

    [TestCase]
    public void TestResumenListaConUnRectanguloCastellano()
    {
        Reporte reporte = new Reporte(Idioma.CASTELLANO);

        reporte.AgregarForma(new Rectangulo(3, 6));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Reporte de Formas</h1>1 Rectangulo | Area 18 | Perimetro 18 <br/>TOTAL:<br/>1 formas Perimetro 18 Area 18"));
    }

    [TestCase]
    public void TestResumenListaConUnRectanguloIngles()
    {
        Reporte reporte = new Reporte(Idioma.INGLES);

        reporte.AgregarForma(new Rectangulo(3, 6));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Shapes Report</h1>1 Rectangle | Area 18 | Perimeter 18 <br/>TOTAL:<br/>1 shapes Perimeter 18 Area 18"));
    }

    [TestCase]
    public void TestResumenListaConUnRectanguloItaliano()
    {
        Reporte reporte = new Reporte(Idioma.ITALIANO);

        reporte.AgregarForma(new Rectangulo(3, 6));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Rapporto sulle Forme</h1>1 Rettangolo | Zona 18 | Perimetro 18 <br/>TOTALE:<br/>1 forme Perimetro 18 Zona 18"));
    }

    public void TestResumenListaConUnTrapecioCastellano()
    {
        Reporte reporte = new Reporte(Idioma.CASTELLANO);

        reporte.AgregarForma(new Trapecio(2, 5, 3));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Reporte de Formas</h1>1 Trapecio | Area 10,5 | Perimetro 21 <br/>TOTAL:<br/>1 formas Perimetro 21 Area 10,5"));
    }

    [TestCase]
    public void TestResumenListaConUnTrapecioIngles()
    {
        Reporte reporte = new Reporte(Idioma.INGLES);

        reporte.AgregarForma(new Trapecio(2, 5, 3));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Shapes Report</h1>1 Trapeze | Area 10,5 | Perimeter 21 <br/>TOTAL:<br/>1 shapes Perimeter 21 Area 10,5"));
    }

    [TestCase]
    public void TestResumenListaConUnTrapecioItaliano()
    {
        Reporte reporte = new Reporte(Idioma.ITALIANO);

        reporte.AgregarForma(new Trapecio(2, 5, 3));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Rapporto sulle Forme</h1>1 Trapezio | Zona 10,5 | Perimetro 21 <br/>TOTALE:<br/>1 forme Perimetro 21 Zona 10,5"));
    }

    public void TestResumenListaConUnTrianguloEquilateroCastellano()
    {
        Reporte reporte = new Reporte(Idioma.CASTELLANO);

        reporte.AgregarForma(new TrianguloEquilatero(4));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Reporte de Formas</h1>1 Triangulo | Area 6,93 | Perimetro 12 <br/>TOTAL:<br/>1 formas Perimetro 12 Area 6,93"));
    }

    [TestCase]
    public void TestResumenListaConUnTrianguloEquilateroIngles()
    {
        Reporte reporte = new Reporte(Idioma.INGLES);

        reporte.AgregarForma(new TrianguloEquilatero(4));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Shapes Report</h1>1 Triangle | Area 6,93 | Perimeter 12 <br/>TOTAL:<br/>1 shapes Perimeter 12 Area 6,93"));
    }

    [TestCase]
    public void TestResumenListaConUnTrianguloEquilateroItaliano()
    {
        Reporte reporte = new Reporte(Idioma.ITALIANO);

        reporte.AgregarForma(new TrianguloEquilatero(4));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Rapporto sulle Forme</h1>1 Triangolo | Zona 6,93 | Perimetro 12 <br/>TOTALE:<br/>1 forme Perimetro 12 Zona 6,93"));
    }

    [TestCase]
    public void TestResumenListaConMasCuadradosCastellano()
    {
        Reporte reporte = new Reporte(Idioma.CASTELLANO);

        reporte.AgregarForma(new Cuadrado(5));
        reporte.AgregarForma(new Cuadrado(1));
        reporte.AgregarForma(new Cuadrado(3));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Reporte de Formas</h1>3 Cuadrados | Area 35 | Perimetro 36 <br/>TOTAL:<br/>3 formas Perimetro 36 Area 35"));
    }

    [TestCase]
    public void TestResumenListaConMasCuadradosIngles()
    {
        Reporte reporte = new Reporte(Idioma.INGLES);

        reporte.AgregarForma(new Cuadrado(5));
        reporte.AgregarForma(new Cuadrado(1));
        reporte.AgregarForma(new Cuadrado(3));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Shapes Report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35"));
    }

    [TestCase]
    public void TestResumenListaConMasCuadradosItaliano()
    {
        Reporte reporte = new Reporte(Idioma.ITALIANO);

        reporte.AgregarForma(new Cuadrado(5));
        reporte.AgregarForma(new Cuadrado(1));
        reporte.AgregarForma(new Cuadrado(3));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Rapporto sulle Forme</h1>3 Piazze | Zona 35 | Perimetro 36 <br/>TOTALE:<br/>3 forme Perimetro 36 Zona 35"));
    }

    [TestCase]
    public void TestResumenListaConMasTiposCastellano()
    {
        Reporte reporte = new Reporte(Idioma.CASTELLANO);

        reporte.AgregarForma(new Cuadrado(5));
        reporte.AgregarForma(new Circulo(3));
        reporte.AgregarForma(new TrianguloEquilatero(4));
        reporte.AgregarForma(new Cuadrado(2));
        reporte.AgregarForma(new TrianguloEquilatero(9));
        reporte.AgregarForma(new Circulo(2.75m));
        reporte.AgregarForma(new TrianguloEquilatero(4.2m));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Circulos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65"));
    }

    [TestCase]
    public void TestResumenListaConMasTiposIngles()
    {
        Reporte reporte = new Reporte(Idioma.INGLES);

        reporte.AgregarForma(new Cuadrado(5));
        reporte.AgregarForma(new Circulo(3));
        reporte.AgregarForma(new TrianguloEquilatero(4));
        reporte.AgregarForma(new Cuadrado(2));
        reporte.AgregarForma(new TrianguloEquilatero(9));
        reporte.AgregarForma(new Circulo(2.75m));
        reporte.AgregarForma(new TrianguloEquilatero(4.2m));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Shapes Report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65"));
    }

    [TestCase]
    public void TestResumenListaConMasTiposItaliano()
    {
        Reporte reporte = new Reporte(Idioma.ITALIANO);

        reporte.AgregarForma(new Cuadrado(5));
        reporte.AgregarForma(new Circulo(3));
        reporte.AgregarForma(new TrianguloEquilatero(4));
        reporte.AgregarForma(new Cuadrado(2));
        reporte.AgregarForma(new TrianguloEquilatero(9));
        reporte.AgregarForma(new Circulo(2.75m));
        reporte.AgregarForma(new TrianguloEquilatero(4.2m));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Rapporto sulle Forme</h1>2 Piazze | Zona 29 | Perimetro 28 <br/>2 Cerchi | Zona 13,01 | Perimetro 18,06 <br/>3 Triangoli | Zona 49,64 | Perimetro 51,6 <br/>TOTALE:<br/>7 forme Perimetro 97,66 Zona 91,65"));
    }

    [TestCase]
    public void TestResumenListaVaciaIntegral()
    {
        Reporte reporte = new(Idioma.CASTELLANO);

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Lista vacía de formas!</h1>"));

        reporte.CambiarIdioma(Idioma.INGLES);

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Empty list of shapes!</h1>"));

        reporte.CambiarIdioma(Idioma.ITALIANO);

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Elenco vuoto di forme!</h1>"));
    }
}
