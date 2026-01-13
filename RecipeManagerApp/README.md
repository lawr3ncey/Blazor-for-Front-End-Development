# RecipeManagerApp

This is a Blazor WebAssembly web application project designed to manage cooking recipes, allowing users to add, view, and query recipes.

**Author:** Lawrence Babelonia

## Description

`RecipeManagerApp` is a demonstration application that illustrates how to create a recipe management system using Blazor WebAssembly. The application allows users to add new recipes, view a list of all available recipes, and query details of specific recipes. It uses a singleton service for in-memory data management.

## Features

*   **Blazor WebAssembly:** Client-side execution using WebAssembly.
*   **Recipe Model:** `Recipe` class with `Id`, `Name`, and `Description` properties.
*   **RecipeService:** Singleton service to manage recipes with the following functionalities:
    *   In-memory recipe storage.
    *   Add new recipes with automatic ID generation.
    *   Get recipes by ID.
    *   Pre-loaded sample recipes (Spaghetti Bolognese, Chicken Curry).
*   **Management Pages:**
    *   `Home.razor`: Main page displaying the list of recipes.
    *   `AddRecipe.razor`: Form to add new recipes.
    *   `RecipeDetails.razor`: Details page for a specific recipe.
*   **Standard Components:** Includes example components like `Counter` and `Weather`.

## Prerequisites

*   [.NET SDK](https://dotnet.microsoft.com/download) (compatible version with the project, generally .NET 6 or higher).
*   Visual Studio, Visual Studio Code, or another C#-compatible editor.

## How to Run the Project

1.  **Clone or download the repository.**
2.  **Navigate to the project directory:**
    Open a terminal and run:
    ```bash
    cd "Blazor for Front-End Development/RecipeManagerApp/RecipeManagerApp"
    ```
3.  **Restore dependencies:**
    ```bash
    dotnet restore
    ```
4.  **Run the application:**
    ```bash
    dotnet run
    ```
    Or if using `dotnet watch` for hot reload:
    ```bash
    dotnet watch run
    ```
5.  **Open in browser:**
    The terminal will display the local URL (for example, `http://localhost:5000` or `https://localhost:7000`). Open that address in your web browser.

## Project Structure

*   `Recipe.cs`: Data model to represent a recipe with `Id`, `Name`, and `Description`.
*   `Services/`: Contains the application services:
    *   `RecipeService.cs`: Service to manage recipes with `AddRecipe()` and `GetRecipe()` methods.
*   `Pages/`: Contains Razor pages and components:
    *   `Home.razor`: Main page displaying the list of available recipes.
    *   `AddRecipe.razor`: Form to create and add new recipes.
    *   `RecipeDetails.razor`: Page to view the details of a specific recipe.
    *   `Counter.razor`, `Weather.razor`: Additional example components.
*   `Layout/`: Contains shared layout components.
*   `wwwroot/`: Static files like CSS and images.
*   `Program.cs`: Application entry point and service configuration.

## Featured Functionalities

### RecipeService

The `RecipeService` service demonstrates:
*   In-memory state management with a recipe list.
*   Automatic ID generation using `Max(r => r.Id) + 1`.
*   Methods to add and retrieve recipes.
*   Registration as a singleton service in `Program.cs` to share data between components.

### Page Navigation

The application shows:
*   Navigation from the recipe list (`Home.razor`) to the details of each recipe (`RecipeDetails.razor`).
*   Use of route parameters to pass the recipe ID.
*   Recipe creation form with navigation back to the main page.

## Sample Data

The application comes pre-loaded with two sample recipes:
*   **Spaghetti Bolognese**: A classic Italian pasta dish with rich meat sauce.
*   **Chicken Curry**: A flavorful curry dish with tender chicken pieces.

## Technologies Used

*   **Blazor WebAssembly**: Framework for running .NET applications in the browser using WebAssembly.
*   **C#**: Primary programming language.
*   **Razor**: Syntax for user interface components.

## License

This project is for educational use and is available for learning and reference.

---

**© 2026 Lawrence Babelonia. All rights reserved.**
