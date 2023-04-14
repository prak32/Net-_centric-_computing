using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface IShape
    {
        double GetArea();
    }

    public interface IRectangle
    {
        double Width { get; set; }
        double Height { get; set; }
    }

    public class Rectangles : IShape, IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }

    public class Program5
    {
        public static void Main()
        {
            Rectangles rectangle = new Rectangles { Width = 10, Height = 40 };
            Console.WriteLine("Width of rectangle: " + rectangle.Width);
            Console.WriteLine("Height of rectangle: " + rectangle.Height);
            Console.WriteLine("Area of rectangle: " + rectangle.GetArea());
        }
    }

}
