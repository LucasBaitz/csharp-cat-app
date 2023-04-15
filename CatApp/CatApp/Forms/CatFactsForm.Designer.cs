namespace CatApp.Forms
{
    partial class CatFactsForm
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
            panel1 = new Panel();
            richTextBoxCatFacts = new RichTextBox();
            btnGetCatFacts = new Button();
            pictureBoxProfessorCat = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfessorCat).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(richTextBoxCatFacts);
            panel1.Controls.Add(btnGetCatFacts);
            panel1.Controls.Add(pictureBoxProfessorCat);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1268, 728);
            panel1.TabIndex = 2;
            // 
            // richTextBoxCatFacts
            // 
            richTextBoxCatFacts.Anchor = AnchorStyles.None;
            richTextBoxCatFacts.BackColor = Color.FromArgb(65, 84, 91);
            richTextBoxCatFacts.BorderStyle = BorderStyle.None;
            richTextBoxCatFacts.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxCatFacts.ForeColor = SystemColors.Menu;
            richTextBoxCatFacts.Location = new Point(335, 98);
            richTextBoxCatFacts.Name = "richTextBoxCatFacts";
            richTextBoxCatFacts.ReadOnly = true;
            richTextBoxCatFacts.Size = new Size(657, 274);
            richTextBoxCatFacts.TabIndex = 4;
            richTextBoxCatFacts.Text = "- Gatos não gostam de lasanha!";
            // 
            // btnGetCatFacts
            // 
            btnGetCatFacts.Anchor = AnchorStyles.None;
            btnGetCatFacts.FlatAppearance.BorderColor = Color.FromArgb(255, 218, 171);
            btnGetCatFacts.FlatStyle = FlatStyle.Flat;
            btnGetCatFacts.Image = Properties.Resources.questionCatIcon;
            btnGetCatFacts.Location = new Point(1055, 87);
            btnGetCatFacts.Name = "btnGetCatFacts";
            btnGetCatFacts.Size = new Size(116, 71);
            btnGetCatFacts.TabIndex = 3;
            btnGetCatFacts.UseVisualStyleBackColor = false;
            btnGetCatFacts.Click += btnGetCatFacts_Click_1;
            // 
            // pictureBoxProfessorCat
            // 
            pictureBoxProfessorCat.Anchor = AnchorStyles.None;
            pictureBoxProfessorCat.BackgroundImage = Properties.Resources.catFactsBG;
            pictureBoxProfessorCat.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxProfessorCat.Location = new Point(12, 3);
            pictureBoxProfessorCat.Name = "pictureBoxProfessorCat";
            pictureBoxProfessorCat.Size = new Size(1215, 688);
            pictureBoxProfessorCat.TabIndex = 2;
            pictureBoxProfessorCat.TabStop = false;
            // 
            // CatFactsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 181, 132);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1268, 728);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "CatFactsForm";
            Text = "Faça perguntas ao professor!";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfessorCat).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private RichTextBox richTextBoxCatFacts;
        private Button btnGetCatFacts;
        private PictureBox pictureBoxProfessorCat;
    }
}