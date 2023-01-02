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
    public partial class UC_kayitlar : UserControl
    {
        public UC_kayitlar()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_kayitlar.Controls.Clear();
            panel_kayitlar.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void btn_satisGecmisi_Click(object sender, EventArgs e)
        {
            UC_satisKayitlari uc = new UC_satisKayitlari();
            addUserControl(uc);
        }

        private void btn_stok_girisi_Click(object sender, EventArgs e)
        {
            UC_urunKayitlari uc = new UC_urunKayitlari();
            addUserControl(uc);
        }

        private void UC_kayitlar_Load(object sender, EventArgs e)
        {
            UC_satisKayitlari uc = new UC_satisKayitlari();
            addUserControl(uc);
        }
    }
    
}
