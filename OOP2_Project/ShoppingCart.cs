using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Project
{
    class ShoppingCart
    {
        private ArrayList itemsToPurchase = new ArrayList();
        private int customerID;
        private double paymentAmount;
        private string paymentType;
        public ArrayList ItemsToPurchase
        {
            get
            {
                return itemsToPurchase;
            }

            set
            {
                itemsToPurchase = value;
            }
        }

        public double PaymentAmount
        {
            get
            {
                return paymentAmount;
            }

            set
            {
                paymentAmount = value;
            }
        }

        public string PaymentType
        {
            get
            {
                return paymentType;
            }

            set
            {
                paymentType = value;
            }
        }

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

        public string printProducts()
        {
            string prd = "";
            for(int i = 0; i < itemsToPurchase.Count; i ++)
            {
                prd += itemsToPurchase[i];
            }
            return prd;
        }
        public bool addProduct(ItemToPurchase item)
        {
            bool res = false;
            for (int i = 0; i < itemsToPurchase.Count; i++)
            {
                if (((ItemToPurchase)itemsToPurchase[i]).Product.Name == item.Product.Name)
                {
                    ((ItemToPurchase)itemsToPurchase[i]).Quantity += item.Quantity;
                    res = true;
                }
            }
            if(itemsToPurchase.Count <= 5 && res == false)
            {
                itemsToPurchase.Add(item);
                res = true;
            }
            return (res);
        }
        public void removeProduct(string name)
        {
            for (int i = 0; i < itemsToPurchase.Count; i++)
            {
                if (((ItemToPurchase)itemsToPurchase[i]).Product.Name == name)
                {
                    itemsToPurchase.RemoveAt(i);
                }
            }
        }

        public string placeOrder()
        {
            return ("Siparişiniz alınmıştır. Ürünlerin hazırlanma süreci 3 ila 5 gündür." + Environment.NewLine);
        }

        public string cancelOrder(string orderNo)
        {
            return (orderNo + " numaralı siparişiniz iptal edilmiştir." + Environment.NewLine + "Anasayfaya yönlendirileceksiniz.");
        }

        public string sendInvoicebySMS(double amount)
        {
            return (amount.ToString("0.00") + " TL tutarındaki siparişinizin faturası SMS olarak iletilmiştir." + Environment.NewLine + Environment.NewLine + "Anasayfaya yönlendirileceksiniz.");
        }

        public string sendInvoicebyEmail(double amount)
        {
            return (amount.ToString("0.00") + " TL tutarındaki siparişinizin faturası E-posta adresinize iletilmiştir." + Environment.NewLine + Environment.NewLine + "Anasayfaya yönlendirileceksiniz.");
        }

    }
}
