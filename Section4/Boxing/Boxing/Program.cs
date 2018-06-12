using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Juan");
            list.Add(DateTime.Today);

            var number = (int)list[1];

            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add();
        }
    }
}
