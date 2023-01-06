using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Mahalle_marketi.UserControls;

namespace Mahalle_marketi
{
    public partial class Giris_sayfasi : Form
    {
        public static Dictionary<String, String> kullanici_bilgileri;
        public String kullanici_adi;
        public String kullanici_sifresi;
        public String ana;

        Thread th;
        bool auth_mode_giris_yapmak;
        public Giris_sayfasi()
        {
            InitializeComponent();
        }

        private void btn_toggle_mode_Click(object sender, EventArgs e)
        {
            auth_mode_giris_yapmak = !auth_mode_giris_yapmak;
            if (auth_mode_giris_yapmak)
            {
                panel_sifreyi_tekrarla.Visible = false;
                TextBox_SifreyiTekrarla.Text = "";
                btn_giris_hesap_olustur.Text = "Giriş Yapın";
                btn_toggle_mode.Text = "Yeni Hesap Oluşturun";
                
            }
            else
            {
                panel_sifreyi_tekrarla.Visible = true;
                btn_giris_hesap_olustur.Text = "Yeni Hesap Oluşturun";
                btn_toggle_mode.Text = "Giriş Yapın";
            }
        }

        private void Giris_sayfasi_Load(object sender, EventArgs e)
        {
            auth_mode_giris_yapmak = true;
            panel_sifreyi_tekrarla.Visible = false;
            btn_giris_hesap_olustur.Text = "Giriş Yapın";
            btn_toggle_mode.Text = "Yeni Hesap Oluşturun";
        }

        private void btn_giris_hesap_olustur_Click(object sender, EventArgs e)
        {
            if (auth_mode_giris_yapmak)
            {
                if (TextBox_kullaniciAdi.Text.Trim() == "" && TextBox_sifre.Text.Trim() == "")
                {
                    MessageBox.Show("Kullanıcı bilgilerinizi giriniz", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TextBox_kullaniciAdi.Text.Trim() == "")
                {
                    MessageBox.Show("Kullanıcı Adınızı giriniz", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TextBox_sifre.Text.Trim() == "")
                {
                    MessageBox.Show("Şifrenizi giriniz", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TextBox_sifre.Text.Trim().Length < 6 || TextBox_sifre.Text.Trim().Length > 20)
                {
                    MessageBox.Show("Şifreniz en az 6, en fazla 20 karakterden oluşmalıdır", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    kullanici_bilgileri = Db_kullanicilar.get_kullanici_bilgileri("select * from kullanıcılar where kullanıcıAdı = @kullanici_adi", TextBox_kullaniciAdi.Text.Trim());
                }
                catch
                {
                    return;
                }

                if (kullanici_bilgileri.Keys.Count != 0)
                {
                    if (TextBox_sifre.Text.Trim() != kullanici_bilgileri["kullanici sifresi"])
                    {
                        MessageBox.Show("Şifreniz Yanlış. Tekrar deneyiniz", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    kullanici.kullanici_adi = kullanici_bilgileri["kullanici adi"];
                    kullanici.kullanici_sifresi = kullanici_bilgileri["kullanici sifresi"];

                    this.Close();
                    th = new Thread(openNewForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adınız bizim sistemizde kayıtlı değil\n" + "Giriş yapabilmeniz için yeni hesap oluşturunuz", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (TextBox_kullaniciAdi.Text.Trim() == "" && TextBox_sifre.Text.Trim() == "")
                {
                    MessageBox.Show("Kullanıcı bilgilerinizi giriniz", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TextBox_kullaniciAdi.Text.Trim() == "")
                {
                    MessageBox.Show("Kullanıcı Adınızı giriniz", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TextBox_sifre.Text.Trim() == "")
                {
                    MessageBox.Show("Şifrenizi giriniz", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TextBox_sifre.Text.Trim().Length < 6 || TextBox_sifre.Text.Trim().Length > 20)
                {
                    MessageBox.Show("Şifreniz en az 6, en fazla 20 karakterden oluşmalıdır", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TextBox_SifreyiTekrarla.Text.Trim() == "")
                {
                    MessageBox.Show("Şifreyi Tekrarla alanı boş bırakılmamalı", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TextBox_sifre.Text.Trim() != TextBox_SifreyiTekrarla.Text.Trim())
                {
                    MessageBox.Show("Şifre ve Şifreyi Tekrarla alanlarındaki şifre eşleşmiyor. Tekrar deneyiniz", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    kullanici_bilgileri = Db_kullanicilar.get_kullanici_bilgileri("select * from kullanıcılar where kullanıcıAdı = @kullanici_adi", TextBox_kullaniciAdi.Text.Trim());

                }
                catch
                {
                    return;
                }

                if (kullanici_bilgileri.Keys.Count == 0)
                {
                    string kullanici_adi = TextBox_kullaniciAdi.Text.Trim();
                    String kullanici_sifresi = TextBox_sifre.Text.Trim();
                    DateTime kaydolma_tarihi = DateTime.Now;
                    try
                    {
                        Db_kullanicilar.kullanici_ekle("insert into kullanıcılar (kullanıcıAdı, kullanıcıŞifresi, kaydolmaTarihi) values (@kullanici_adi, @kullanici_sifresi, @kaydolma_tarihi)", kullanici_adi, kullanici_sifresi, kaydolma_tarihi);
                    }
                    catch
                    {
                        return;
                    }

                    auth_mode_giris_yapmak = !auth_mode_giris_yapmak;
                    panel_sifreyi_tekrarla.Visible = false;
                    TextBox_SifreyiTekrarla.Text = "";
                    btn_giris_hesap_olustur.Text = "Giriş Yapın";
                    btn_toggle_mode.Text = "Yeni Hesap Oluşturun";




                }
                else
                {
                    MessageBox.Show("Girdiğiniz kullanıcı adı başka bir hesaba aittir \n" + "Lütfen başka bir kullanıcı adını giriniz", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void openNewForm(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
