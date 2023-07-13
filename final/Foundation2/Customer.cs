using System.Collections.Generic;
using System;

namespace Foundation2
{
    public class Customer{
      private string name;
      private Address address;

      public Customer(string _name, Address add){
        name = _name;
        address = add;
      }

      public string getName(){
        return name;
      }

      public string getCustomerCountry(){
           string country = address.getCountry();
           return country;
      }

      public string getCustomerAdd(){
        string add =address.getStreet();
        return add;

    }
}
}