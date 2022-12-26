namespace Mahalle_marketi
{
    public partial class Form1 : Form
    {
        private Boolean showPanelStok = false;
        public Form1()
        {
            InitializeComponent();
            tooglePanels();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showPanelStok = false;
            tooglePanels();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_stok_Click(object sender, EventArgs e)
        {
            showPanelStok = !showPanelStok;
            tooglePanels();
        }

        private void tooglePanels()
        {
            if (showPanelStok)
            {
                panel_stok.Height = 80;
            }
            else
            {
                panel_stok.Height = 0;
            }
        }

        private void Btn_satis_Click(object sender, EventArgs e)
        {
            showPanelStok = false;
            tooglePanels();
        }

        private void btn_borc_odeme_Click(object sender, EventArgs e)
        {
            showPanelStok = false;
            tooglePanels();
        }
    }
}