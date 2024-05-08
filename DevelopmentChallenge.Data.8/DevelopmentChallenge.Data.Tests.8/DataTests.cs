namespace DevelopmentChallenge.Data.Tests._8;

public class DataTests
{
    [TestCase]
    public void TestResumenListaVacia()
    {
        Reporte reporte = new(Idioma.CASTELLANO);

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Lista vacía de formas!</h1>"));
    }

    [TestCase]
    public void TestResumenListaVaciaFormasEnIngles()
    {
        Reporte reporte = new(Idioma.INGLES);

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Empty list of shapes!</h1>"));
    }

    [TestCase]
    public void TestResumenListaConUnCuadrado()
    {
        Reporte reporte = new Reporte(Idioma.CASTELLANO);

        reporte.AgregarForma(new Cuadrado(5));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25"));
    }

    [TestCase]
    public void TestResumenListaConMasCuadrados()
    {
        Reporte reporte = new Reporte(Idioma.INGLES);

        reporte.AgregarForma(new Cuadrado(5));
        reporte.AgregarForma(new Cuadrado(1));
        reporte.AgregarForma(new Cuadrado(3));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Shapes Report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35"));
    }

    [TestCase]
    public void TestResumenListaConMasTipos()
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
    public void TestResumenListaConMasTiposEnCastellano()
    {
        Reporte reporte = new Reporte(Idioma.CASTELLANO);

        reporte.AgregarForma(new Cuadrado(5));
        reporte.AgregarForma(new Circulo(3));
        reporte.AgregarForma(new TrianguloEquilatero(4));
        reporte.AgregarForma(new Cuadrado(2));
        reporte.AgregarForma(new TrianguloEquilatero(9));
        reporte.AgregarForma(new Circulo(2.75m));
        reporte.AgregarForma(new TrianguloEquilatero(4.2m));

        Assert.That(reporte.Imprimir(), Is.EqualTo("<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65"));
    }
}
