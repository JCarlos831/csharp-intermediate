using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
