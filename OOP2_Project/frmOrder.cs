/**
 * @File frmOrder.cs
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
* \brief This form provides to design of order interface
* This form shows to order products and their information
*/
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
            EventLogger.AttachButton(this.Controls);
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        DataSet dall;
        SqlCommand cmd;
        myLogin login = myLogin.CreateLogin();
        string orderNO;
        bool res = false;

        private void listOrders()
        {
            con = new SqlConnection("Data Source=DESKTOP-ECU28KQ\\SQLEXPRESS;Initial Catalog=OOP2;Integrated Security=True");
            da = new SqlDataAdapter();
            try
            {
                con.Open();
                dt = new DataTable();
                dall = new DataSet();
                cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.Price, Book.Author, Book.Publisher, Book.Page, Prd.pType, Prd.Image From dbo.Book AS Book, dbo.Product AS Prd Where Book.ID = Prd.ID", con);
                da.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                try
                {
                    da.Fill(dall, "Book");
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot open connection!");
                }
                cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.Price, Maga.Issue, Maga.Type, Prd.Image, Prd.pType From dbo.Magazine AS Maga, dbo.Product AS Prd Where Maga.ID = Prd.ID", con);
                da.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                try
                {
                    da.Fill(dall, "Magazine");
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot open connection !");
                }
                cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.Price, Music.Singer, Music.Type, Prd.Image, Prd.pType From dbo.MusicCD AS Music, dbo.Product AS Prd Where Music.ID = Prd.ID", con);
                da.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                try
                {
                    da.Fill(dall, "MusicCD");
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot open connection !");
                }
                dt.Reset();
                cmd = new SqlCommand("Select * From Orders Where CustomerID = '" + login.Cart.CustomerID + "'", con);
                da.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Herhangi bir aktif siparişiniz bulunmamaktadır." + Environment.NewLine + "Anasayfaya yönlendirileceksiniz.", "Sipariş Bilgisi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                    frmHomePage frmHome = new frmHomePage();
                    this.Hide();
                    frmHome.Show();
                }
                else if (dt.Rows[0].ItemArray[1].ToString() == login.Cart.CustomerID.ToString())
                {
                    string[] products = dt.Rows[0].ItemArray[2].ToString().Split(';');
                    string[] quantities = dt.Rows[0].ItemArray[3].ToString().Split(';');
                    string[] ptype = dt.Rows[0].ItemArray[4].ToString().Split(';');
                    double total = 0;
                    orderNO = dt.Rows[0].ItemArray[0].ToString();
                    lblPrdName1.Text = "";
                    lblPrdPrice1.Text = "";
                    for (int i = 0; i < products.Length; i++)
                    {
                        lblPrdNo1.Text = "# " + orderNO.ToString();
                        btnRemove.Visible = true;
                        lblDurum.Visible = true;
                        
                        if (ptype[i].ToString() == "B")
                        {
                            for (int j = 0; j < dall.Tables["Book"].Rows.Count; j++)
                                if (dall.Tables["Book"].Rows[j].ItemArray[0].ToString() == products[i])
                                {
                                    lblPrdName1.Text += dall.Tables["Book"].Rows[j].ItemArray[1].ToString() + " - " + quantities[i] + " adet" + Environment.NewLine;
                                    total += double.Parse(dall.Tables["Book"].Rows[j].ItemArray[2].ToString()) * double.Parse(quantities[i]);
                                }
                        }
                        else if (ptype[i].ToString() == "M")
                        {
                            for (int k = 0; k < dall.Tables["Magazine"].Rows.Count; k++)
                                if (dall.Tables["Magazine"].Rows[k].ItemArray[0].ToString() == products[i])
                                {
                                    lblPrdName1.Text += dall.Tables["Magazine"].Rows[k].ItemArray[1].ToString() + " - " + quantities[i] + " adet" + Environment.NewLine;
                                    total += double.Parse(dall.Tables["Magazine"].Rows[k].ItemArray[2].ToString()) * double.Parse(quantities[i]);
                                }
                        }
                        else if (ptype[i].ToString() == "C")
                        {
                            for (int l = 0; l < dall.Tables["MusicCD"].Rows.Count; l++)
                                if (dall.Tables["MusicCD"].Rows[l].ItemArray[0].ToString() == products[i])
                                {
                                    lblPrdName1.Text += dall.Tables["MusicCD"].Rows[l].ItemArray[1].ToString() + " - " + quantities[i] + " adet" + Environment.NewLine;
                                    total += double.Parse(dall.Tables["MusicCD"].Rows[l].ItemArray[2].ToString()) * double.Parse(quantities[i]);
                                }
                        }
                    }
                    lblPrdPrice1.Text = total.ToString("0.00") + " TL";
                }
                con.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            DialogResult remove = MessageBox.Show(orderNO + " numaralı siparişinizi iptal etmek istediğinizden emin misiniz?", "Sipariş İptali",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (remove == DialogResult.Yes)
            {
                con = new SqlConnection("Data Source = DESKTOP-ECU28KQ\\SQLEXPRESS; Integrated Security = True; database = OOP2");
                da = new SqlDataAdapter();
                try
                {
                    con.Open();
                    dt = new DataTable();
                    dall = new DataSet();
                    cmd = new SqlCommand("Delete From dbo.Orders Where OrderID = '" + orderNO + "'", con);
                    da.SelectCommand = cmd;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch(Exception a)
                {
                    MessageBox.Show(a.Message);
                }
                listOrders();
            }            
        }

        private void tsmBook_Click(object sender, EventArgs e)
        {
            frmType frm_Type = new frmType();
            frm_Type.PrdType = "B";
            frm_Type.Show();
            this.Hide();
        }

        private void tsmMagazine_Click(object sender, EventArgs e)
        {
            frmType frm_Type = new frmType();
            frm_Type.PrdType = "M";
            frm_Type.Show();
            this.Hide();
        }

        private void tsmMusicCD_Click(object sender, EventArgs e)
        {
            frmType frm_Type = new frmType();
            frm_Type.PrdType = "C";
            frm_Type.Show();
            this.Hide();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAra_Click(sender, e);
            }
        }
        private void uruneGit(string pos, string type)
        {
            frmProduct frmPrd = new frmProduct();
            frmPrd.Show();
            this.Hide();
            frmPrd.urunGetir(pos, type);
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 2)
            {
                bool res = false;
                da = new SqlDataAdapter();
                dall = new DataSet();
                cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.pType, Book.Author From dbo.Book AS Book, dbo.Product AS Prd Where Book.ID = Prd.ID", con);
                da.SelectCommand = cmd;
                try
                {
                    con.Open();
                    da.Fill(dall, "1");
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot open connection !");
                }
                cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.pType, Maga.Issue From dbo.Magazine AS Maga, dbo.Product AS Prd Where Maga.ID = Prd.ID", con);
                da.SelectCommand = cmd;
                try
                {
                    con.Open();
                    da.Fill(dall, "2");
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot open connection !");
                }
                cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.pType, Music.Singer From dbo.MusicCD AS Music, dbo.Product AS Prd Where Music.ID = Prd.ID", con);
                da.SelectCommand = cmd;
                try
                {
                    con.Open();
                    da.Fill(dall, "3");
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot open connection !");
                }
                for (int i = 0; i < dall.Tables.Count; i++)
                    for (int j = 0; j < dall.Tables[i].Rows.Count; j++)
                    {
                        if (dall.Tables[i].Rows[j].ItemArray[1].ToString() == txtSearch.Text || dall.Tables[i].Rows[j].ItemArray[3].ToString() == txtSearch.Text)
                        {
                            res = true;
                            uruneGit(dall.Tables[i].Rows[j].ItemArray[0].ToString(), dall.Tables[i].Rows[j].ItemArray[2].ToString());
                        }
                    }
                if (res == false)
                {
                    MessageBox.Show("Aradığınız ürün stoklarımızda bulunmamaktadır." + Environment.NewLine + "Lütfen yeni bir arama gerçekleştiriniz.",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen aramak istediğiniz ürünün en az 3 harfini giriniz",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
            }
        }
        private void picLogo_Click(object sender, EventArgs e)
        {
            frmHomePage frmHome = new frmHomePage();
            frmHome.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Sistemden çıkış yapmak istediğinize emin misiniz?", "Çıkış",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (logout == DialogResult.Yes)
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
                        string ekleme_komutu = "UPDATE Cart SET Products = @Products, Quantities = @Quantities, pType = @pType WHERE CustomerID = @CustomerID";
                        SqlCommand ekleme = new SqlCommand(ekleme_komutu, con);
                        ekleme.Parameters.AddWithValue("@CustomerID", login.Cart.CustomerID.ToString());
                        ekleme.Parameters.AddWithValue("@Products", products);
                        ekleme.Parameters.AddWithValue("@Quantities", quantities);
                        ekleme.Parameters.AddWithValue("@pType", ptype);
                        ekleme.ExecuteNonQuery();
                        con.Close();
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
                login.Kadi = null;
                login.Sifre = null;
                login.Cart.ItemsToPurchase.Clear();
            }
        }

        private void frmOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            frmCart cart = new frmCart();
            cart.Show();
            this.Hide();
        }

        private void frmOrder_Activated(object sender, EventArgs e)
        {
            if (res == false)
            {
                listOrders();
                res = true;
            }
                
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
