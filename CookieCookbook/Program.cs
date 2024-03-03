var cookiesRecipesApp = new CookiesRecipesApp();
cookiesRecipesApp.Run();

class CookiesRecipesApp
{
    private readonly RecipesRepository _recipesRepository;
    private readonly RecipesUserInteraction _recipesUserInteraction;
    
    public CookiesRecipesApp(
        RecipesRepository recipesRepository,
        RecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }
    public void Run()
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        _recipesUserInteraction.PromptToCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        if (ingredients.Count > 0)
        {
            var recipes = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipesRepository.Write(filePath, allRecipes);

            _recipesUserInteraction.ShowMessage("Recipe added:");
            _recipesUserInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipesUserInteraction.ShowMessage(
                "No ingredients have been selected. " +
                "Recipe will not be saved.");
        }

        _recipesUserInteraction.Exit();
    }
}

public class RecipesUserInteraction
{
}

public class RecipesRepository
{
}