# BlazorPerformanceApp

This is a Blazor WebAssembly web application project designed to demonstrate component concepts and performance in Blazor.

**Author:** Lawrence Babelonia

## Description

`BlazorPerformanceApp` is a demonstration application that illustrates the use of Razor components, including a hybrid component (`HybridComponent.razor`) that shows how to render a list of simulated data. The project serves as a basic example to understand the structure and operation of a client-side Blazor application (WebAssembly).

## Features

*   **Blazor WebAssembly:** Client-side execution using WebAssembly.
*   **Razor Components:** Use of reusable components like `Counter`, `Home`, `Weather`, and `HybridComponent`.
*   **HybridComponent:** A custom component that demonstrates loading and rendering a simulated data list (`Data`).
*   **Dependency Injection:** Basic service configuration in `Program.cs`, including `HttpClient`.

## Prerequisites

*   [.NET SDK](https://dotnet.microsoft.com/download) (compatible version with the project, generally .NET 6 or higher).
*   Visual Studio, Visual Studio Code, or another C#-compatible editor.

## How to Run the Project

1.  **Clone or download the repository.**
2.  **Navigate to the project directory:**
    Open a terminal and run:
    ```bash
    cd "Blazor for Front-End Development/BlazorPerformanceApp/BlazorPerformanceApp"
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

*   `Pages/`: Contains the Razor pages and components of the application (`Home`, `Counter`, `Weather`, `HybridComponent`).
*   `Shared/`: (If exists) Contains shared components like the main layout (`MainLayout`) and navigation menu (`NavMenu`).
*   `wwwroot/`: Static files like CSS, images, and the `index.html` file.
*   `Program.cs`: Application entry point and service configuration.

## Technologies Used

*   **Blazor WebAssembly**: Framework for running .NET applications in the browser using WebAssembly.
*   **C#**: Primary programming language.
*   **Razor**: Syntax for user interface components.

## License

This project is for educational use and is available for learning and reference.

---

**© 2026 Lawrence Babelonia. All rights reserved.**
