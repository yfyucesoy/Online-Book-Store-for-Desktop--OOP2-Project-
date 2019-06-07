/**
 * @File IIterator.cs
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
* \brief Interface for iterator pattern
*
*/
    interface IIterator
    {
        string FirstItem { get; }
        string NextItem { get; }
        string CurrentItem { get; }
        bool IsDone { get; }
    }
}
