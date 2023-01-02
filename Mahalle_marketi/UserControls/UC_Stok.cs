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
    public partial class UC_Stok : UserControl
    {
        public UC_Stok()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_stok.Controls.Clear();
            panel_stok.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void btn_urunler_Click(object sender, EventArgs e)
        {
            UC_urunler uc = new UC_urunler();
            addUserControl(uc);
        }

        private void btn_stok_girisi_Click(object sender, EventArgs e)
        {
            UC_stokGirisi uc = new UC_stokGirisi();
            addUserControl(uc);
        }

        private void UC_Stok_Load(object sender, EventArgs e)
        {
            UC_urunler uc = new UC_urunler();
            addUserControl(uc);
        }
    }
}
