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

namespace Mahalle_marketi.UserControls
{
    public partial class UC_urunler : UserControl
    {
        public UC_urunler()
        {
            InitializeComponent();
        }

        private void UC_urunler_Load(object sender, EventArgs e)
        {
            //String query = "Select * From ürün";
            //DbStok.display_urun(query, dataGridView1);
            
              Model1 model = new Model1();
              dataGridView1.DataSource = model.ürün.ToList();
            
            

        }

    }
}
