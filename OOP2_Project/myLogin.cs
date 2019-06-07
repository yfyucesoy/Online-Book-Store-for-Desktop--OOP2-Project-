using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Project
{
    class myLogin
    {
        private static myLogin mylg;
        private static ShoppingCart cart;
        private string kadi;
        private string sifre;        

        private myLogin() { }
        public string Kadi
        {
            get
            {
                return kadi;
            }

            set
            {
                kadi = value;
            }
        }

        public string Sifre
        {
            get
            {
                return sifre;
            }

            set
            {
                sifre = value;
            }
        }

        internal ShoppingCart Cart
        {
            get
            {
                return cart;
            }

            set
            {
                cart = value;
            }
        }

        public static myLogin CreateLogin()
        {
            if (mylg == null)
            {
                cart = new ShoppingCart();
                mylg = new myLogin();
            }
            return mylg;
        }
    }
}
