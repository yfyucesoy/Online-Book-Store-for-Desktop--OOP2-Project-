/**
 * @File frmPayment.cs
 * @Date April, 2019
 * @Author Semi BARUT (semibarut@gmail.com)
 *
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Project
{
    /**
* \brief This form provides to design of payment interface 
* This form shows payment screen,cost etc..
*/
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
            EventLogger.AttachButton(this.Controls);
        }
        myLogin login = myLogin.CreateLogin();

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "Sepetinizde toplam " + login.Cart.PaymentAmount.ToString("0.00") + " TL tutarında ürün bulunmaktadır."+ Environment.NewLine + Environment.NewLine +
                "Ödeme Türünü Seçiniz:";
            lblTotalPrice.Text = "Toplam Tutar: " + login.Cart.PaymentAmount.ToString("0.00") + " TL";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCC.Checked == true)
            {
                tlpPayment4.Visible = true;
            }
            else
                tlpPayment4.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCash.Checked == true)
            {
                tlpPayment4.Visible = false;
            }
            else
                tlpPayment4.Visible = true;
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            bool res = false;
            if(radioCC.Checked == true)
            {
                login.Cart.PaymentType = "Credit Card";
                for (int i = 0; i < mtxtCC.Text.Length; i++)
                {
                    if (mtxtCC.Text[i] == ' ')
                    {
                        res = true;
                    }
                }
                if (res)
                {
                    MessageBox.Show("Lütfen geçerli bir kredi kartı numarası giriniz.", "Hatalı Giriş",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    string products = "";
                    string quantities = "";
                    string ptype = "";
                    for (int i = 0; i < login.Cart.ItemsToPurchase.Count; i++)
                    {
                        products += ((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Product.ID;
                        quantities += ((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Quantity;
                        if (((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Product is Book)
                            ptype += "B";
                        else if (((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Product is Magazine)
                            ptype += "M";
                        else if (((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Product is MusicCD)
                            ptype += "C";
                        if (!(i == login.Cart.ItemsToPurchase.Count - 1))
                        {
                            products += ";";
                            quantities += ";";
                            ptype += ";";
                        }
                    }

                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ECU28KQ\\SQLEXPRESS;Initial Catalog=OOP2;Integrated Security=True");
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                            string ekleme_komutu = "Insert Into Orders(CustomerID, Products, Quantities, pType) values (@CustomerID, @Products, @Quantities, @pType)";
                            SqlCommand ekleme = new SqlCommand(ekleme_komutu, con);
                            ekleme.Parameters.AddWithValue("@CustomerID", login.Cart.CustomerID.ToString());
                            ekleme.Parameters.AddWithValue("@Products", products);
                            ekleme.Parameters.AddWithValue("@Quantities", quantities);
                            ekleme.Parameters.AddWithValue("@pType", ptype);
                            ekleme.ExecuteNonQuery();
                            con.Close();

                            string message = login.Cart.placeOrder() + Environment.NewLine;

                            if (cmbInvoice.SelectedItem.ToString() == "Faturamı e-posta adresime yolla")
                            {
                                message += login.Cart.sendInvoicebyEmail(login.Cart.PaymentAmount);
                            }
                            else
                                message += login.Cart.sendInvoicebySMS(login.Cart.PaymentAmount);

                            MessageBox.Show(message, "Sipariş Onayı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message.ToString());
                    }
                    login.Cart.ItemsToPurchase.Clear();
                    frmHomePage frmHome = new frmHomePage();
                    this.Hide();
                    frmHome.Show();
                }
            }

            if (radioCash.Checked == true)
            {
                login.Cart.PaymentType = "Cash";
                string products = "";
                string quantities = "";
                string ptype = "";
                for (int i = 0; i < login.Cart.ItemsToPurchase.Count; i++)
                {
                    products += ((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Product.ID;
                    quantities += ((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Quantity;
                    if (((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Product is Book)
                        ptype += "B";
                    else if (((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Product is Magazine)
                        ptype += "M";
                    else if (((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Product is MusicCD)
                        ptype += "C";
                    if (!(i == login.Cart.ItemsToPurchase.Count - 1))
                    {
                        products += ";";
                        quantities += ";";
                        ptype += ";";
                    }
                }

                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-ECU28KQ\\SQLEXPRESS;Initial Catalog=OOP2;Integrated Security=True");
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        string ekleme_komutu = "Insert Into Orders(CustomerID, Products, Quantities, pType) values (@CustomerID, @Products, @Quantities, @pType)";
                        SqlCommand ekleme = new SqlCommand(ekleme_komutu, con);
                        ekleme.Parameters.AddWithValue("@CustomerID", login.Cart.CustomerID.ToString());
                        ekleme.Parameters.AddWithValue("@Products", products);
                        ekleme.Parameters.AddWithValue("@Quantities", quantities);
                        ekleme.Parameters.AddWithValue("@pType", ptype);
                        ekleme.ExecuteNonQuery();
                        con.Close();

                        string message = login.Cart.placeOrder() + Environment.NewLine;

                        if (cmbInvoice.SelectedItem.ToString() == "Faturamı e-posta adresime yolla")
                        {
                            message += login.Cart.sendInvoicebyEmail(login.Cart.PaymentAmount);
                        }
                        else
                            message += login.Cart.sendInvoicebySMS(login.Cart.PaymentAmount);

                        MessageBox.Show(message, "Sipariş Onayı",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
                login.Cart.ItemsToPurchase.Clear();
                frmHomePage frmHome = new frmHomePage();
                this.Hide();
                frmHome.Show();
            }
        }
    }
}
