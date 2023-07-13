using System.Collections.Generic;
using System;

namespace Foundation2
{
    public class Address{
       private string _street;
       private string _country;

       public Address(string street, string country){
            _street = street;
            _country = country;
       }

       public string getStreet(){
            return _street;
       }

       public string getCountry(){
            return _country;
       }

    }
}