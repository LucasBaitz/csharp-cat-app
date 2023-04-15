using CatApp.Classes;
using CatApp.Database;
using Newtonsoft.Json;
using System.Drawing.Design;
using System.Windows.Forms;

namespace CatApp.Forms
{
    public partial class FunnyCatsForm : Form
    {
        private string apiKey = "live_BkRgHJPpp7hxq4DbxgmojoTntpAzUaEz5DfHZohswoToGRFUXJHmAhNuLQnj629o";
        private HttpClient httpClient = new HttpClient();
        private string currentImage;
        private string currentImageDescription;
        private MongoDBConnection MongoDataBase = new MongoDBConnection();

        public FunnyCatsForm()
        {

            InitializeComponent();
            GetImage();
        }

        private async void btnNewCatImage_Click(object sender, EventArgs e)
        {
            GetImage();
        }

        private async void GetImage()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://cataas.com/cat?json=true");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(json);
                    string imageUrl = $"https://cataas.com{data.url}";
                    this.currentImage = $"https://cataas.com{data.url}";

                    pictureBoxDisplayCats.ImageLocation = imageUrl;
                    pictureBoxDisplayCats.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            StarCat newCat = new StarCat(this.currentImageDescription = "Engraçado :)", this.currentImage);
            MongoDataBase.AddCat(newCat);

        }

        private void ShowNotification(string message)
        {
            notifyIconSaveCat.ShowBalloonTip(5000);
        }


        private void FunnyCatsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
