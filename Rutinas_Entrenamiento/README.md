# Rutinas_Entrenamiento

This is a Blazor WebAssembly web application project designed to manage workout routines, allowing users to add, delete, and view exercise routines.

**Author:** Lawrence Babelonia

## Description

`Rutinas_Entrenamiento` is a demonstration application that illustrates how to create a workout routine management system using Blazor WebAssembly. The application allows users to add new exercise routines, delete existing routines by name, view a list of all available routines, and query details of specific routines. It uses a singleton service for in-memory data management.

## Features

*   **Blazor WebAssembly:** Client-side execution using WebAssembly.
*   **Routine Model:** `Rutinas` class with properties:
    *   `Id`: Unique identifier for the routine.
    *   `Nombre`: Name of the exercise routine.
    *   `Descripcion`: Description of the routine.
    *   `Duracion`: Duration of the routine in minutes.
*   **RutinaService:** Singleton service to manage routines with the following functionalities:
    *   In-memory routine storage.
    *   Add new routines with automatic ID generation.
    *   Delete routines by name (case-insensitive search).
    *   Get routines by ID.
    *   Pre-loaded sample routines (Squat, Barbell Curl).
*   **Management Pages:**
    *   `Home.razor`: Main page displaying the list of available routines.
    *   `AñadirRutina.razor`: Form to add new workout routines.
    *   `QuitarRutina.razor`: Form to delete routines by name.
    *   `DetallesEntrenamiento.razor`: Details page for a specific routine.
*   **Standard Components:** Includes example components like `Counter` and `Weather`.

## Prerequisites

*   [.NET SDK](https://dotnet.microsoft.com/download) (compatible version with the project, generally .NET 6 or higher).
*   Visual Studio, Visual Studio Code, or another C#-compatible editor.

## How to Run the Project

1.  **Clone or download the repository.**
2.  **Navigate to the project directory:**
    Open a terminal and run:
    ```bash
    cd "Blazor for Front-End Development/Rutinas_Entrenamiento/Rutinas_Entrenamiento"
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

*   `Rutinas.cs`: Data model to represent a workout routine with `Id`, `Nombre`, `Descripcion`, and `Duracion`.
*   `Services/`: Contains the application services:
    *   `RutinaService.cs`: Service to manage routines with `AñadirRutina()`, `QuitarRutina()`, and `ObtenerRutina()` methods.
*   `Pages/`: Contains Razor pages and components:
    *   `Home.razor`: Main page displaying the list of available routines.
    *   `AñadirRutina.razor`: Form to create and add new routines.
    *   `QuitarRutina.razor`: Form to delete routines by name.
    *   `DetallesEntrenamiento.razor`: Page to view the details of a specific routine.
    *   `Counter.razor`, `Weather.razor`: Additional example components.
*   `Layout/`: Contains shared layout components.
*   `wwwroot/`: Static files like CSS and images.
*   `Program.cs`: Application entry point and service configuration.

## Featured Functionalities

### RutinaService

The `RutinaService` service demonstrates:
*   In-memory state management with a routine list.
*   Automatic ID generation using `Max(r => r.Id) + 1`.
*   Complete CRUD methods:
    *   `AñadirRutina()`: Add new routines.
    *   `QuitarRutina()`: Delete routines by name (case-insensitive).
    *   `ObtenerRutina()`: Retrieve routines by ID.
*   Registration as a singleton service in `Program.cs` to share data between components.

### Routine Deletion

The deletion functionality (`QuitarRutina.razor`) includes:
*   Search for routines by name without case distinction.
*   Validation to verify that the routine exists before deleting it.
*   User feedback about the operation result.

## Sample Data

The application comes pre-loaded with two sample routines:
*   **Sentadilla** (Squat): Leg routine (30 minutes).
*   **Curl de Barra** (Barbell Curl): Arm routine (45 minutes).

## Technologies Used

*   **Blazor WebAssembly**: Framework for running .NET applications in the browser using WebAssembly.
*   **C#**: Primary programming language.
*   **Razor**: Syntax for user interface components.

## License

This project is for educational use and is available for learning and reference.

---

**© 2026 Lawrence Babelonia. All rights reserved.**
