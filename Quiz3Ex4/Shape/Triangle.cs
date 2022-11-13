using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3Ex4.Interfaces.Shape;

internal class Triangle : IShape
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Base { get; set; }

    public double Height { get; set; }

    public double GetArea()
    {
        return 0.5 * Base * Height;
    }

    public double GetPerimeter()
    { 
        return Side1 + Side2 + Base ; 
    
    }

}
