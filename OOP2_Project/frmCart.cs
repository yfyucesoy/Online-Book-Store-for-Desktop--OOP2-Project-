/**
 * @File frmCart.cs
 * @Date April, 2019
 * @Author Yusuf Furkan YUCESOY (yusuffurkanyucesoy@gmail.com)
 *
 */
using System;
using System.Collections;
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
* \brief This form provides to design of user's cart interface 
* This form shows user's cart...
*/
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
            EventLogger.AttachButton(this.Controls);
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ECU28KQ\\SQLEXPRESS;Initial Catalog=OOP2;Integrated Security=True");
        SqlDataAdapter da;
        DataSet dall;
        SqlCommand cmd;

        myLogin login = myLogin.CreateLogin();
        double totalPrice = 0;
        private void urunListele()
        {
            totalPrice = 0;
            lblLoggedUser.Text = login.Kadi + " adlı kullanıcının sepeti:";
            int i;
            ArrayList arrlblNo = new ArrayList() { lblPrdNo1, lblPrdNo2, lblPrdNo3, lblPrdNo4, lblPrdNo5, lblPrdNo6};
            ArrayList arrlblPic = new ArrayList() { picPrd1, picPrd2, picPrd3, picPrd4, picPrd5, picPrd6 };
            ArrayList arrlblName = new ArrayList() { lblPrdName1, lblPrdName2, lblPrdName3, lblPrdName4, lblPrdName5, lblPrdName6 };
            ArrayList arrbtnRmv = new ArrayList() { btnRemove1, btnRemove2, btnRemove3, btnRemove4, btnRemove5, btnRemove6 };
            ArrayList arrnupQ = new ArrayList() { nupPrdQuantity1, nupPrdQuantity2, nupPrdQuantity3, nupPrdQuantity4, nupPrdQuantity5, nupPrdQuantity6 };
            ArrayList arrlblPrice = new ArrayList() { lblPrdPrice1, lblPrdPrice2, lblPrdPrice3, lblPrdPrice4, lblPrdPrice5, lblPrdPrice6 };
            if(login.Cart.ItemsToPurchase.Count != 0)
            {
                btnSatinAl.Visible = true;
                for (i = 0; i < login.Cart.ItemsToPurchase.Count; i++)
                {
                    ((Label)(arrlblNo[i])).Text = (i + 1).ToString();
                    ((PictureBox)(arrlblPic[i])).BackgroundImage = Image.FromFile(((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Product.Image);
                    ((Label)(arrlblName[i])).Text = ((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Product.Name;
                    ((Button)(arrbtnRmv[i])).Visible = true;
                    ((NumericUpDown)(arrnupQ[i])).Visible = true;
                    ((NumericUpDown)(arrnupQ[i])).Value = ((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Quantity;
                    ((Label)(arrlblPrice[i])).Text = ((double)(((NumericUpDown)(arrnupQ[i])).Value) * (((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Product.Price)).ToString("0.00") + " TL";
                }
            }
            else
            {
                lblLoggedUser.Text = "Sepetinizde herhangi bir ürün bulunmamaktadır!";
                btnSatinAl.Visible = false;
            }
                
            if (login.Cart.ItemsToPurchase.Count != 6)
            {
                ((Label)(arrlblNo[login.Cart.ItemsToPurchase.Count])).Text = "";
                ((PictureBox)(arrlblPic[login.Cart.ItemsToPurchase.Count])).BackgroundImage = null;
                ((Label)(arrlblName[login.Cart.ItemsToPurchase.Count])).Text = "";
                ((Button)(arrbtnRmv[login.Cart.ItemsToPurchase.Count])).Visible = false;
                ((NumericUpDown)(arrnupQ[login.Cart.ItemsToPurchase.Count])).Visible = false;
                ((Label)(arrlblPrice[login.Cart.ItemsToPurchase.Count])).Text = "";
            }
            calculateTotal();
            lblTotalPrice.Text = "Sepetinizde toplam " + totalPrice.ToString("0.00") + " TL tutarında ürün bulunmaktadır.";
        }

        private void nupPrdQuantity1_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void nupPrdQuantity2_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void nupPrdQuantity3_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void nupPrdQuantity4_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void nupPrdQuantity5_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void nupPrdQuantity6_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }
        private void calculateTotal()
        {
            totalPrice = 0;
            ArrayList arrnupQ = new ArrayList() { nupPrdQuantity1, nupPrdQuantity2, nupPrdQuantity3, nupPrdQuantity4, nupPrdQuantity5, nupPrdQuantity6 };
            ArrayList arrlblPrice = new ArrayList() { lblPrdPrice1, lblPrdPrice2, lblPrdPrice3, lblPrdPrice4, lblPrdPrice5, lblPrdPrice6 };

            for (int i = 0; i < login.Cart.ItemsToPurchase.Count; i++)
            {
                ((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Quantity = (int)((NumericUpDown)(arrnupQ[i])).Value;
                ((Label)(arrlblPrice[i])).Text = ((double)(((NumericUpDown)(arrnupQ[i])).Value) * (((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Product.Price)).ToString("0.00") + " TL";
                totalPrice += ((double)(((NumericUpDown)(arrnupQ[i])).Value) * (((ItemToPurchase)(login.Cart.ItemsToPurchase[i])).Product.Price));                
            }
            lblTotalPrice.Text = "Sepetinizde toplam " + totalPrice.ToString("0.00") + " TL tutarında ürün bulunmaktadır.";
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
                frmHomePage frmHome = new frmHomePage();
                frmHome.Show();
                this.Hide();
            }
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            urunSil(lblPrdName1);
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            urunSil(lblPrdName2);
        }

        private void btnRemove3_Click(object sender, EventArgs e)
        {
            urunSil(lblPrdName3);
        }

        private void btnRemove4_Click(object sender, EventArgs e)
        {
            urunSil(lblPrdName4);
        }

        private void btnRemove5_Click(object sender, EventArgs e)
        {
            urunSil(lblPrdName5);
        }

        private void btnRemove6_Click(object sender, EventArgs e)
        {
            urunSil(lblPrdName6);
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            urunListele();
        }
        private void urunSil(Label urunSatırı)
        {
            DialogResult remove = MessageBox.Show(urunSatırı.Text + " ürününü sepetinizden çıkarmak istediğinize emin misiniz?", "Ürün Çıkar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (remove == DialogResult.Yes)
            {
                login.Cart.removeProduct(urunSatırı.Text);
            }
            urunListele();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            login.Cart.PaymentAmount = totalPrice;
            frmPayment payment = new frmPayment();
            this.Hide();
            payment.Show();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            frmHomePage frmHome = new frmHomePage();
            frmHome.Show();
            this.Hide();
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

        private void btnSipariş_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.Show();
            this.Hide();
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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAra_Click(sender, e);
            }
        }

        private void frmCart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblPrdName1_Click(object sender, EventArgs e)
        {

        }
    }
}
