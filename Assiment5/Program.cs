using Assiment5.istruct;

namespace Assiment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1

            //a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified? 
            //DeliveryAddress is a struct, which is a value type.
            // When a DeliveryAddress variable is copied, a separate copy of all its fields is created. Any modifications to the copied variable do not affect the original variable.

            //b) What happens when a Customer variable is copied into another variable and one variable modifies the object? 
            //Customer is a class, which is a reference type.
            //When a Customer variable is copied, both variables reference the same object. If one variable modifies the object's fields, the changes are reflected when accessing the object through the other variable.




            #endregion

            #region Question2
            //a) Identify at least three problems with this design from an encapsulation perspective. 
            //1.All fields (Description, Weight, and DeliveryFee) are public, so they can be accessed and modified directly from outside the class.
            //2.There is no validation for the data. For example, Weight or DeliveryFee could be assigned invalid values such as negative numbers.
            //3.The class does not protect its internal data, which breaks the principle of encapsulation.

            // b) How can private fields and public properties improve this design?
            //Make the fields private so they cannot be accessed directly from outside the class.
            //Properties can validate the data before assigning values (for example, ensuring that Weight and DeliveryFee are not negative). 
            //This improves encapsulation, protects the object's data, and makes the class easier to maintain.

            #endregion

            #region Part 02 : Practical  Question1 
            /*  DeliveryAddress Add1;
              Add1.City = "Cairo";
              Add1.Street = "mubarkstreet";
              Add1.BuildingNumber = 1243;

              DeliveryAddress Add2 =Add1;

              Add2.City = "Elax";
              Add2.Street = "Almedstreet";
              Add2.BuildingNumber = 1567;


              Console.WriteLine("-----main Address-----");
              Console.WriteLine(Add1.GetFullAddress());


              Console.WriteLine("-----copied Address-----");
              Console.WriteLine(Add2.GetFullAddress());*/
            #endregion
            #region Part 02 : Practical  Question1 
            /* DeliveryCenter center = new DeliveryCenter();

             // Enter 3 shipments
            for (int i = 1; i <= 3; i++)
             {
                 Console.WriteLine($"Enter Shipment {i} Data");

                 Console.Write("Tracking Code: ");
                 string code = Console.ReadLine();

                 Console.Write("Description: ");
                 string description = Console.ReadLine();

                 Console.Write("Weight: ");
                 double weight = Convert.ToDouble(Console.ReadLine());

                 Console.Write("Delivery Fee: ");
                 decimal fee = Convert.ToDecimal(Console.ReadLine());

                 Console.Write("City: ");
                 string city = Console.ReadLine();

                 Console.Write("Street: ");
                 string street = Console.ReadLine();

                 Console.Write("Building Number: ");
                 int building = Convert.ToInt32(Console.ReadLine());

                 DeliveryAddress address =
                     new DeliveryAddress(city, street, building);

                 Shipment shipment =
                     new Shipment(code, description, weight, fee, address);

                 if (center.AddShipment(shipment))
                     Console.WriteLine("Shipment added successfully.\n");
                 else
                     Console.WriteLine("Delivery Center is full.\n");
             }

             // Print shipments
             Console.WriteLine("\n------ All Shipments ------");

             for (int i = 0; i < 3; i++)
             {
                 if (center[i] != null)
                     center[i].PrintShipment();
             }

             // Search by tracking code
             Console.Write("Enter a tracking code to search: ");
             string searchCode = Console.ReadLine();

             Shipment result = center[searchCode];

             if (result != null)
             {
                 Console.WriteLine("\nShipment Found:");
                 result.PrintShipment();
             }
             else
             {
                 Console.WriteLine("Shipment not found.");
             }

             // Struct Copy Demonstration
             Console.WriteLine("\n------ Struct Copy Test ------");

             DeliveryAddress original =
                 new DeliveryAddress("Cairo", "Tahrir Street", 15);

             DeliveryAddress copied = original;

             copied.BuildingNumber = 20;
             copied.Street = "Makram Ebeid Street";

             Console.WriteLine("Original Address: " +
                 original.GetFullAddress());

             Console.WriteLine("Copied Address: " +
                 copied.GetFullAddress());
         }*/
            #endregion



        }
    }
}