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

namespace Mahalle_marketi.UserControls
{
    public partial class UC_tedarikci_detaylari : UserControl
    {
        public UC_tedarikci_detaylari()
        {
            InitializeComponent();
        }

        private void UC_tedarikci_detaylari_Load(object sender, EventArgs e)
        {
            //String query = "Select * From tedarekci";
            //DbTedarikci.display_tedarikci_borclari(query, dataGridView1);
            Model1 model1 = new Model1();
            dataGridView1.DataSource = model1.tedarekci.ToList();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
             Firmanin_borcu_kapat form2 = new Firmanin_borcu_kapat();
             form2.Show();
        }
    }
}
