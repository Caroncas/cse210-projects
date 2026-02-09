using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        //Keep track of different shapes cut out of paper
        //Shapes keep track of paper color
        //Method to compute the area
        //store lengths of sides
        //squares, (color, single side)
        //rectangles (color, length, width)
        //circle(color, radius)
        //iterate through list and display areas
        List<Shapes> shapes = new List<Shapes>();
        Squares square = new Squares("purple", 12);
        shapes.Add(square);
        Circles circle1 = new Circles("green", 3);
        shapes.Add(circle1);
        Rectancles rectangle = new Rectancles("orange", 12, 13.5);
        shapes.Add(rectangle);
        Squares square2 = new Squares("pink", 27);
        shapes.Add(square2);
        Circles circle2 = new Circles("indigo", 12);
        shapes.Add(circle2);

        foreach (Shapes shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} {shape.GetShapeType()} has an area of {shape.GetArea()} inches squared.");
        }

    }
}