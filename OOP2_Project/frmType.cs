/**
 * @File frmType.cs
 * @Date April, 2019
 * @Author Ali Fuat CALIK (farcry_32@hotmail.com)
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
* \brief This form provides to design of homepage interface
* This form shows the some of products which is same type products.
*/
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
            EventLogger.AttachButton(this.Controls);
        }
        myLogin login = myLogin.CreateLogin();
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds, dall;
        Product prd;
        Random rnd = new Random(DateTime.Now.Millisecond);
        public string PrdType;

        private void frmType_Load(object sender, EventArgs e)
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
            ArrayList arrLbl = new ArrayList() { lblType1, lblType2, lblType3, lblType4, lblType5, lblType6, lblType7, lblType8, lblType9 }; // labelleri tutmak için
            ArrayList arrPic = new ArrayList() { picType1, picType2, picType3, picType4, picType5, picType6, picType7, picType8, picType9 }; // resimleri tutmak için

            switch (PrdType)
            {
                case "B":
                    lblHead.Text = this.Text = "Top Books";
                    cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.Price, Book.Author, Book.Publisher, Book.Page, Prd.pType, Prd.Image From dbo.Book AS Book, dbo.Product AS Prd Where Book.ID = Prd.ID", con);
                    da.SelectCommand = cmd;
                    try
                    {
                        con.Open();
                        da.Fill(ds);
                        da.Fill(dall, "1");
                        con.Close();

                        int i, j = 0; // i random için, j döngü için
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
                    break;
                case "M":
                    lblHead.Text = this.Text = "Top Magazines";
                    cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.Price, Maga.Issue, Maga.Type, Prd.Image, Prd.pType From dbo.Magazine AS Maga, dbo.Product AS Prd Where Maga.ID = Prd.ID", con);
                    da.SelectCommand = cmd;
                    try
                    {
                        con.Open();
                        da.Fill(ds);
                        da.Fill(dall, "2");
                        con.Close();

                        int i, j = 0;
                        List<int> randContainer = new List<int>();

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
                    break;
                case "C":
                    lblHead.Text = this.Text = "Top Music CD's";
                    cmd = new SqlCommand("Select Prd.ID, Prd.Name, Prd.Price, Music.Singer, Music.Type, Prd.Image, Prd.pType From dbo.MusicCD AS Music, dbo.Product AS Prd Where Music.ID = Prd.ID", con);
                    da.SelectCommand = cmd;
                    try
                    {
                        con.Open();
                        da.Fill(ds);
                        da.Fill(dall, "3");
                        con.Close();

                        int i, j = 0;
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
                    break;
            }
            MyAggregate aggr = new MyAggregate();
            int k = 0;
            for (int i = 0; i < dall.Tables.Count; i++)
                for (int j = 0; j < dall.Tables[i].Rows.Count; j++)
                {
                    aggr[k++] = dall.Tables[i].Rows[j].ItemArray[1].ToString();
                    if ((dall.Tables[i].Rows[j].ItemArray[6].ToString() == "B") || (dall.Tables[i].Rows[j].ItemArray[6].ToString() == "C"))
                    {
                        aggr[k++] = dall.Tables[i].Rows[j].ItemArray[3].ToString();
                    }                        
                }
            IIterator iter = aggr.GetIterator();
            AutoCompleteStringCollection suggestStageName = new AutoCompleteStringCollection();
            for (string s = iter.FirstItem; iter.IsDone == false; s = iter.NextItem)
                suggestStageName.Add(s);
            txtSearch.AutoCompleteCustomSource = suggestStageName;
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void uruneGit(string pos, string pType)
        {
            frmProduct frmPrd = new frmProduct();
            frmPrd.Show();
            this.Hide();
            frmPrd.urunGetir(pos, pType);
        }

        private void picType1_Click(object sender, EventArgs e)
        {
            uruneGit(picType1.Tag.ToString(), PrdType);
        }

        private void picType2_Click(object sender, EventArgs e)
        {
            uruneGit(picType2.Tag.ToString(), PrdType);
        }

        private void picType3_Click(object sender, EventArgs e)
        {
            uruneGit(picType3.Tag.ToString(), PrdType);
        }

        private void picType4_Click(object sender, EventArgs e)
        {
            uruneGit(picType4.Tag.ToString(), PrdType);
        }

        private void picType5_Click(object sender, EventArgs e)
        {
            uruneGit(picType5.Tag.ToString(), PrdType);
        }

        private void picType6_Click(object sender, EventArgs e)
        {
            uruneGit(picType6.Tag.ToString(), PrdType);
        }

        private void picType7_Click(object sender, EventArgs e)
        {
            uruneGit(picType7.Tag.ToString(), PrdType);
        }

        private void picType8_Click(object sender, EventArgs e)
        {
            uruneGit(picType8.Tag.ToString(), PrdType);
        }

        private void picType9_Click(object sender, EventArgs e)
        {
            uruneGit(picType9.Tag.ToString(), PrdType);
        }

        private void lblType1_Click(object sender, EventArgs e)
        {
            uruneGit(picType1.Tag.ToString(), PrdType);
        }

        private void lblType2_Click(object sender, EventArgs e)
        {
            uruneGit(picType2.Tag.ToString(), PrdType);
        }

        private void lblType3_Click(object sender, EventArgs e)
        {
            uruneGit(picType3.Tag.ToString(), PrdType);
        }

        private void lblType4_Click(object sender, EventArgs e)
        {
            uruneGit(picType4.Tag.ToString(), PrdType);
        }

        private void lblType5_Click(object sender, EventArgs e)
        {
            uruneGit(picType5.Tag.ToString(), PrdType);
        }

        private void lblType6_Click(object sender, EventArgs e)
        {
            uruneGit(picType6.Tag.ToString(), PrdType);
        }

        private void lblType7_Click(object sender, EventArgs e)
        {
            uruneGit(picType7.Tag.ToString(), PrdType);
        }

        private void lblType8_Click(object sender, EventArgs e)
        {
            uruneGit(picType8.Tag.ToString(), PrdType);
        }

        private void lblType9_Click(object sender, EventArgs e)
        {
            uruneGit(picType9.Tag.ToString(), PrdType);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            frmHomePage frmHome = new frmHomePage();
            frmHome.Show();
            this.Hide();
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

        private void frmType_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tlpType5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void msMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAra_Click(sender, e);
            }
        }
    }
}
