namespace CatApp.Forms
{
    partial class CatListForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelFormBG = new Panel();
            dataGridViewFavoriteCats = new DataGridView();
            description = new DataGridViewTextBoxColumn();
            imageUrl = new DataGridViewTextBoxColumn();
            panelFormBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFavoriteCats).BeginInit();
            SuspendLayout();
            // 
            // panelFormBG
            // 
            panelFormBG.BackColor = Color.FromArgb(219, 181, 132);
            panelFormBG.BackgroundImage = Properties.Resources.catListBG;
            panelFormBG.BackgroundImageLayout = ImageLayout.Zoom;
            panelFormBG.Controls.Add(dataGridViewFavoriteCats);
            panelFormBG.Dock = DockStyle.Fill;
            panelFormBG.Location = new Point(0, 0);
            panelFormBG.Name = "panelFormBG";
            panelFormBG.Size = new Size(953, 749);
            panelFormBG.TabIndex = 0;
            // 
            // dataGridViewFavoriteCats
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewFavoriteCats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFavoriteCats.Anchor = AnchorStyles.None;
            dataGridViewFavoriteCats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFavoriteCats.BackgroundColor = Color.White;
            dataGridViewFavoriteCats.BorderStyle = BorderStyle.None;
            dataGridViewFavoriteCats.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewFavoriteCats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFavoriteCats.Columns.AddRange(new DataGridViewColumn[] { description, imageUrl });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(245, 198, 236);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewFavoriteCats.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewFavoriteCats.GridColor = Color.White;
            dataGridViewFavoriteCats.Location = new Point(258, 148);
            dataGridViewFavoriteCats.Name = "dataGridViewFavoriteCats";
            dataGridViewFavoriteCats.ReadOnly = true;
            dataGridViewFavoriteCats.RowHeadersVisible = false;
            dataGridViewFavoriteCats.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewFavoriteCats.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewFavoriteCats.RowTemplate.Height = 29;
            dataGridViewFavoriteCats.Size = new Size(462, 556);
            dataGridViewFavoriteCats.TabIndex = 0;
            // 
            // description
            // 
            description.HeaderText = "Descrição";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // imageUrl
            // 
            imageUrl.HeaderText = "URL da imagem";
            imageUrl.MinimumWidth = 6;
            imageUrl.Name = "imageUrl";
            imageUrl.ReadOnly = true;
            // 
            // CatListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 749);
            Controls.Add(panelFormBG);
            Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CatListForm";
            Text = "Veja seus gatinhos salvos!";
            panelFormBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFavoriteCats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormBG;
        private DataGridView dataGridViewFavoriteCats;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn imageUrl;
    }
}