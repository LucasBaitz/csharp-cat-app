using Newtonsoft.Json;
using System.Diagnostics;

namespace CatApp.Classes
{
    public class API
    {
        private readonly string apiKey;
        private readonly string apiLink;

        public API(string apiKey, string apiLink)
        {
            this.apiKey = apiKey;
            this.apiLink = apiLink;

        }

        private async void apiGetImage(PictureBox dataDisplayLocation)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(apiKey);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(json);
                    string imageUrl = data[0].url;

                    dataDisplayLocation.ImageLocation = imageUrl;
                    dataDisplayLocation.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
        }

        public async void apiGetString(RichTextBox dataDisplayLocation)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{apiLink}{apiKey}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(json);
                    string dataText = data.data[0];


                    dataDisplayLocation.AppendText($"- {dataText} \n\n");

                }

            }
        }

        public async Task<List<CatBreed>> GetInputBreeds()
        {
            List<CatBreed> catBreeds = new List<CatBreed>();

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(this.apiLink);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(json);

                    foreach (var catBreed in data)
                    {
                        string name = catBreed.name;
                        string id = catBreed.id;
                        string description = catBreed.description;
                        var newBreed = new CatBreed(name, id, description);
                        catBreeds.Add(newBreed);
                    }
                }
            }

            return catBreeds;
        }



        public async void apiGetBreeds(ComboBox selectedCat, PictureBox breedImage)
        {

            string searchBreedID = ((CatBreed)selectedCat.SelectedItem).breedId;
            

            Debug.WriteLine(searchBreedID);
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"https://api.thecatapi.com/v1/images/search?breed_ids={searchBreedID}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(json);

                    breedImage.ImageLocation = data[0].url;
                    breedImage.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
        }
    }
}


       

