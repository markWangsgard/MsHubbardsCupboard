namespace MsHubbardsLogic;

public class User
{
    public string Name { get; set; }
    public string PathToProfilePicture { get; set; }
    public List<Recipe> UploadedRecipes { get; set; } = new List<Recipe>();
    public List<Recipe> RecipesSaved { get; set; } = new List<Recipe>();
    public List<Ingreident> IngreidentsInCupboard { get; set; } = new List<Ingreident>();

    public User(string name)
    {
        Name = name;
        PathToProfilePicture = "ProfilePicture.svg";
    }
    public User(string name, string pathToProfilePicture) : this(name)
    {

        PathToProfilePicture = pathToProfilePicture;
    }
}