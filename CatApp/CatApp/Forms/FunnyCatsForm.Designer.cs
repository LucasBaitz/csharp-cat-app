namespace CatApp.Forms
{
    partial class FunnyCatsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunnyCatsForm));
            btnNewCatImage = new Button();
            pictureBoxDisplayCats = new PictureBox();
            btnSaveCat = new Button();
            notifyIconSaveCat = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxDisplayCats).BeginInit();
            SuspendLayout();
            // 
            // btnNewCatImage
            // 
            btnNewCatImage.Anchor = AnchorStyles.None;
            btnNewCatImage.BackColor = Color.FromArgb(219, 181, 132);
            btnNewCatImage.BackgroundImageLayout = ImageLayout.None;
            btnNewCatImage.FlatAppearance.BorderSize = 0;
            btnNewCatImage.FlatStyle = FlatStyle.Flat;
            btnNewCatImage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewCatImage.Image = Properties.Resources.refreshCatIcon;
            btnNewCatImage.Location = new Point(486, 590);
            btnNewCatImage.Name = "btnNewCatImage";
            btnNewCatImage.Size = new Size(82, 79);
            btnNewCatImage.TabIndex = 0;
            btnNewCatImage.UseVisualStyleBackColor = false;
            btnNewCatImage.Click += btnNewCatImage_Click;
            // 
            // pictureBoxDisplayCats
            // 
            pictureBoxDisplayCats.Anchor = AnchorStyles.None;
            pictureBoxDisplayCats.Location = new Point(145, 25);
            pictureBoxDisplayCats.Name = "pictureBoxDisplayCats";
            pictureBoxDisplayCats.Size = new Size(836, 559);
            pictureBoxDisplayCats.TabIndex = 1;
            pictureBoxDisplayCats.TabStop = false;
            // 
            // btnSaveCat
            // 
            btnSaveCat.Anchor = AnchorStyles.None;
            btnSaveCat.BackColor = Color.FromArgb(219, 181, 132);
            btnSaveCat.BackgroundImageLayout = ImageLayout.None;
            btnSaveCat.FlatAppearance.BorderSize = 0;
            btnSaveCat.FlatStyle = FlatStyle.Flat;
            btnSaveCat.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveCat.Image = (Image)resources.GetObject("btnSaveCat.Image");
            btnSaveCat.Location = new Point(574, 590);
            btnSaveCat.Name = "btnSaveCat";
            btnSaveCat.Size = new Size(82, 79);
            btnSaveCat.TabIndex = 2;
            btnSaveCat.UseVisualStyleBackColor = false;
            btnSaveCat.Click += btnSaveCat_Click;
            // 
            // notifyIconSaveCat
            // 
            notifyIconSaveCat.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconSaveCat.BalloonTipText = "Este gatinho foi salvo com sucesso!, voce pode encontra-lo na sua \"Lista de gatos\"";
            notifyIconSaveCat.BalloonTipTitle = "Gatinho salvo!";
            notifyIconSaveCat.Icon = (Icon)resources.GetObject("notifyIconSaveCat.Icon");
            notifyIconSaveCat.Visible = true;
            // 
            // FunnyCatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 181, 132);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1131, 747);
            Controls.Add(btnSaveCat);
            Controls.Add(pictureBoxDisplayCats);
            Controls.Add(btnNewCatImage);
            DoubleBuffered = true;
            Name = "FunnyCatsForm";
            Text = "Veja fotos de gatinhos!";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDisplayCats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewCatImage;
        private PictureBox pictureBoxDisplayCats;
        private Button btnSaveCat;
        private NotifyIcon notifyIconSaveCat;
    }
}