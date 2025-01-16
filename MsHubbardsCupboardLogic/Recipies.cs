namespace RecipeLogic;
using IngridentLogic;

public class Recipe
{
    public string Name { get; set; }
    public List<Ingreident> Ingredients { get; set; }
    public List<string> Directions { get; set; }
    public int TimeToMake { get; set; }
    public string PathToRecipePicture { get; set; }
    public Guid RecipeID = Guid.NewGuid();
    public Recipe(string name)
    {
        Name = name;
        PathToRecipePicture = $"{RecipeID}.png";
    }
    public Recipe(string name, List<Ingreident> ingreidents) : this(name)
    {
        Ingredients = ingreidents;
    }
    public Recipe(string name, List<Ingreident> ingreidents, List<string> directions) : this(name, ingreidents)
    {
        Directions = directions;
    }
    public Recipe(string name, List<Ingreident> ingreidents, List<string> directions, int timeToMake) : this(name, ingreidents, directions)
    {
        TimeToMake = timeToMake;
    }
}