using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

public class Recipe
{
    public IEnumerable<Ingredient> Ingredients { get; }

    public Recipe(IEnumerable<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }

    public override string ToString() => string.Join(Environment.NewLine, this.Ingredients
            .Select(ingredient => $"{ingredient.Name}, {ingredient.PreparationInstructions}"));
}
