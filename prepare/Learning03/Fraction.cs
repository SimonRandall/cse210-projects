using System;

namespace learning03{
    public class fraction{
        private int _top;
        private int _bottom;

        public fraction(){
            _top = 1;
            _bottom = 1;
        }

        public fraction(int top){
            _top = top;
            _bottom = 1;
        }

        public fraction(int top, int bottom){
            _top = top;
            _bottom = bottom;
        }

        public int getTop(){
            return _top;
        }
        public void setTop(int top){
            _top = top;
        }

        public int getBottom(){
            return _bottom;
        }
        public void setBottom(int bottom){
            _bottom = bottom;
        }

        public string getFractionString(){
            return $"{_top}/{_bottom}";
        }

        public double getDecimalValue(){
            double dec = Convert.ToDouble(_top)/Convert.ToDouble(_bottom);
            return dec;
        }

    }

}