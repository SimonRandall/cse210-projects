using System.Collections.Generic;
using System;

namespace Foundation2
{
    public class Order{
      private List<Product> products = new List<Product>();
      private Customer customer;
      private double total_cost = 0;

      public Order(Customer person){
        customer = person;
      }

      public void addProduct(Product item){
            products.Add(item);
      }

      public double totalCost(){
        foreach (Product item in products){
           double cost = item.calculateCost();
           total_cost = total_cost + cost;
        }
        if (customer.getCustomerCountry() == "USA"){
            total_cost = total_cost + 5;
        }
        else {
            total_cost = total_cost + 35;
        }
        return total_cost;
      }

      public void displayShipping(){
        string address = customer.getCustomerAdd();
        string country = customer.getCustomerCountry();
        string person = customer.getName();
        Console.WriteLine("Shipping Label");
        Console.WriteLine($"{person} : {address},{country}");
      }

      public void displayPacking(){
        Console.WriteLine("Packing List:");
        foreach (Product item in products){
            string name = item.getName();
            string id = item.getId();
            Console.WriteLine($"{name} : {id}");
        }
      }
      
    }
}