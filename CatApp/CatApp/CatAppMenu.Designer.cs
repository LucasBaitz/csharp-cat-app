namespace CatApp
{
    partial class CatAppMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatAppMenu));
            panelMenu = new Panel();
            btnCatList = new Button();
            btnCatFacts = new Button();
            btnFunnyCats = new Button();
            btnFindCat = new Button();
            panelLogo = new Panel();
            panelTitle = new Panel();
            lblTitle = new Label();
            panelChildForms = new Panel();
            panelMenu.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(245, 198, 236);
            panelMenu.Controls.Add(btnCatList);
            panelMenu.Controls.Add(btnCatFacts);
            panelMenu.Controls.Add(btnFunnyCats);
            panelMenu.Controls.Add(btnFindCat);
            panelMenu.Controls.Add(panelLogo);
            resources.ApplyResources(panelMenu, "panelMenu");
            panelMenu.Name = "panelMenu";
            // 
            // btnCatList
            // 
            btnCatList.BackColor = Color.FromArgb(245, 198, 236);
            resources.ApplyResources(btnCatList, "btnCatList");
            btnCatList.FlatAppearance.BorderSize = 0;
            btnCatList.ForeColor = Color.Black;
            btnCatList.Image = Properties.Resources.catlistIcon;
            btnCatList.Name = "btnCatList";
            btnCatList.UseVisualStyleBackColor = false;
            btnCatList.Click += btnCatList_Click;
            // 
            // btnCatFacts
            // 
            resources.ApplyResources(btnCatFacts, "btnCatFacts");
            btnCatFacts.FlatAppearance.BorderSize = 0;
            btnCatFacts.ForeColor = Color.Black;
            btnCatFacts.Image = Properties.Resources.catfactsIcon;
            btnCatFacts.Name = "btnCatFacts";
            btnCatFacts.UseVisualStyleBackColor = true;
            btnCatFacts.Click += btnCatFacts_Click;
            // 
            // btnFunnyCats
            // 
            resources.ApplyResources(btnFunnyCats, "btnFunnyCats");
            btnFunnyCats.FlatAppearance.BorderSize = 0;
            btnFunnyCats.ForeColor = Color.Black;
            btnFunnyCats.Image = Properties.Resources.funnycatIcon;
            btnFunnyCats.Name = "btnFunnyCats";
            btnFunnyCats.UseVisualStyleBackColor = true;
            btnFunnyCats.Click += btnFunnyCats_Click;
            // 
            // btnFindCat
            // 
            resources.ApplyResources(btnFindCat, "btnFindCat");
            btnFindCat.FlatAppearance.BorderSize = 0;
            btnFindCat.ForeColor = Color.Black;
            btnFindCat.Name = "btnFindCat";
            btnFindCat.UseVisualStyleBackColor = true;
            btnFindCat.Click += btnFindCat_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(255, 234, 234);
            resources.ApplyResources(panelLogo, "panelLogo");
            panelLogo.Name = "panelLogo";
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(255, 243, 226);
            panelTitle.Controls.Add(lblTitle);
            resources.ApplyResources(panelTitle, "panelTitle");
            panelTitle.ForeColor = Color.White;
            panelTitle.Name = "panelTitle";
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(179, 0, 94);
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.ForeColor = Color.White;
            lblTitle.Name = "lblTitle";
            lblTitle.Click += lblTitle_Click;
            // 
            // panelChildForms
            // 
            panelChildForms.BackColor = Color.FromArgb(249, 226, 175);
            panelChildForms.BackgroundImage = Properties.Resources.CatAPP;
            resources.ApplyResources(panelChildForms, "panelChildForms");
            panelChildForms.Name = "panelChildForms";
            // 
            // CatAppMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 202, 79);
            Controls.Add(panelChildForms);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            DoubleBuffered = true;
            Name = "CatAppMenu";
            panelMenu.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnFindCat;
        private Button btnCatList;
        private Button btnCatFacts;
        private Button btnFunnyCats;
        private Panel panelTitle;
        private Label lblTitle;
        private Panel panelChildForms;
    }
}