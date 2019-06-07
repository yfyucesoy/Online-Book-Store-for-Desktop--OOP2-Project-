/**
 * @File Form1.cs
 * @Date April, 2019
 * @Author Yusuf Furkan YUCESOY (yusuffurkanyucesoy@gmail.com)
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace OOP2_Project
{
/**
* \brief This form provides to design of homepage interface
* This form shows user login, some of products, search bar and categories of content,etc..
*/
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
            EventLogger.AttachButton(this.Controls);
        }
        myLogin login = myLogin.CreateLogin();
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        DataSet dall;
        Product prd;
        Random rnd = new Random(DateTime.Now.Millisecond);

        private void frmHomePage_Load(object sender, EventArgs e)
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
                

            con = new SqlConnection("Data Source=DESKTOP-ECU28KQ\\SQLEXPRESS;Initial Catalog=OOP2;Integrated Security=True");
            da = new SqlDataAdapter();
            ds = new DataSet();
            dall = new DataSet();
            cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.Price, Book.Author, Book.Publisher, Book.Page, Prd.pType, Prd.Image From dbo.Book AS Book, dbo.Product AS Prd Where Book.ID = Prd.ID", con);
            da.SelectCommand = cmd;
            try
            {
                con.Open();
                da.Fill(ds);
                da.Fill(dall, "1");
                con.Close();

                int i, j = 0; // i random için, j döngü için
                ArrayList arrLbl = new ArrayList() { lblKitap1, lblKitap2, lblKitap3 }; // labelleri tutmak için
                ArrayList arrPic = new ArrayList() { picKitap1, picKitap2, picKitap3 }; // resimleri tutmak için
                List<int> randContainer = new List<int>(); // farklı randomları tutmak için

                foreach (Label lbl in arrLbl) // her bir label için
                {
                    do
                    {
                        i = (rnd.Next(ds.Tables[0].Rows.Count));
                    } while (randContainer.Contains(i)); // diğer randomlardan farklı olmadığı sürece
                    randContainer.Add(i); // benzersiz random değerleri bul // her sırada farklı ürün olsun

                    prd = new Book((int)(ds.Tables[0].Rows[i].ItemArray[0]), ds.Tables[0].Rows[i].ItemArray[1].ToString(), float.Parse(ds.Tables[0].Rows[i].ItemArray[2].ToString()), ds.Tables[0].Rows[i].ItemArray[3].ToString(), ds.Tables[0].Rows[i].ItemArray[4].ToString(), int.Parse(ds.Tables[0].Rows[i].ItemArray[5].ToString()));
                    lbl.Text = prd.printProperties();
                    ((PictureBox)arrPic[j]).Tag = prd.ID;
                    ((PictureBox)(arrPic[j++])).BackgroundImage = Image.FromFile(ds.Tables[0].Rows[i].ItemArray[7].ToString());
                }
                randContainer.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot open connection !");
            }
            ds.Reset();
            cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.Price, Maga.Issue, Maga.Type, Prd.Image, Prd.pType From dbo.Magazine AS Maga, dbo.Product AS Prd Where Maga.ID = Prd.ID", con);
            da.SelectCommand = cmd;
            try
            {
                con.Open();
                da.Fill(ds);
                da.Fill(dall, "2");
                con.Close();

                int i, j = 0;
                ArrayList arrLbl = new ArrayList() { lblMagazine1, lblMagazine2, lblMagazine3 };
                ArrayList arrPic = new ArrayList() { picMagazine1, picMagazine2, picMagazine3 };
                List <int> randContainer = new List <int>();

                foreach (Label lbl in arrLbl)
                {
                    do
                    {
                        i = (rnd.Next(ds.Tables[0].Rows.Count));
                    } while (randContainer.Contains(i));
                    randContainer.Add(i);

                    prd = new Magazine((int)(ds.Tables[0].Rows[i].ItemArray[0]), ds.Tables[0].Rows[i].ItemArray[1].ToString(), float.Parse(ds.Tables[0].Rows[i].ItemArray[2].ToString()), int.Parse(ds.Tables[0].Rows[i].ItemArray[3].ToString()), ds.Tables[0].Rows[i].ItemArray[4].ToString());
                    lbl.Text = prd.printProperties();
                    ((PictureBox)arrPic[j]).Tag = prd.ID;
                    ((PictureBox)arrPic[j++]).BackgroundImage = Image.FromFile(ds.Tables[0].Rows[i].ItemArray[5].ToString());
                }
                randContainer.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot open connection !");
            }
            ds.Reset();
            cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.Price, Music.Singer, Music.Type, Prd.Image, Prd.pType From dbo.MusicCD AS Music, dbo.Product AS Prd Where Music.ID = Prd.ID", con);
            da.SelectCommand = cmd;
            try
            {
                con.Open();
                da.Fill(ds);
                da.Fill(dall, "3");
                con.Close();

                int i, j = 0;
                ArrayList arrLbl = new ArrayList() { lblMusicCD1, lblMusicCD2, lblMusicCD3 };
                ArrayList arrPic = new ArrayList() { picMusicCD1, picMusicCD2, picMusicCD3 };
                List<int> randContainer = new List<int>();

                foreach (Label lbl in arrLbl)
                {
                    do
                    {
                        i = (rnd.Next(ds.Tables[0].Rows.Count));
                    } while (randContainer.Contains(i));
                    randContainer.Add(i);

                    prd = new MusicCD((int)(ds.Tables[0].Rows[i].ItemArray[0]), ds.Tables[0].Rows[i].ItemArray[1].ToString(), float.Parse(ds.Tables[0].Rows[i].ItemArray[2].ToString()), ds.Tables[0].Rows[i].ItemArray[3].ToString(), ds.Tables[0].Rows[i].ItemArray[4].ToString());
                    lbl.Text = prd.printProperties();
                    ((PictureBox)arrPic[j]).Tag = prd.ID;
                    ((PictureBox)arrPic[j++]).BackgroundImage = Image.FromFile(ds.Tables[0].Rows[i].ItemArray[5].ToString());
                }
                randContainer.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot open connection !");
            }

            MyAggregate aggr = new MyAggregate();
            int k = 0;
            for (int i = 0; i < dall.Tables.Count; i++)
                for (int j = 0; j < dall.Tables[i].Rows.Count; j++)
                {
                    aggr[k++] = dall.Tables[i].Rows[j].ItemArray[1].ToString();
                    if (dall.Tables[i].Rows[j].ItemArray[6].ToString() == "B" || dall.Tables[i].Rows[j].ItemArray[6].ToString() == "C")
                        aggr[k++] = dall.Tables[i].Rows[j].ItemArray[3].ToString();
                }
            IIterator iter = aggr.GetIterator();
            AutoCompleteStringCollection suggestStageName = new AutoCompleteStringCollection();
            for (string s = iter.FirstItem; iter.IsDone == false; s = iter.NextItem)
                suggestStageName.Add(s);
            txtSearch.AutoCompleteCustomSource = suggestStageName;
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void lnkKitap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmType frm_Type = new frmType();
            frm_Type.PrdType = "B";
            frm_Type.Show();
            this.Hide();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmType frm_Type = new frmType();
            frm_Type.PrdType = "M";
            frm_Type.Show();
            this.Hide();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void picKitap1_Click(object sender, EventArgs e)
        {
            uruneGit(picKitap1.Tag.ToString(), "B");
        }
        private void picKitap2_Click(object sender, EventArgs e)
        {
            uruneGit(picKitap2.Tag.ToString(), "B");
        }
        private void picKitap3_Click(object sender, EventArgs e)
        {
            uruneGit(picKitap3.Tag.ToString(), "B");
        }
        private void picMagazine1_Click(object sender, EventArgs e)
        {
            uruneGit(picMagazine1.Tag.ToString(), "M");
        }
        private void picMagazine2_Click(object sender, EventArgs e)
        {
            uruneGit(picMagazine2.Tag.ToString(), "M");
        }
        private void picMagazine3_Click(object sender, EventArgs e)
        {
            uruneGit(picMagazine3.Tag.ToString(), "M");
        }
        private void picMusicCD1_Click(object sender, EventArgs e)
        {
            uruneGit(picMusicCD1.Tag.ToString(), "C");
        }
        private void picMusicCD2_Click(object sender, EventArgs e)
        {
            uruneGit(picMusicCD2.Tag.ToString(), "C");
        }
        private void picMusicCD3_Click(object sender, EventArgs e)
        {
            uruneGit(picMusicCD3.Tag.ToString(), "C");
        }

        private void lblKitap1_Click(object sender, EventArgs e)
        {
            uruneGit(picKitap1.Tag.ToString(), "B");
        }

        private void lblKitap2_Click(object sender, EventArgs e)
        {
            uruneGit(picKitap2.Tag.ToString(), "B");
        }

        private void lblKitap3_Click(object sender, EventArgs e)
        {
            uruneGit(picKitap3.Tag.ToString(), "B");
        }

        private void lblMagazine1_Click(object sender, EventArgs e)
        {
            uruneGit(picMagazine1.Tag.ToString(), "M");
        }

        private void lblMagazine2_Click(object sender, EventArgs e)
        {
            uruneGit(picMagazine2.Tag.ToString(), "M");
        }

        private void lblMagazine3_Click(object sender, EventArgs e)
        {
            uruneGit(picMagazine3.Tag.ToString(), "M");
        }

        private void lblMusicCD1_Click(object sender, EventArgs e)
        {
            uruneGit(picMusicCD1.Tag.ToString(), "C");
        }

        private void lblMusicCD2_Click(object sender, EventArgs e)
        {
            uruneGit(picMusicCD2.Tag.ToString(), "C");
        }

        private void lblMusicCD3_Click(object sender, EventArgs e)
        {
            uruneGit(picMusicCD3.Tag.ToString(), "C");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 2)
            {
                bool res = false;
                for (int i = 0; i < dall.Tables.Count; i++)
                    for (int j = 0; j < dall.Tables[i].Rows.Count; j++)
                    {
                        if (dall.Tables[i].Rows[j].ItemArray[1].ToString() == txtSearch.Text || dall.Tables[i].Rows[j].ItemArray[3].ToString() == txtSearch.Text)
                        {
                            res = true;
                            uruneGit(dall.Tables[i].Rows[j].ItemArray[0].ToString(), dall.Tables[i].Rows[j].ItemArray[6].ToString());
                        }
                    }

                if (res == false)
                {
                    MessageBox.Show("Aradığınız ürün stoklarımızda bulunmamaktadır." + Environment.NewLine + "Lütfen yeni bir arama gerçekleştiriniz.",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
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
                btnAra_Click(sender,e);
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
                if(logout == DialogResult.Yes)
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

        private void frmHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
