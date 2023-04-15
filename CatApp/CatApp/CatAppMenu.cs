using CatApp.Classes;
using System.Drawing.Design;
using System.Security.Cryptography;

namespace CatApp
{
    public partial class CatAppMenu : Form
    {
        private Button currentButton;
        private Color activeColor = ColorTranslator.FromHtml("#F1AAE4");
        private Form activeForm;

        public CatAppMenu()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1330, 825);

        }


        private void OpenChildForms(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            CurrentButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildForms.Controls.Add(childForm);
            this.panelChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }

        private void CurrentButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = activeColor;
                    currentButton.ForeColor = Color.White;

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(245, 198, 236);
                    previousBtn.ForeColor = Color.Black;
                }
            }
        }

        private void btnFindCat_Click(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1500, 900);
            OpenChildForms(new Forms.CatBreedsForm(), sender);

        }

        private void btnFunnyCats_Click(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1000, 900);
            OpenChildForms(new Forms.FunnyCatsForm(), sender);
            
        }

        private void btnCatFacts_Click(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1280, 830);
            OpenChildForms(new Forms.CatFactsForm(), sender);

        }

        private void btnCatList_Click(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(900, 900);
            OpenChildForms(new Forms.CatListForm(), sender);

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}