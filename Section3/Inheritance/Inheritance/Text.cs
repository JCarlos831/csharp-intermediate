using System;
namespace Inheritance
{
    public class Text : PresentaionObject
    {
        public int FontSize
        {
            get;
            set;
        }

        public string FontName
        {
            get;
            set;
        }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
}
