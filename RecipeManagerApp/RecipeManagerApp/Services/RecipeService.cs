//Servicio para manejar recetas
namespace RecipeManagerApp.Services
{
    public class RecipeService
    {
        public List<Recipe> Recipes { get; set; } = new List<Recipe>// Ejemplo de recetas iniciales
        {
        new Recipe { Id = 1, Name = "Spaghetti Bolognese", Description = "A classic Italian pasta dish with rich meat sauce." },
        new Recipe { Id = 2, Name = "Chicken Curry", Description = "A flavorful curry dish with tender chicken pieces." },
        };

        public void AddRecipe(Recipe recipe)// Método para agregar una nueva receta
        {
            recipe.Id = Recipes.Max(r => r.Id) + 1;// Asignar un nuevo Id
            Recipes.Add(recipe);// Agregar la receta a la lista
        }

        public Recipe GetRecipe(int id)// Método para obtener una receta por Id
        {
            return Recipes.FirstOrDefault(r => r.Id == id);// Buscar la receta en la lista
        }
    }
}