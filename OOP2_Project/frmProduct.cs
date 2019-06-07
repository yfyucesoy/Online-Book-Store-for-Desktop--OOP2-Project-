/**
 * @File frmProducts.cs
 * @Date April, 2019
 * @Author Ali Fuat CALIK (farcry_32@hotmail.com)
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
* \brief This form provides to design of homepage interface
* This form shows details of products.
*/
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            EventLogger.AttachButton(this.Controls);
        }
        myLogin login = myLogin.CreateLogin();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ECU28KQ\\SQLEXPRESS;Initial Catalog=OOP2;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        DataSet ds = new DataSet();
        DataSet dall = new DataSet();
        Product prd;

        public void urunGetir(string ID, string type)
        {
            switch (type)
            {
                case "B":
                    cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.Price, Book.Author, Book.Publisher, Book.Page, Prd.Image, Prd.Description From dbo.Book AS Book, dbo.Product AS Prd Where Book.ID = " + ID + " AND Prd.ID = " + ID, con);
                    da.SelectCommand = cmd;
                    try
                    {
                        con.Open();
                        da.Fill(ds);
                        con.Close();

                        prd = new Book((int)(ds.Tables[0].Rows[0].ItemArray[0]), ds.Tables[0].Rows[0].ItemArray[1].ToString(), float.Parse(ds.Tables[0].Rows[0].ItemArray[2].ToString()), ds.Tables[0].Rows[0].ItemArray[3].ToString(), ds.Tables[0].Rows[0].ItemArray[4].ToString(), int.Parse(ds.Tables[0].Rows[0].ItemArray[5].ToString()));
                        prd.Image = ds.Tables[0].Rows[0].ItemArray[6].ToString();
                        lblPrdName.Text = prd.Name;
                        lblPrdInfo1.Text = "Yazar:";
                        lblPrdInfo3.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                        lblPrdInfo2.Text = "Yayın Evi:";
                        lblPrdInfo4.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                        lblPrdPrice.Text = prd.Price.ToString("0.00") + " TL";
                        lblDesc.Text = "Açıklama" + Environment.NewLine + "----------------" + Environment.NewLine + ds.Tables[0].Rows[0].ItemArray[7].ToString() + Environment.NewLine + Environment.NewLine + "Sayfa Sayısı: " + ds.Tables[0].Rows[0].ItemArray[5].ToString();
                        picPrd.Tag = prd.ID;
                        picPrd.BackgroundImage = Image.FromFile(ds.Tables[0].Rows[0].ItemArray[6].ToString());

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot open connection !");
                    }
                break;

                case "M":
                    cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.Price, Maga.Issue, Maga.Type, Prd.Image, Prd.Description From dbo.Magazine AS Maga, dbo.Product AS Prd Where Maga.ID = " + ID + " AND Prd.ID = " + ID, con);
                    da.SelectCommand = cmd;
                    try
                    {
                        con.Open();
                        da.Fill(ds);
                        con.Close();

                        prd = new Magazine((int)(ds.Tables[0].Rows[0].ItemArray[0]), ds.Tables[0].Rows[0].ItemArray[1].ToString(), float.Parse(ds.Tables[0].Rows[0].ItemArray[2].ToString()), int.Parse(ds.Tables[0].Rows[0].ItemArray[3].ToString()), ds.Tables[0].Rows[0].ItemArray[4].ToString());
                        prd.Image = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                        lblPrdName.Text = prd.Name;
                        lblPrdInfo1.Text = "Sayı:";
                        lblPrdInfo3.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                        lblPrdInfo2.Text = "Tür:";
                        lblPrdInfo4.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                        lblPrdPrice.Text = prd.Price.ToString("0.00") + " TL";
                        lblDesc.Text = "Açıklama" + Environment.NewLine + "----------------" + Environment.NewLine + ds.Tables[0].Rows[0].ItemArray[6].ToString();
                        picPrd.Tag = prd.ID;
                        picPrd.BackgroundImage = Image.FromFile(ds.Tables[0].Rows[0].ItemArray[5].ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot open connection !");
                    }
                    ds.Reset();
                    break;

                case "C":
                    cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.Price, Music.Singer, Music.Type, Prd.Image, Prd.Description From dbo.MusicCD AS Music, dbo.Product AS Prd Where Music.ID = " + ID + " AND Prd.ID = " + ID, con);
                    da.SelectCommand = cmd;
                    try
                    {
                        con.Open();
                        da.Fill(ds);
                        con.Close();

                        prd = new MusicCD((int)(ds.Tables[0].Rows[0].ItemArray[0]), ds.Tables[0].Rows[0].ItemArray[1].ToString(), float.Parse(ds.Tables[0].Rows[0].ItemArray[2].ToString()), ds.Tables[0].Rows[0].ItemArray[3].ToString(), ds.Tables[0].Rows[0].ItemArray[4].ToString());
                        prd.Image = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                        lblPrdName.Text = prd.Name;
                        lblPrdInfo1.Text = "Sanatçı:";
                        lblPrdInfo3.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                        lblPrdInfo2.Text = "Tür:";
                        lblPrdInfo4.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                        lblPrdPrice.Text = prd.Price.ToString("0.00") + " TL";
                        lblDesc.Text = "Açıklama" + Environment.NewLine + "----------------" + Environment.NewLine + ds.Tables[0].Rows[0].ItemArray[6].ToString();
                        picPrd.Tag = prd.ID;
                        picPrd.BackgroundImage = Image.FromFile(ds.Tables[0].Rows[0].ItemArray[5].ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot open connection !");
                    }
                    ds.Reset();
                    break;
            }
        }

        private void mAGAZİNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmType frm_Type = new frmType();
            frm_Type.PrdType = "M";
            frm_Type.Show();
            this.Hide();
        }

        private void mÜZİKCDDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmType frm_Type = new frmType();
            frm_Type.PrdType = "C";
            frm_Type.Show();
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
            if( txtSearch.Text.Length > 2)
            {
                bool res = false;
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (login.Kadi == null)
            {
                DialogResult result = MessageBox.Show("Sepetinize ürün eklemek için GİRİŞ yapmanız gerekmektedir." + Environment.NewLine + "Giriş yapmak istiyor musunuz?",
                "Uyarı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    this.btnLogInOut_Click(sender, e);
                }
            }
            else
            {
                ItemToPurchase item = new ItemToPurchase(prd, (int) nupQuantity.Value);
                bool res = login.Cart.addProduct(item);
                if (res)
                    MessageBox.Show(item.Product.Name + " adlı ürün sepetinize eklenmiştir", "Ürün eklendi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Bir Alışverişte sepetinizde en fazla 6 farklı ürün bulunabilir." + Environment.NewLine + "Sepetinize giderek ürünlerinizi görebilirsiniz.", "Ürün eklenemedi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }           
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            if (login.Kadi == null)
            {
                btnLogInOut.Text = "USER LOGIN";
                btnSepet.Hide();
                splitter.Hide();
            }
            else
            {
                btnLogInOut.Text = "EXIT";
                btnSepet.Show();
                splitter.Show();
            }
        }

        private void btnLogInOut_Click(object sender, EventArgs e)
        {
            if (btnLogInOut.Text == "USER LOGIN")
            {
                frmLogin lf = new frmLogin();
                lf.Show();
                this.Hide();
            }
            else
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
                    btnLogInOut.Text = "KULLANICI GİRİŞİ";
                    btnSepet.Hide();
                    splitter.Hide();
                }
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

        private void btnSepet_Click(object sender, EventArgs e)
        {
            frmCart cart = new frmCart();
            cart.Show();
            this.Hide();
        }

        private void frmProduct_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            frmHomePage frmHome = new frmHomePage();
            frmHome.Show();
            this.Hide();
        }
    }
}
