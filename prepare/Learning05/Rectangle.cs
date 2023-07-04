using System.Collections.Generic;
using System;

namespace Learning05
{
    public class Rectangle : Shape{
        private double _length;
        private double _width;

    public Rectangle(string color, double length, double width){
        base.SetColor(color);
        _length = length;
        _width = width;
    }

    public override double Area(){
        double area = _length * _width;
        return area;
    }

      
    }
}