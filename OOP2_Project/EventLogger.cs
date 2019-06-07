/**
 * @File EventLogger.cs
 * @Date April, 2019
 * @Author Ali Fuat CALIK (farcry_32@hotmail.com)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP2_Project {
/**
* \brief Class for records
*
*/


    public class EventLogger
    {


/**
* \brief This function listener for button click events
* \param kontroller
*/
        public static void AttachButton(Control.ControlCollection kontroller)
        {
            foreach (var item in kontroller.Cast<Control>())
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.Click += SaveLog;
                }
                else
                {
                    AttachButton(item.Controls);
                }
            }
        }

/**
* \brief This function writing logs to log.txt file
*/
        public static void SaveLog(object sender, EventArgs eventargs)
        {
            string kullanıcı="Guest";
            Button btn =sender as Button;
            myLogin user = myLogin.CreateLogin();
            StreamWriter strw = new StreamWriter((Application.StartupPath + "\\log.txt"),
                true);
            if (user.Kadi!=null)kullanıcı = user.Kadi;
            strw.WriteLine(kullanıcı + " | Clicked | " + btn.Name +  " | " + DateTime.Now);
            strw.Close();

        }
    }
}
