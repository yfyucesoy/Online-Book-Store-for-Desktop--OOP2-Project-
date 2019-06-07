/**
 * @File Product.cs
 * @Date April, 2019
 * @Author Yusuf Furkan YUCESOY (yusuffurkanyucesoy@gmail.com)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Project
{
/**
* \brief Base Class for Products
*
*/
    public abstract class Product
    {
        private int id;  /*!< Definition of ID */
        private string name;  /*!< Definition of name */
        private double price;  /*!< Definition of price */
        private string image;


/**
* \brief Constructor function of the Product class
* \param ID, name, price
*  this function assigns to parameters to new instance 
*/
        public Product(int ID = 0, string name = "noname", double price = 0)
        {
            this.id = ID;
            this.name = name;
            this.price = price;
        }

/**
* \brief Getter and Setter medhod for ID 
* \param ID
* \return ID
*/
        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

/**
* \brief Getter and Setter medhod for Name 
* \param name
* \return name
*/
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

/**
* \brief Getter and Setter medhod for Price 
* \param price
* \return price
*/
        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

/**
* \brief virtual function of printProperties
* this function will be overrided by inherited classes
* \return string type values
*/
        public virtual string printProperties()
        {
            return (name + ";" + price.ToString("0.00"));
        }
    }
}
