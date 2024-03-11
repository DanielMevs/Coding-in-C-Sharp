using CookieCookbook.Recipes.Ingredients;
using CookieCookbook.Recipes;

namespace CookieCookbook.App
{
    public class RecipesConsoleUserInteraction : IRecipesUserInteraction
    {
        private readonly IngredientsRegister _ingredientsRegister;

        public RecipesConsoleUserInteraction(
            IngredientsRegister ingredientsRegister)
        {
            _ingredientsRegister = ingredientsRegister;
        }
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void Exit()
        {
            Console.WriteLine("Press any key to close.");
            Console.ReadLine();
        }

        public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
        {
            if (allRecipes.Count() > 0)
            {
                Console.WriteLine("Existing recipes are:" + Environment.NewLine);

                var recipeCounter = 1;
                foreach (var recipe in allRecipes)
                {
                    Console.WriteLine($"*****{recipeCounter}*****");
                    Console.WriteLine(recipe);
                    Console.WriteLine();
                    ++recipeCounter;
                }
            }
        }

        public void PromptToCreateRecipe()
        {
            Console.WriteLine("Create a new cookie recipe! " +
                "Available ingredients are:");

            foreach (var ingredient in _ingredientsRegister.All)
            {
                Console.WriteLine(ingredient);
            }
        }

        public IEnumerable<Ingredient> ReadIngredientsFromUser()
        {
            bool shallStop = false;
            var ingredients = new List<Ingredient>();

            while (!shallStop)
            {
                Console.WriteLine("Add an ingredient by its ID, " +
                    "or type anything else if finished.");
                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int id))
                {
                    var selectedIngredient = _ingredientsRegister.GetById(id);
                    if (selectedIngredient is not null)
                    {
                        ingredients.Add(selectedIngredient);
                    }
                }
                else
                {
                    shallStop = true;
                }
            }

            return ingredients;
        }
    }
}
