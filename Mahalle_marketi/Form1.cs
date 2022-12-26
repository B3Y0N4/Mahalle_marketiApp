namespace Mahalle_marketi
{
    public partial class Form1 : Form
    {
        private Boolean showPanelStok = false;
        public Form1()
        {
            InitializeComponent();
            togglePanels();

        }

        private void btn_stok_Click(object sender, EventArgs e)
        {
            showPanelStok = !showPanelStok;
            togglePanels();
        }

        private void togglePanels()
        {
            if (showPanelStok)
            {
                panelStok.Height = 80;
            }
            else
            {
                panelStok.Height = 0;
            }
        }

        private void btn_satis_Click(object sender, EventArgs e)
        {
            showPanelStok = false;
            togglePanels();
        }

        private void btn_borc_odeme_Click(object sender, EventArgs e)
        {
            showPanelStok = false;
            togglePanels();
        }

        private void btn_tedarikci_detaylari_Click(object sender, EventArgs e)
        {
            showPanelStok = false;
            togglePanels();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            showPanelStok = false;
            togglePanels();
        }
    }
}