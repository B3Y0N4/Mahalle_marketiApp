using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahalle_marketi
{
    public partial class MusteriBorcuSilFormu : Form
    {
        public MusteriBorcuSilFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text))
            {
                int Number;
                if (int.TryParse(textBox3.Text, out Number))
                {
                    String musteriAdi= textBox1.Text;
                    String musteriSoyAdi = textBox2.Text;
                    int odenen = Int32.Parse(textBox3.Text);
                    try
                    {
                        using (Model1 db = new Model1())
                        {
                            var result = db.müsteri.SingleOrDefault(b => b.mAdi == musteriAdi && b.mSoyadi == musteriSoyAdi);
                            if (result != null)
                            {
                                result.mBorcu = result.mBorcu - odenen;
                                db.SaveChanges();
                                MessageBox.Show("Girilen miktar borçtan silindi.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Müşteri adı yada/ve soyadı hatalı, tekrar deneyiniz.");
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu, tekrar deneyiniz. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Ödenen tutar field must be a number");
                }




            }
            else
            {
                MessageBox.Show("All fields are requiered");
                return;
            }
        }
    }
}
