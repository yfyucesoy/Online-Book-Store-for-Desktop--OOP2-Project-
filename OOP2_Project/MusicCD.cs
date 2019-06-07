/**
 * @File MusicCD.cs
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
* \brief Class for MusicCD types product inherited by Product
*
*/
    class MusicCD : Product
    {

        private string singer; /*!< Definition of singer */
        private string type; /*!< Definition of type */

/**
* \brief Constructor function of the MusicCD class
* \param ID, name, price, singer, type
*  this function assigns to parameters to new instance 
*/
        public MusicCD(int ID = 0, string name = "noname", double price = 0, string singer = "N/A", string type = "N/A") : base(ID, name, price)
        {
            this.singer = singer;
            this.type = type;
        }

/**
* \brief Getter and Setter medhod for singer 
* \param singer
* \return singer
*/
        public string Singer
        {
            get
            {
                return singer;
            }

            set
            {
                singer = value;
            }
        }

        /**
        * \brief Getter and Setter medhod for type 
        * \param type
        * \return type
*/
        public string Type
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
            return (basePrint[0] + Environment.NewLine + "---------------" + Environment.NewLine + singer + Environment.NewLine + Environment.NewLine + type + Environment.NewLine + Environment.NewLine + basePrint[1].ToString() + " TL");
        }
    }
}
