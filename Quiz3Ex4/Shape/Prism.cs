using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3Ex4.Interfaces.Shape;

internal class Prism : IShape
{
    public double SurfaceArea { get; set; }
    public double BaseArea { get; set; }

    public double GetArea()
    {
        return 2 * BaseArea + SurfaceArea;
    }

    public double GetPerimeter()
    { 
        return SurfaceArea - BaseArea;
    }

}
