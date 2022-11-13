using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3Ex4.Interfaces.Shape;

internal class Trapezium : IShape
{
    public double Base1 { get; set; }

    public double Base2 { get; set; }

    public double Leg { get; set; }

    public double Height { get; set; }

    public double GetArea()
    {
        return Base1 + Base2 + Leg * 2;
    }

    public double GetPerimeter()
    {
        return Base1 + Base2 + Leg * 2;
    }
}
