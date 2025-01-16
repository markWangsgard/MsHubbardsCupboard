using IngridentLogic;
using RecipeLogic;

namespace UserLogic;

public class UserLogic
{
    public string Name { get; set; }
    public List<Recipe> UploadedRecipes { get; set; }
    public List<Recipe> RecipesSaved { get; set; }
    public List<Ingreident> IngreidentsInCupboard { get; set; }
    public string PathToProfilePicture { get; set; }
    public List<Ingreident> Pantry { get; set;}

    public void AddIngredient(Ingreident ingredient)
    {

    }
}