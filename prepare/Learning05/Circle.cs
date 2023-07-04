using System.Collections.Generic;
using System;

namespace Learning05
{
    public class Circle : Shape{
        private double _side;

    public Circle(string color, double side){
        base.SetColor(color);
        _side = side;
    }

    public override double Area(){
        double radius = _side / 2;
        double area = (radius * radius) * Math.PI;
        return area;
    }

      
    }
}