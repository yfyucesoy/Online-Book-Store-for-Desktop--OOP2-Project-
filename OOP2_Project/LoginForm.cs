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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP2_Project
{
/**
* \brief This form provides to design of homepage interface
* This form shows the login screen.
*/
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            EventLogger.AttachButton(this.Controls);
        }

        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        DataSet dall;
        SqlCommand cmd;
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text != "Kullanıcı Adı Giriniz" || txtUsername.Text != "Şifre")
            {
                picLoad.Visible = true;
                con = new SqlConnection("Data Source=DESKTOP-ECU28KQ\\SQLEXPRESS;Initial Catalog=OOP2;Integrated Security=True");
                da = new SqlDataAdapter("Select * From Users Where username='" + txtUsername.Text.Trim() + "' and password='" + txtPassword.Text.Trim() + "'", con);
                dt = new DataTable();
                try
                {
                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Hatalı kullanıcı adı ya da şifre girdiniz!", "Hata",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        picLoad.Visible = false;
                    }
                    else
                    {
                        myLogin login = myLogin.CreateLogin();
                        login.Kadi = txtUsername.Text.Trim();
                        login.Sifre = txtPassword.Text.Trim();
                        login.Cart.CustomerID = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                        MessageBox.Show("Merhaba " + dt.Rows[0].ItemArray[1].ToString() + ";" + Environment.NewLine + "Online Book Store'a hoşgeldin!", "Hoşgeldiniz",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        picLoad.Visible = false;
                        this.Close();

                        con.Open();
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
                        cmd = new SqlCommand("Select * From Cart Where CustomerID = '" + login.Cart.CustomerID + "'", con);
                        da.SelectCommand = cmd;
                        cmd.ExecuteNonQuery();
                        da.Fill(dt);
                        if (dt.Rows[0].ItemArray[1].ToString() != "")
                        {
                            string[] products = dt.Rows[0].ItemArray[1].ToString().Split(';');
                            string[] quantities = dt.Rows[0].ItemArray[2].ToString().Split(';');
                            string[] ptype = dt.Rows[0].ItemArray[3].ToString().Split(';');
                            Product prd = null;

                            for (int i = 0; i < products.Length; i++)
                            {
                                if (ptype[i].ToString() == "B")
                                {
                                    for (int j = 0; j < dall.Tables["Book"].Rows.Count; j++)
                                    {
                                        if (dall.Tables["Book"].Rows[j].ItemArray[0].ToString() == products[i])
                                        {
                                            prd = new Book((int)(dall.Tables["Book"].Rows[j].ItemArray[0]), dall.Tables["Book"].Rows[j].ItemArray[1].ToString(), float.Parse(dall.Tables["Book"].Rows[j].ItemArray[2].ToString()), dall.Tables["Book"].Rows[j].ItemArray[3].ToString(), dall.Tables["Book"].Rows[j].ItemArray[4].ToString(), int.Parse(dall.Tables["Book"].Rows[j].ItemArray[5].ToString()));
                                            prd.Image = dall.Tables["Book"].Rows[j].ItemArray[7].ToString();
                                        }
                                    }
                                }
                                else if (ptype[i].ToString() == "M")
                                {
                                    for (int k = 0; k < dall.Tables["Magazine"].Rows.Count; k++)
                                    {
                                        if (dall.Tables["Magazine"].Rows[k].ItemArray[0].ToString() == products[i])
                                        {
                                            prd = new Magazine((int)(dall.Tables["Magazine"].Rows[k].ItemArray[0]), dall.Tables["Magazine"].Rows[k].ItemArray[1].ToString(), float.Parse(dall.Tables["Magazine"].Rows[k].ItemArray[2].ToString()), int.Parse(dall.Tables["Magazine"].Rows[k].ItemArray[3].ToString()), dall.Tables["Magazine"].Rows[k].ItemArray[4].ToString());
                                            prd.Image = dall.Tables["Magazine"].Rows[k].ItemArray[5].ToString();
                                        }
                                    }
                                }
                                else if (ptype[i].ToString() == "C")
                                {
                                    for (int l = 0; l < dall.Tables["MusicCD"].Rows.Count; l++)
                                    {
                                        if (dall.Tables["MusicCD"].Rows[l].ItemArray[0].ToString() == products[i])
                                        {
                                            prd = new MusicCD((int)(dall.Tables["MusicCD"].Rows[l].ItemArray[0]), dall.Tables["MusicCD"].Rows[l].ItemArray[1].ToString(), float.Parse(dall.Tables["MusicCD"].Rows[l].ItemArray[2].ToString()), dall.Tables["MusicCD"].Rows[l].ItemArray[3].ToString(), dall.Tables["MusicCD"].Rows[l].ItemArray[4].ToString());
                                            prd.Image = dall.Tables["MusicCD"].Rows[l].ItemArray[5].ToString();
                                        }
                                    }
                                }
                                ItemToPurchase item = new ItemToPurchase(prd, int.Parse(quantities[i]));
                                login.Cart.addProduct(item);
                            }
                            con.Close();
                        }
                    }
                }
                catch(Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı bilgilerinizi giriniz!", "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lbluyelik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister rgsFrm = new frmRegister();
            rgsFrm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Kullanıcı Adı Giriniz";
            txtPassword.Text = "şifre";
            this.ActiveControl = btnGiris;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Kullanıcı Adı Giriniz")
            {
                txtUsername.ForeColor = Color.Black;
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Kullanıcı Adı Giriniz";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "şifre")
            {
                txtPassword.ForeColor = Color.Black;
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "şifre";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmHomePage frm = new frmHomePage();
            frm.Show();
        }

        private void picLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
