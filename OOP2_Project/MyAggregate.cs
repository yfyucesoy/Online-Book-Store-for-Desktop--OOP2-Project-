/**
 * @File MyAggregate.cs
 * @Date April, 2019
 * @Author Semi BARUT (semibarut@gmail.com)
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
* \brief Class for MyAggregate for using ıterator pattern in our project
*
*/
    class MyAggregate : IAggregate
    {
        List<string> values_ = null;
/**
* \brief Constructor function of the MyAggregate class
* this function assigns to string type list to class parameter which is list type 
*/
        public MyAggregate()
        {
            values_ = new List<string>();
        }

        #region IAggregate Members

        public IIterator GetIterator()
        {
            return new MyIterator(this);
        }

        #endregion
/**
* \brief Getter and Setter medhod for list index 
* \param itemIndex
 * \return values_[itemIndex]
*/
        public string this[int itemIndex]
        {
            get
            {
                if (itemIndex < values_.Count)
                {
                    return values_[itemIndex];
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                values_.Add(value);
            }
        }
/**
* \brief Getter medhod for length of values_ parameter 
* \return length of list
*/
        public int Count
        {
            get
            {
                return values_.Count;
            }
        }
    }
}
