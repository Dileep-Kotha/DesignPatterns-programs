using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface Shape
    {
        void draw();
    }
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle shape");
        }

    }
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Circle shape");
        }

    }
    public class ShapeFactory
    {
        
        public Shape GetShape(string sh)
        {
            if (sh == null)
            {
                return null;
            }
            else if (sh.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase)) // Use StringComparison for case-insensitive comparison
            {
                return new Circle();
            }
            else if (sh.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase)) // Added logic for Rectangle
            {
                return new Rectangle();
            }
            return null; // Default return if the shape type is not recognized
        }
       
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            Shape s1 = shapeFactory.GetShape("CIRCLE");
            s1.draw();
            Shape s2 = shapeFactory.GetShape("RECTANGLE");
            s2.draw();



        }
    }
}