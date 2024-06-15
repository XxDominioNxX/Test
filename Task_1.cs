//---------------Use-----------------//

var t = new Triangle(3, 4, 5);
var s = new Circle(3);

Console.WriteLine(GetArea(t));
Console.WriteLine(GetArea(s));





//--------------Library----------------//

double GetArea<T>(T figure) where T : FigureBase => figure.CalcArea();

class Triangle(double a, double b, double c) : FigureBase
{
    private double p = (a + b + c) / 2;
    public override double CalcArea() => Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    public bool IsRectangular
    {
        get 
        { 
            return a * a + b * b == c * c; 
        }
    }
}


class Circle(double radius) : FigureBase
{
    public override double CalcArea() => Math.PI * radius * radius;
}


abstract class FigureBase
{
    public abstract double CalcArea();
}