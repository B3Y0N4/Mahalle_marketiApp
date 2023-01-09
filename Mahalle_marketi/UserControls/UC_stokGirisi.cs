using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using ClassLibrary3;

namespace Mahalle_marketi.UserControls
{
    public partial class UC_stokGirisi : UserControl
    {
        public UC_stokGirisi()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            

            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                String path = textBox1.Text;
                String firmaAdi = File.ReadLines(path).Skip(0).Take(1).First().Split(" ").ToList()[2];
                int irsaliyeNo = Int16.Parse(File.ReadLines(path).Skip(1).Take(1).First().Split(" ").ToList()[2]);
                String üAdi = File.ReadLines(path).Skip(2).Take(1).First().Split(" ").ToList()[2];
                int üKodu = Int16.Parse(File.ReadLines(path).Skip(3).Take(1).First().Split(" ").ToList()[2]);
                int übarkodu = Int16.Parse(File.ReadLines(path).Skip(4).Take(1).First().Split(" ").ToList()[2]);
                String ümiktarTüru = File.ReadLines(path).Skip(5).Take(1).First().Split(" ").ToList()[2];
                int ümiktari = Int16.Parse(File.ReadLines(path).Skip(6).Take(1).First().Split(" ").ToList()[1]);
                int übirimfiyati = Int16.Parse(File.ReadLines(path).Skip(7).Take(1).First().Split(" ").ToList()[2]);
                int marketinBorcu = ümiktari * übirimfiyati;
                DateTime tarih = DateTime.Now;
                String iTarihi = tarih.ToString("MMMM dd yyyy hh:mm:ss tt");

                using (Model1 context = new Model1())
                {
                    if (context.ürün.Any(o => o.ükodu == üKodu))
                    {
                        MessageBox.Show("Dosya stoğa daha önce işlendi");
                        return;
                    }
                    {
                        ürün urun = new ürün();
                        urun.üAdi = üAdi;
                        urun.ükodu = üKodu;
                        urun.übarkodu = übarkodu;
                        urun.ümiktarTüru = ümiktarTüru;
                        urun.ümiktari = ümiktari;
                        urun.übirimfiyati = übirimfiyati;
                        context.ürün.Add(urun);
                        context.SaveChanges();
                        MessageBox.Show("Stoğa yeni ürün eklendi");

                    }


                }
                using (Model1 context = new Model1())
                {
                    if (context.tedarekcis.Any(o => o.firmaAdi == firmaAdi && o.iTarihi == iTarihi && o.marketinBorcu == marketinBorcu))
                    {
                        MessageBox.Show("Bu tedarikçi firmaya borcunuz daha önce kaydedildi");
                        return;
                    }
                    var result = context.tedarekcis.SingleOrDefault(b => b.firmaAdi == firmaAdi);
                    if (result != null)
                    {
                        result.marketinBorcu = result.marketinBorcu + marketinBorcu;
                        //result.iTarihi = iTarihi;
                        context.SaveChanges();
                        MessageBox.Show("Bir tedarikçiye yeni borcunuz oluştu");
                    }
                    else
                    {
                        tedarekci td = new tedarekci();
                        td.firmaAdi = firmaAdi;
                        td.marketinBorcu = marketinBorcu;
                        td.iTarihi = iTarihi;
                        context.SaveChanges();
                        MessageBox.Show("Bir tedarikçiye yeni borcunuz oluştu");
                    }
                        

                    


                }
            }
            else
            {
                MessageBox.Show("Bir dosya secilmedi");
                return;
            }
            
               
            

            
            //String query = "INSERT INTO dbo.ürün (üAdi, ükodu, übarkodu, ümiktarTüru, ümiktari, übirimfiyati) VALUES (@üAdi, @ükodu, @übarkodu, @ümiktarTüru, @ümiktari, @übirimfiyati)";
            //DbStok.stoga_girdi_ekle(query, üAdi, üKodu, übarkodu, ümiktarTüru, ümiktari, übirimfiyati);

            //String query1 = "INSERT INTO dbo.tedarekci (firmaAdi, marketinBorcu, iTarihi) VALUES (@firmaAdi, @marketinBorcu, @iTarihi)";
            //DbTedarikci.firmaya_borc_ekle(query1, firmaAdi, marketinBorcu, iTarihi );

           

            //try
            //{
            //    Model1 context1 = new Model1();
            //    tedarekci td = new tedarekci
            //    {
            //        firmaAdi = firmaAdi,
            //        marketinBorcu = marketinBorcu,
            //        iTarihi = iTarihi,
            //    };
            //    context1.tedarekcis.Add(td);
            //    context1.SaveChanges();
            //    MessageBox.Show("Bir tedarikçiye yeni borç oluştu");
            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show("Bir hata oluştu \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Dosya seç";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("Bir dosya secilmedi");
                return;
            }
        }
    }
}
