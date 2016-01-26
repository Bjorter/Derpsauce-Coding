using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrawingObject do = new DrawingObject();
            Circle circle = new Circle();
            circle.Name = "My Circle";
            circle.Draw();

            Square square = new Square();
            square.Name = "My Square";
            square.Draw();

            //Create a list collection for Drawing Objects

            List<DrawingObject> drawingObjects = new List<DrawingObject>();

            //Add new objects to collection

            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Square());
            
            //Loop collection and draw objects

            Console.WriteLine("\nDrawing objects in a list:");
            Console.ReadLine();
            foreach(DrawingObject DrawingObject in drawingObjects)
            {
                DrawingObject.Draw();
            }


            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();


        }
    }
}
