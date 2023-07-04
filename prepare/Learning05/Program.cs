using System;


namespace Learning05
{
class Program
{
    static void Main(string[] args){
        Square sqr = new Square("green", 7);
        Rectangle rec = new Rectangle("blue", 8, 5);
        Circle circ = new Circle("yellow", 9);

        List<Shape> shapes = new List<Shape> ();
        shapes.Add(sqr);
        shapes.Add(rec);
        shapes.Add(circ);

        foreach (Shape shape in shapes){
            string color = shape.GetColor();
            double area = shape.Area();
            Console.WriteLine($"{color}, {area}");
        }

    }
}

}