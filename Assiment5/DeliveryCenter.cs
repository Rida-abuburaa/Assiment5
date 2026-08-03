using System;
using System.Collections.Generic;
using System.Text;

namespace Assiment5
{
    class DeliveryCenter
    {
        private Shipment[] shipments = new Shipment[10];

        // Integer indexer
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];

                return null;
            }

            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }

        // String indexer
        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (Shipment shipment in shipments)
                {
                    if (shipment != null &&
                        shipment.GetTrakingCode == trackingCode)
                        return shipment;
                }

                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }
    }
}
