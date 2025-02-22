using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_3
{
    //3.2 Product Availability
    //Write a program for an e-commerce application where:
    //If the product stock is 0, throw a ProductOutOfStockException.

    public class ProductStock

    {
        static int Stock = 0;

        public void BuyProduct(int purchaseQuantity)
        {

            try
            {
                if (purchaseQuantity > Stock || Stock == 0)
                {
                    throw new ProductOutOfStockException("Sorry! Not enough stock available.");
                }

                Stock -= purchaseQuantity;
                Console.WriteLine($"Purchase successful! Remaining stock: {Stock}");
            }
            catch (ProductOutOfStockException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
