using Assiment5.istruct;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assiment5
{
    internal class Shipment
    {
        private string TrackingCode;
        private string Description;
        private double Weight;
        private decimal DeliveryFee;
        private DeliveryAddress destination;

        public string GetTrakingCode
        {
            get
            {
                return TrackingCode;
            }
            set
            {
                if (string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("trackingCode");
                else
                    TrackingCode = value;



            }

        }

        public string GetDescription
        {
            get
            {

                return Description;

            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))

                    Description = value;


            }

        }

        public double GetWeight
        {
            get
            {
                return Weight;
            }
            set
            {
                if (value > 0)
                {
                    Weight = value;
                }
                else
                {
                    throw new ArgumentException("weight must be grater than 0");
                }


            }
        }


        public decimal GetDeliveryFee
        {
            get
            {
                return DeliveryFee;
            }
            private set
            {
                if (value > 0)
                {
                    DeliveryFee = value;
                }
                else
                {
                    throw new ArgumentException("weight must be grater than 0");
                }


            }
        }



        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }
        }


        // Calculate
        public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5);
            }
        }

        // Constructor 1
        public Shipment(string trackingCode)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
                this.TrackingCode = "UNKNOWN";
            else
                this.TrackingCode = trackingCode;

            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }

        // Constructor 2
        public Shipment(string trackingCode, string description,
            double weight, decimal deliveryFee,
            DeliveryAddress destination)
        {
            this.TrackingCode = !string.IsNullOrWhiteSpace(trackingCode)
                ? trackingCode
                : "UNKNOWN";

            this.Description = "Unknown";
            this.Weight = 1;
            this.DeliveryFee = 50;
            this.destination = destination;

            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        public void PrintShipment()
        {
            Console.WriteLine("Tracking Code : " + TrackingCode);
            Console.WriteLine("Description   : " + Description);
            Console.WriteLine("Weight        : " + Weight + " KG");
            Console.WriteLine("Delivery Fee  : " + DeliveryFee + " EGP");
            Console.WriteLine("Destination   : " + Destination.GetFullAddress());
            Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
            Console.WriteLine("--------------------------------------");
        }
    
    
    
    
    
    }


}