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
        }
    }
}
