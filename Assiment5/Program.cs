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




        }
    }
}
