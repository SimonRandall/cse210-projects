using System.Collections.Generic;
using System;

namespace Foundation2
{
    public class Product{
       private string name;
       private string id;
       private double price;
       private int quantity  = 1;

       public Product(string product, string _id, double _price){
            name = product;
            id = _id;
            price = _price;
        }

        public double calculateCost(){
            double cost = price * Convert.ToDouble(quantity);
            return cost;
        }

        public string getName(){
            return name;
        }

        public string getId(){
            return id;
        }

        public double getPrice(){
            return price;
        }

        public int getQuantity(){
            return quantity;
        }

        public void setQuantity(int amount){
            quantity = amount;
        }
    }
}