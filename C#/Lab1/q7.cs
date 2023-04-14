using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("A shape is drawn.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("A circle is drawn.");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("A rectangle is drawn.");
        }
    }

    public class Program6
    {
        public static void Main()
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Shape();
            shapes[1] = new Circle();
            shapes[2] = new Rectangle();

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }

}
