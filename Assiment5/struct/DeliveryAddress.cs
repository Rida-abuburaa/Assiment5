using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Assiment5.istruct
{
    public struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;



        public DeliveryAddress(string city , string street , int buildingNumber )
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"{BuildingNumber}, {Street}, {City}";
        }
    }
 
}
