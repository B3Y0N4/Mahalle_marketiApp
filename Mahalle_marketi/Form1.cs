using FontAwesome.Sharp;
namespace Mahalle_marketi
{
    public partial class Form1 : Form
    {
        private Boolean showPanelStok = false;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form1()
        {
            InitializeComponent();
            togglePanels();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,35);
            panelNavigation.Controls.Add(leftBorderBtn);


        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = Color.Orange;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Orange;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = Color.Orange;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.Green;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(128, 252, 76);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btn_stok_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
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
            ActivateButton(sender);
            showPanelStok = false;
            togglePanels();
        }

        private void btn_borc_odeme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPanelStok = false;
            togglePanels();
        }

        private void btn_tedarikci_detaylari_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
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