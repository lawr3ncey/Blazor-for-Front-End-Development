# Primer_Proyecto

This is a basic Blazor WebAssembly web application project designed to demonstrate fundamental Blazor concepts, including service configuration, list management, and use of configuration files.

**Author:** Lawrence Babelonia

## Description

`Primer_Proyecto` is a demonstration application that illustrates the basic concepts of Blazor WebAssembly. The project includes examples of interactive components, a service to access API configurations, and a page to manage a dynamic list of elements. It's ideal for learning Blazor fundamentals and the structure of a WebAssembly project.

## Features

*   **Blazor WebAssembly:** Client-side execution using WebAssembly.
*   **ApiService:** Singleton service to access the API base URL configuration from `appsetting.json`.
*   **ListaElementos:** Interactive component that allows adding and viewing elements in a dynamic list.
*   **Configuration:** Use of `appsetting.json` file to store configurations such as:
    *   API base URL (`ApiSettings:BaseUrl`)
    *   Connection strings
    *   Logging configuration
    *   Feature flags
*   **Standard Components:** Includes example components like `Counter`, `Weather`, and `Home`.
*   **OtroContador:** Additional custom counter component.

## Prerequisites

*   [.NET SDK](https://dotnet.microsoft.com/download) (compatible version with the project, generally .NET 6 or higher).
*   Visual Studio, Visual Studio Code, or another C#-compatible editor.

## How to Run the Project

1.  **Clone or download the repository.**
2.  **Navigate to the project directory:**
    Open a terminal and run:
    ```bash
    cd "Blazor for Front-End Development/Primer_Proyecto"
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

*   `Services/`: Contains application services:
    *   `ApiService.cs`: Service to get the API base URL from configuration.
*   `Pages/`: Contains Razor pages and components:
    *   `Home.razor`: Home page.
    *   `Counter.razor`: Interactive counter example.
    *   `OtroContador.razor`: Another counter example.
    *   `ListaElementos.razor`: Component to manage a dynamic list of elements.
    *   `Weather.razor`: Weather data display example.
*   `Layout/`: Contains shared layout components.
*   `wwwroot/`: Static files like CSS and images.
*   `appsetting.json`: Configuration file with application settings.
*   `Program.cs`: Application entry point and service configuration.

## Featured Functionalities

### ApiService

The `ApiService` service demonstrates how to:
*   Inject `IConfiguration` to access configuration.
*   Read values from the `appsetting.json` file.
*   Register the service as a singleton in `Program.cs`.

### ListaElementos

The `ListaElementos.razor` component shows:
*   Local state management with a list of strings.
*   Two-way binding with `@bind`.
*   Event handling with `@onclick`.
*   Basic validation to avoid adding empty elements.
*   Dynamic list rendering with `@foreach`.

## Configuration

The `appsetting.json` file contains several example configurations:
*   **ApiSettings.BaseUrl**: Base URL for API calls.
*   **ConnectionStrings**: Database connection strings.
*   **Logging**: Logging level configuration.
*   **FeatureFlags**: Flags to enable/disable features.

## Technologies Used

*   **Blazor WebAssembly**: Framework for running .NET applications in the browser using WebAssembly.
*   **C#**: Primary programming language.
*   **Razor**: Syntax for user interface components.

## License

This project is for educational use and is available for learning and reference.

---

**© 2026 Lawrence Babelonia. All rights reserved.**
