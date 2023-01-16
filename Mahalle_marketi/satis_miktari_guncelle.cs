using Mahalle_marketi.UserControls;
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
    public partial class satis_miktari_guncelle : Form
    {
        public int index;
        public int guncellenen_miktar;
        public satis_miktari_guncelle()
        {
            InitializeComponent();
            
        }

        
        

        private void satis_miktari_guncelle_Load(object sender, EventArgs e)
        {
            ComboBoxMiktar.SelectedIndex = index;
            guncellenen_miktar = index + 1;

        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            guncellenen_miktar = 0;
            guncellenen_miktar = Int32.Parse(ComboBoxMiktar.Text.Trim());

            this.Close();
        }
    }
}
