using System;
namespace BakeryShoppingCart.Exceptions
{
    public class CakeNotFound : Exception
    {
        public CakeNotFound(string errorMessage) : base(errorMessage)
        {
        }
    }
}
