using CatApp.Classes;
using CatApp.Database;
using Newtonsoft.Json;
using System.Drawing.Design;
using System.Windows.Forms;

namespace CatApp.Forms
{
    public partial class FunnyCatsForm : Form
    {
        private API getFunnyCatAPI = new API("https://cataas.com/cat?json=true");
        private string currentImage;
        private string currentImageDescription = "Engraçado :)";
        private MongoDBConnection MongoDataBase = new MongoDBConnection();

        public FunnyCatsForm()
        {

            InitializeComponent();
            getFunnyCatAPI.apiGetImage(pictureBoxDisplayCats);
        }

        private async void btnNewCatImage_Click(object sender, EventArgs e)
        {
            getFunnyCatAPI.apiGetImage(pictureBoxDisplayCats);
        }


        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            StarCat newCat = new StarCat(currentImageDescription, this.currentImage);
            MongoDataBase.AddCat(newCat);
            ShowNotification();

        }

        private void ShowNotification()
        {
            notifyIconSaveCat.ShowBalloonTip(5000);
        }

    }
}
