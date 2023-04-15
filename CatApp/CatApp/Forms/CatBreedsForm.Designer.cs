namespace CatApp.Forms
{
    partial class CatBreedsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatBreedsForm));
            pictureBoxCatSearchImage = new PictureBox();
            labelBreedName = new Label();
            panelFormBG = new Panel();
            label1 = new Label();
            panelOptions = new Panel();
            btnSearchBreed = new Button();
            btnSaveBreed = new Button();
            comboBoxAvailableBreeds = new ComboBox();
            textBoxBreedDescription = new TextBox();
            notifyIconSaveCat = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCatSearchImage).BeginInit();
            panelFormBG.SuspendLayout();
            panelOptions.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxCatSearchImage
            // 
            pictureBoxCatSearchImage.Anchor = AnchorStyles.None;
            pictureBoxCatSearchImage.BackColor = Color.FromArgb(250, 185, 205);
            pictureBoxCatSearchImage.Location = new Point(360, 78);
            pictureBoxCatSearchImage.Name = "pictureBoxCatSearchImage";
            pictureBoxCatSearchImage.Size = new Size(581, 388);
            pictureBoxCatSearchImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCatSearchImage.TabIndex = 3;
            pictureBoxCatSearchImage.TabStop = false;
            // 
            // labelBreedName
            // 
            labelBreedName.Anchor = AnchorStyles.None;
            labelBreedName.BackColor = Color.FromArgb(250, 185, 205);
            labelBreedName.Font = new Font("Brush Script MT", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelBreedName.ForeColor = SystemColors.ButtonHighlight;
            labelBreedName.Location = new Point(480, 446);
            labelBreedName.Name = "labelBreedName";
            labelBreedName.Size = new Size(348, 43);
            labelBreedName.TabIndex = 5;
            labelBreedName.Text = "Raça do gatinho!";
            labelBreedName.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelFormBG
            // 
            panelFormBG.Anchor = AnchorStyles.None;
            panelFormBG.BackColor = Color.FromArgb(219, 181, 132);
            panelFormBG.BackgroundImage = (Image)resources.GetObject("panelFormBG.BackgroundImage");
            panelFormBG.BackgroundImageLayout = ImageLayout.Zoom;
            panelFormBG.Controls.Add(label1);
            panelFormBG.Controls.Add(panelOptions);
            panelFormBG.Controls.Add(labelBreedName);
            panelFormBG.Controls.Add(pictureBoxCatSearchImage);
            panelFormBG.Controls.Add(textBoxBreedDescription);
            panelFormBG.Location = new Point(-1, 1);
            panelFormBG.Name = "panelFormBG";
            panelFormBG.Size = new Size(1340, 723);
            panelFormBG.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1051, 51);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 1;
            label1.Text = "Escolha uma raça!";
            // 
            // panelOptions
            // 
            panelOptions.Anchor = AnchorStyles.None;
            panelOptions.Controls.Add(btnSearchBreed);
            panelOptions.Controls.Add(btnSaveBreed);
            panelOptions.Controls.Add(comboBoxAvailableBreeds);
            panelOptions.Location = new Point(1031, 82);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(244, 114);
            panelOptions.TabIndex = 2;
            // 
            // btnSearchBreed
            // 
            btnSearchBreed.Anchor = AnchorStyles.None;
            btnSearchBreed.FlatAppearance.BorderSize = 0;
            btnSearchBreed.FlatStyle = FlatStyle.Flat;
            btnSearchBreed.Image = Properties.Resources.searchIcon;
            btnSearchBreed.Location = new Point(3, 49);
            btnSearchBreed.Name = "btnSearchBreed";
            btnSearchBreed.Size = new Size(67, 67);
            btnSearchBreed.TabIndex = 4;
            btnSearchBreed.UseVisualStyleBackColor = true;
            btnSearchBreed.Click += btnSearchBreed_Click;
            // 
            // btnSaveBreed
            // 
            btnSaveBreed.Anchor = AnchorStyles.None;
            btnSaveBreed.FlatAppearance.BorderSize = 0;
            btnSaveBreed.FlatStyle = FlatStyle.Flat;
            btnSaveBreed.Image = (Image)resources.GetObject("btnSaveBreed.Image");
            btnSaveBreed.Location = new Point(76, 49);
            btnSaveBreed.Name = "btnSaveBreed";
            btnSaveBreed.Size = new Size(67, 71);
            btnSaveBreed.TabIndex = 6;
            btnSaveBreed.UseVisualStyleBackColor = true;
            btnSaveBreed.Click += btnSaveBreed_Click;
            // 
            // comboBoxAvailableBreeds
            // 
            comboBoxAvailableBreeds.BackColor = Color.FromArgb(245, 198, 236);
            comboBoxAvailableBreeds.Dock = DockStyle.Top;
            comboBoxAvailableBreeds.DropDownHeight = 200;
            comboBoxAvailableBreeds.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAvailableBreeds.DropDownWidth = 200;
            comboBoxAvailableBreeds.FlatStyle = FlatStyle.Popup;
            comboBoxAvailableBreeds.FormattingEnabled = true;
            comboBoxAvailableBreeds.IntegralHeight = false;
            comboBoxAvailableBreeds.ItemHeight = 20;
            comboBoxAvailableBreeds.Location = new Point(0, 0);
            comboBoxAvailableBreeds.MaxDropDownItems = 20;
            comboBoxAvailableBreeds.Name = "comboBoxAvailableBreeds";
            comboBoxAvailableBreeds.Size = new Size(244, 28);
            comboBoxAvailableBreeds.TabIndex = 0;
            // 
            // textBoxBreedDescription
            // 
            textBoxBreedDescription.Anchor = AnchorStyles.None;
            textBoxBreedDescription.BackColor = Color.FromArgb(219, 181, 132);
            textBoxBreedDescription.BorderStyle = BorderStyle.None;
            textBoxBreedDescription.Font = new Font("Calisto MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxBreedDescription.Location = new Point(1031, 206);
            textBoxBreedDescription.Multiline = true;
            textBoxBreedDescription.Name = "textBoxBreedDescription";
            textBoxBreedDescription.ReadOnly = true;
            textBoxBreedDescription.Size = new Size(244, 506);
            textBoxBreedDescription.TabIndex = 5;
            // 
            // notifyIconSaveCat
            // 
            notifyIconSaveCat.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconSaveCat.BalloonTipText = "Este gatinho foi salvo com sucesso!, voce pode encontra-lo na sua \"Lista de gatos\"";
            notifyIconSaveCat.BalloonTipTitle = "Gatinho salvo!";
            notifyIconSaveCat.Icon = (Icon)resources.GetObject("notifyIconSaveCat.Icon");
            notifyIconSaveCat.Visible = true;
            // 
            // CatBreedsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 181, 132);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1340, 724);
            Controls.Add(panelFormBG);
            DoubleBuffered = true;
            Name = "CatBreedsForm";
            Text = "Busque por raças!";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCatSearchImage).EndInit();
            panelFormBG.ResumeLayout(false);
            panelFormBG.PerformLayout();
            panelOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxCatSearchImage;
        private Label labelBreedName;
        private Panel panelFormBG;
        private Label label1;
        private Panel panelOptions;
        private Button btnSaveBreed;
        private ComboBox comboBoxAvailableBreeds;
        private Button btnSearchBreed;
        private TextBox textBoxBreedDescription;
        private NotifyIcon notifyIconSaveCat;
    }
}