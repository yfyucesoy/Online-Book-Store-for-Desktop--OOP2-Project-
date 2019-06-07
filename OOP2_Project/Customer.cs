/**
 * @File Customer.cs
 * @Date April, 2019
 * @Author Ali Fuat CALIK (farcry_32@hotmail.com)
 *
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Project
{

/**
* \brief Class for customers who is using this app
*
*/
    class Customer
    {
        private int customerID;
        private string name;
        private string address;
        private string email;
        private string username;
        private string password;

/**
* \brief Getter and Setter methods for Customer class attributes 
* \param all attributes
* \return all attributes
*/
        public int CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }

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

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public void printCustomerDetails()
        {
            //dolacak
        }
        public void saveCustomer()
        {
            //dolacak
        }
        public void printCustomerPurchases()
        {
            //dolacak
        }

    }
}
