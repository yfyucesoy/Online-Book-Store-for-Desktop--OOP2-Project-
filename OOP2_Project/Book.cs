/**
 * @File Book.cs
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
 * \brief Class for Book types product inherited by Product
 *
 */
    class Book : Product
    {
        private string author; /*!< Definition of author */
        private string publisher; /*!< Definition of publisher */
        private int page; /*!< Definition of page */

/**
* \brief Getter and Setter medhod for author 
* \param author
* \return author
*/
        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

/**
* \brief Getter and Setter medhod for publisher 
* \param publisher
* \return publisher
*/
        public string Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                publisher = value;
            }
        }

/**
* \brief Getter and Setter medhod for page 
* \param page
* \return page
*/
        public int Page
        {
            get
            {
                return page;
            }

            set
            {
                page = value;
            }
        }

/**
* \brief Constructor function of the Book class
* \param ID, name, price, author, publisher, page
*  this function assigns to parameters to new instance 
*/
        public Book(int ID = 0, string name = "noname", double price = 0, string author = "N/A", string publisher = "N/A", int page = 0) : base (ID, name, price)
        {
            this.author = author;
            this.publisher = publisher;
            this.page = page;
        }

/**
* \brief overrided function of printProperties
* \return string type values
*/
        public override string printProperties()
        {
            string[] basePrint = base.printProperties().Split(';');
            return ( basePrint[0] + Environment.NewLine + "---------------" + Environment.NewLine + author + Environment.NewLine + Environment.NewLine + publisher + Environment.NewLine + Environment.NewLine + basePrint[1] + " TL");
        }

    }
}
