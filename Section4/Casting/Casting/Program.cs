using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Casting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Shape shape = new Text();
            Text text = (Text)shape;
        }
    }
}
