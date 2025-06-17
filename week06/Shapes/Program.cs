using System;

class Program
{
    static void Main(string[] args)
    {
        Square cuadro = new Square("Red", 2.1);

        Console.WriteLine($"{cuadro.GetColor()}");
        Console.WriteLine($"{cuadro.GetArea()}");

        Console.WriteLine("");

        Rectangle rectangulo = new Rectangle("Blue", 2.21, 2.21);
        Console.WriteLine($"{rectangulo.GetColor()}");
        Console.WriteLine($"{rectangulo.GetArea()}");

        Console.WriteLine("");

        Circle circulo = new Circle("Orange", 4);
        Console.WriteLine($"{circulo.GetColor()}");
        Console.WriteLine($"{circulo.GetArea()}");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(cuadro);
        shapes.Add(rectangulo);
        shapes.Add(circulo);

        foreach (Shape s in shapes)
        {
            Console.Write($"{s.GetColor()} ");
            Console.Write($"{s.GetArea()} ");
        }

    }
}