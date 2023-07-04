using System.Collections.Generic;
using System;

namespace Learning05
{
    public class Square : Shape{
        private double _side;

    public Square(string color, double side){
        base.SetColor(color);
        _side = side;
    }

    public override double Area(){
        double area = _side * _side;
        return area;
    }

      
    }
}