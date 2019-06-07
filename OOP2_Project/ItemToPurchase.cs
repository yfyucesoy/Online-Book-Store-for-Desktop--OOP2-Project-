/**
 * @File ItemToPurchase.cs
 * @Date April, 2019
 * @Author Ali Fuat CALIK (farcry_32@hotmail.com)
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Project
{
    public class ItemToPurchase
    {
        private Product product; /*!< Definition of product */
        private int quantity; /*!< Definition of quantity */


/**
* \brief Constructor function of the ItemToPurchase class
* \param product, quantity
*  this function assigns to parameters to new instance 
*/
        public ItemToPurchase(Product product, int quantity = 0)
        {
            this.product = product;
            this.quantity = quantity;
        }


/**
* \brief Getter and Setter medhod for quantity
* \param quantity
* \return quantity
*/
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (value > 0)
                    quantity = value;
            }
        }
/**
* \brief Getter and Setter medhod for product
* \param product
* \return product
*/
        internal Product Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }
    }
}
