using System.Collections.Generic;
using System;

namespace Learning05
{
    public abstract class Shape{
        private string _color;


    public string GetColor(){
        return _color;
    }

    public void SetColor(string color){
        _color = color;
    }

    public abstract double Area();

    }
}