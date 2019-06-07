/**
 * @File Magazine.cs
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
* \brief Class for Magazine types product inherited by Product
*
*/
    class Magazine : Product
    {
        private int issue; /*!< Definition of Issue */
        private string type;/*!< Definition of type */

/**
* \brief Constructor function of the Magazine class
* \param ID, name, price, issue, type
*  this function assigns to parameters to new instance 
*/
        public Magazine(int ID = 0, string name = "noname", double price = 0, int issue = 1, string type = "N/A") : base(ID, name, price)
        {
            this.issue = issue;
            this.type = type;
        }

/**
* \brief Getter and Setter medhod for issue 
* \param issue
* \return issue
*/
        public int Issue
        {
            get
            {
                return issue;
            }

            set
            {
                issue = value;
            }
        }

/**
* \brief Getter and Setter medhod for type 
* \param type
* \return type
*/
        private string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
/**
* \brief overrided function of printProperties
* \return string type values
*/
        public override string printProperties()
        {
            string[] basePrint = base.printProperties().Split(';');
            return (basePrint[0] + Environment.NewLine + "---------------" + Environment.NewLine + issue + ". Sayı" + Environment.NewLine + Environment.NewLine + Type + Environment.NewLine + Environment.NewLine + basePrint[1].ToString() + " TL");
        }
    }
}
