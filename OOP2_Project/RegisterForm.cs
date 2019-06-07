/**
 * @File RegisterForm.cs
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

namespace OOP2_Project
{
/**
* \brief This form provides to design of homepage interface
* This form provides registration of new user
*/
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            EventLogger.AttachButton(this.Controls);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnKayit;
            txtKullanıcıAdı.Text = "Kullanıcı Adı";
            txtSifre.Text = "Şifre";
            txtEmail.Text = "Email";
            txtAdSoyad.Text = "Ad ve Soyad";
            txtAdres.Text = "Adres";
        }

        private void txtKadi_Enter(object sender, EventArgs e)
        {
            if (txtKullanıcıAdı.Text=="Kullanıcı Adı")
            {
                txtKullanıcıAdı.ForeColor = Color.Black;
                txtKullanıcıAdı.Text = "";
            }
        }

        private void txtKadi_Leave(object sender, EventArgs e)
        {
            if (txtKullanıcıAdı.Text=="")
            {
                txtKullanıcıAdı.Text = "Kullanıcı Adı";
                txtKullanıcıAdı.ForeColor = Color.Gray;
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.ForeColor = Color.Black;
                txtSifre.Text = "";
            }
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Şifre";
                txtSifre.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.ForeColor = Color.Black;
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtAdsoyad_Enter(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "Ad ve Soyad")
            {
                txtAdSoyad.ForeColor = Color.Black;
                txtAdSoyad.Text = "";
            }
        }

        private void txtAdsoyad_Leave(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "")
            {
                txtAdSoyad.Text = "Ad ve Soyad";
                txtAdSoyad.ForeColor = Color.Gray;
            }
        }

        private void txtAdres_Enter(object sender, EventArgs e)
        {
            if (txtAdres.Text == "Adres")
            {
                txtAdres.ForeColor = Color.Black;
                txtAdres.Text = "";
            }
        }

        private void txtAdres_Leave(object sender, EventArgs e)
        {
            if (txtAdres.Text == "")
            {
                txtAdres.Text = "Adres";
                txtAdres.ForeColor = Color.Gray;
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmHomePage frm = new frmHomePage();
            frm.Show();
        }
        Customer newcustomer = new Customer();
        private void btnKayit_Click(object sender, EventArgs e)
        {
            bool res = false;
            string message = "";
            if (txtKullanıcıAdı.Text.ToString().Trim() == "Kullanıcı Adı" || txtKullanıcıAdı.Text.ToString().Trim().Length < 6)
            {
                message += "Kullanıcı Adı" + Environment.NewLine;
                res = true;
            }
            if (txtEmail.Text.ToString().Trim() == "Email" || txtEmail.Text.ToString().Trim().Length < 6)
            {
                message += "Email Adresi" + Environment.NewLine;
                res = true;
            }
            if (txtAdres.Text.ToString().Trim() == "Adres"  || txtAdres.Text.ToString().Trim().Length < 6)
            {
                message += "Adres" + Environment.NewLine;
                res = true;
            }
            if (txtSifre.Text.ToString().Trim() ==  "Şifre" || txtSifre.Text.ToString().Trim().Length < 6)
            {
                message += "Şifre" + Environment.NewLine;
                res = true;
            }
            if (txtAdSoyad.Text.ToString().Trim() == "Ad ve Soyad" || txtAdSoyad.Text.ToString().Trim().Length < 6)
            {
                message += "Ad Soyad" + Environment.NewLine;
                res = true;
            }
            if (res == false)
            {
                try
                {
                    newcustomer.Username = txtKullanıcıAdı.Text.ToString().Trim();
                    newcustomer.Email = txtEmail.Text.ToString().Trim();
                    newcustomer.Address = txtAdres.Text.ToString().Trim();
                    newcustomer.Password = txtSifre.Text.ToString().Trim();
                    newcustomer.Name = txtAdSoyad.Text.ToString().Trim();
                    string baglanti = "Data Source = DESKTOP-ECU28KQ\\SQLEXPRESS; Integrated Security = True; database = OOP2";
                    SqlConnection con = new SqlConnection(baglanti);
                    SqlConnection con2 = new SqlConnection(baglanti);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select * From Users Where username='" + newcustomer.Username + "'", con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Aynı isimli kullanıcı mevcut. Lütfen başka bir kullanıcı adı deneyiniz.", "Uyarı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            con2.Open();
                            string ekleme_komutu = "insert into users(name,address,email,username,password) values (@name,@adress,@email,@username,@password)";
                            SqlCommand ekleme = new SqlCommand(ekleme_komutu, con2);
                            ekleme.Parameters.AddWithValue("@name", newcustomer.Name);
                            ekleme.Parameters.AddWithValue("@adress", newcustomer.Address);
                            ekleme.Parameters.AddWithValue("@email", newcustomer.Email);
                            ekleme.Parameters.AddWithValue("@username", newcustomer.Username);
                            ekleme.Parameters.AddWithValue("@password", newcustomer.Password);
                            ekleme.ExecuteNonQuery();

                            SqlDataAdapter da = new SqlDataAdapter("Select ID From dbo.Users Where Users.username = '" + newcustomer.Username + "'", con2);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            string ekleme2_komutu = "insert into Cart(CustomerID) values (@CustomerID)";
                            SqlCommand ekleme2 = new SqlCommand(ekleme2_komutu, con2);
                            ekleme2.Parameters.AddWithValue("@CustomerID", dt.Rows[0].ItemArray[0].ToString());
                            ekleme2.ExecuteNonQuery();

                            MessageBox.Show("Kaydınız başarı ile oluşturuldu." + Environment.NewLine + "İyi alışverişler dileriz.", "Online Book Store'a hoşgeldiniz",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
                            this.Close();
                        }
                        con.Close();
                        con2.Close();
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show(message + Environment.NewLine + "Yukarıdaki alanlar en az 6 karakterden oluşmalıdır.",
                    "Kayıt Yapılamadı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
          
        }

        private void picKayıt_Click(object sender, EventArgs e)
        {

        }
    }
}
