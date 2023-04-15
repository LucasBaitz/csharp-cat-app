using CatApp.Classes;
using CatApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatApp.Forms
{

    public partial class CatListForm : Form
    {
        private MongoDBConnection MongoDataBase = new MongoDBConnection();

        public CatListForm()
        {
            InitializeComponent();
            LoadCats();


        }

        private void dataGridViewFavoriteCats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public async void LoadCats()
        {
            var cats = await MongoDataBase.GetFavCats();
            if (cats.Count > 0)
            {
                foreach (StarCat cat in cats)
                {
                    int rowIndex = dataGridViewFavoriteCats.Rows.Add();
                    dataGridViewFavoriteCats.Rows[rowIndex].Cells["description"].Value = $"Raça: {cat.Description}";
                    dataGridViewFavoriteCats.Rows[rowIndex].Cells["imageUrl"].Value = cat.ImageUrl;

                }
            }
            else
            {
                int rowIndex = dataGridViewFavoriteCats.Rows.Add();
                dataGridViewFavoriteCats.Rows[rowIndex].Cells["description"].Value = $"Poxa, nenhum gatinho ?";
                dataGridViewFavoriteCats.Rows[rowIndex].Cells["imageUrl"].Value = ":(";
            }
        }



    }
}
