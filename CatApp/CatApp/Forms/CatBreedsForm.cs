using CatApp.Classes;
using CatApp.Database;
namespace CatApp.Forms
{

    public partial class CatBreedsForm : Form
    {
        private API inputsAPI = new API("", "https://api.thecatapi.com/v1/breeds");
        private MongoDBConnection MongoDataBase = new MongoDBConnection();
        public CatBreedsForm()
        {
            InitializeComponent();
            fillCatComboBox();
        }

        private void btnSearchBreed_Click(object sender, EventArgs e)
        {
            labelBreedName.Text = ((CatBreed)comboBoxAvailableBreeds.SelectedItem).breedName;
            textBoxBreedDescription.Text = ((CatBreed)comboBoxAvailableBreeds.SelectedItem).breedDescription;

            inputsAPI.apiGetBreeds(comboBoxAvailableBreeds, pictureBoxCatSearchImage);
        }

        private async Task fillCatComboBox()
        {
            List<CatBreed> inputBreeds = await inputsAPI.GetInputBreeds();
            foreach (CatBreed breed in inputBreeds)
            {
                comboBoxAvailableBreeds.Items.Add(breed);
            }
        }



        private void btnSaveBreed_Click(object sender, EventArgs e)
        {
            StarCat saveBreed = new StarCat(labelBreedName.Text, pictureBoxCatSearchImage.ImageLocation);
            MongoDataBase.AddCat(saveBreed);
        }

        private void CatBreedsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
