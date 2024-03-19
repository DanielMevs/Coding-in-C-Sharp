using CookieCookbook.App;
using CookieCookbook.DataAccess;
using CookieCookbook.FileAccess;
using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

try
{
    const FileFormat Format = FileFormat.Json;

    IStringsRepository stringsRepository = Format == FileFormat.Json ?
        new StringsJsonRepository() :
        new StringsTextualRepository();

    const string FileName = "recipes";
    var fileMetadata = new FileMetadata(FileName, Format);

    var ingredientsRegister = new IngredientsRegister();

    var cookiesRecipesApp = new CookiesRecipesApp(
        new RecipesRepository(
            new StringsJsonRepository(),
            ingredientsRegister),
        new RecipesConsoleUserInteraction(
            ingredientsRegister));

    cookiesRecipesApp.Run(fileMetadata.ToPath());
}
catch(Exception ex)
{
    Console.WriteLine("Sorry! The application experienced" +
        " an unexpected error and will have to be closed. " +
        "The error message: " + ex.Message);

    Console.WriteLine("Press any key to close.");

    Console.ReadLine();
}


