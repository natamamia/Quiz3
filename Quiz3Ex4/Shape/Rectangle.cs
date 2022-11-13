using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3Ex4.Interfaces.Shape;

internal class Rectangle : IShape
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }

    public double GetArea()
    {

        return Side1 * Side2;
    }

    public double GetPerimeter()
    {

        return Side1 * 2 + Side2 * 2;
    }
   
}
