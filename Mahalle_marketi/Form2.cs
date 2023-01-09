using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary3;
using Google.Protobuf.WellKnownTypes;

namespace Mahalle_marketi
{
    public partial class Firmanin_borcu_kapat : Form
    {
        public Firmanin_borcu_kapat()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            
            //String query1 = "UPDATE dbo.tedarekci SET marketinBorcu = (marketinBorcu - @odenecek) WHERE  firmaAdi = @firmaAdi";
            //DbTedarikci.borcu_kapat(query1, firmaAdi, odenecek);
            //this.Close();
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                int Number;
                if (int.TryParse(textBox2.Text, out Number))
                {
                    String firmaAdi = textBox1.Text;
                    int odenecek = Int32.Parse(textBox2.Text);
                    try
                    {
                        using (Model1 db = new Model1())
                        {
                            var result = db.tedarekci.SingleOrDefault(b => b.firmaAdi == firmaAdi);
                            if (result != null)
                            {
                                result.marketinBorcu = result.marketinBorcu - odenecek;
                                db.SaveChanges();
                                MessageBox.Show("Girilen miktar ödendi.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Firma adı hatalı, tekrar deneyiniz.");
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu, tekrar deneyiniz. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Ödenecek tutar field must be a number");
                }
                
                
                

            }
            else
            {
                MessageBox.Show("All fields are requiered");
                return;
            }

            //if (Int32.Parse(textBox2.Text).Equals(typeof(int)))
            //{
            //    MessageBox.Show("Ödenen field must be a number");
            //}


        }



    }
}
