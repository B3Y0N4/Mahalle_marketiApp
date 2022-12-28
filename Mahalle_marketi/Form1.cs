using FontAwesome.Sharp;
using Mahalle_marketi.UserControls;

namespace Mahalle_marketi
{
    public partial class Form1 : Form
    {
        
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        bool highlightSatisButton = true;
        public Form1()
        {
            InitializeComponent();
            UC_satis uc = new UC_satis();
            addUserControl(uc);
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,50);
            panelNavigation.Controls.Add(leftBorderBtn);

            if (highlightSatisButton)
            {
                btn_satis.ForeColor = Color.Orange;
                btn_satis.TextAlign = ContentAlignment.MiddleCenter;
                btn_satis.IconColor = Color.Orange;
                btn_satis.TextImageRelation = TextImageRelation.TextBeforeImage;
                btn_satis.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = Color.Orange;
                leftBorderBtn.Location = new Point(0, btn_satis.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                highlightSatisButton = false;
            }
            


        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

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
            if (!highlightSatisButton)
            {
                btn_satis.ForeColor = Color.Green;
                btn_satis.TextAlign = ContentAlignment.MiddleLeft;
                btn_satis.IconColor = Color.FromArgb(128, 252, 76);
                btn_satis.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn_satis.ImageAlign = ContentAlignment.MiddleLeft;
            }
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
            UC_Stok uc = new UC_Stok();
            addUserControl(uc);
            ActivateButton(sender);
        }

        

        private void btn_satis_Click(object sender, EventArgs e)
        {
            UC_satis uc = new UC_satis();
            addUserControl(uc);
            ActivateButton(sender);
        }

        private void btn_borc_odeme_Click(object sender, EventArgs e)
        {
            UC_borc_odeme uc = new UC_borc_odeme();
            addUserControl(uc);
            ActivateButton(sender);
        }

        private void btn_tedarikci_detaylari_Click(object sender, EventArgs e)
        {
            UC_tedarikci_detaylari uc = new UC_tedarikci_detaylari();
            addUserControl(uc);
            ActivateButton(sender);
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
        }

        private void btn_kayitlar_Click(object sender, EventArgs e)
        {
            UC_kayitlar uc = new UC_kayitlar();
            addUserControl(uc);
            ActivateButton(sender);
        }
    }
}