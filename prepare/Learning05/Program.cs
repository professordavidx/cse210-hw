using System;
using Learning05;


class Program
{
    static void Main(string[] args)
    {
        // Square square1 = new Square("red",4);
        // Console.WriteLine(square1.GetArea());
        // Console.WriteLine(square1.GetColor());


        // Rectangle rectangle1 = new Rectangle("blue",4,5);
        // Console.WriteLine(rectangle1.GetArea());
        // Console.WriteLine(rectangle1.GetColor());

        // Circle circle1 = new Circle("Green", 5);
        // Console.WriteLine(circle1.GetArea());
        // Console.WriteLine(circle1.GetColor());

        // List<Shape> shapes = new List<Shape>();
        // shapes.Add(rectangle1);
        // shapes.Add(square1);
        // shapes.Add(circle1);

        // foreach (Shape sh in shapes)
        // {
        //     double area = sh.GetArea();
        //     string color = sh.GetColor();
        //     Console.WriteLine(area);
        //     Console.WriteLine(color);
        // }

        // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = s.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }



    }
}
