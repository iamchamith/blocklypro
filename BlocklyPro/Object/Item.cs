using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocklyPro.Object
{
    public class Item
    {
        public string ImageUrl { get; }
        public Point Location { get; }
        public Size Size { get; }
        public Item(string imageUrl, Point location, Size size)
        {
            ImageUrl = imageUrl;
            Location = location;
            Size = size;
        }


    }
}
