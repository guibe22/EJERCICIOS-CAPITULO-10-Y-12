public class Poligono
{
   
    private int lados;
    private double longitudLado;

     public int Lados
    {
        get { return lados; }
        set
        {
            if (value > 0)
            {
                lados = value;
            }
        }
    }

    public double LongitudLado
    {
        get { return longitudLado; }
        set
        {
            if (value > 0)
            {
                longitudLado = value;
            }
        }
    }

   
    public Poligono()
    {
        lados = 0;
        longitudLado = 0.0;
    }

    public Poligono(int lados)
    {
        this.lados = lados;
        longitudLado = 0.0;
    }

    public Poligono(int lados, double longitudLado)
    {
        this.lados = lados;
        this.longitudLado = longitudLado;
    }


    public double Perimetro()
    {
        return lados * longitudLado;
    }

    public double Apotema()
    {
        double apotema = 0.0;
        if (lados > 2)
        {
            apotema = longitudLado / (2 * Math.Tan(Math.PI / lados));
        }
        return apotema;
    }

    public double Area()
    {
        double area = 0.0;
        double perimetro = Perimetro();
        double apotema = Apotema();
        if (perimetro > 0 && apotema > 0)
        {
            area = (perimetro * apotema) / 2;
        }
        return area;
    }

    public override string ToString()
{
    return $"El polígono  tiene {Lados} lados y un área de {Area} unidades cuadradas.";
}
}