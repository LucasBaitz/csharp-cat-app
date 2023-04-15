public class CatBreed
{
    public string breedName;
    public string breedId;
    public string breedImgUrl;
    public string breedDescription;

    public CatBreed(string name, string id, string description)
    {
        breedName = name;
        breedId = id;
        breedDescription = description;
    }

    public override string ToString()
    {
        return breedName;
    }
}
