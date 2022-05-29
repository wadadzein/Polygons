using Polygons.Library;
using System;

var square = new Square(5);

DisplayPolygons("Square", square);

var triangle = new Triangle(4);

DisplayPolygons("Triangle", triangle);

var octagon = new Octagon(3);

DisplayPolygons("Octagon", octagon);

Console.Read();

 static void DisplayPolygons(string Type, dynamic Polygon)
{

    try
    {
        Console.WriteLine("{0}: Number Of Sides is {1}", Type, Polygon.NumberOfSides);
        Console.WriteLine("{0}: Side Length is {1}", Type, Polygon.SideLength);
        Console.WriteLine("{0}: Perimter is {1}", Type, Polygon.GetPerimeter());
        Console.WriteLine("{0}: Area is {1}", Type, Math.Round(Polygon.GetArea(), 2));
        Console.WriteLine();
    }   
    catch (Exception ex)
    {
        Console.WriteLine("Exception thrown while trying to process {0}:\n {1}", Type, ex.GetType().Name);
        Console.WriteLine();

    }
    
    
    


}
