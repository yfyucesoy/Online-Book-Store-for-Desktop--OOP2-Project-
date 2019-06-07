/**
 * @File IAggregate.cs
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
* \brief The collector is the interface 
* where you specify object options from the Repeater type of objects that host.
*
*/
    interface IAggregate
    {
        IIterator GetIterator();
        string this[int itemIndex] { set; get; }
        int Count { get; }
    }
}
