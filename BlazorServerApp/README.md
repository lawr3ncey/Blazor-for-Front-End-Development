# BlazorServerApp

This is a Blazor Server web application project designed to demonstrate server-side rendering concepts, real-time communication with SignalR, and state management.

**Author:** Lawrence Babelonia

## Description

`BlazorServerApp` is a demonstration application that illustrates the use of Blazor Server, where application logic runs on the server and UI updates are sent to the client through a SignalR connection. The project includes examples of real-time chat, state management, and interactive components.

## Features

*   **Blazor Server:** Server-side rendering with real-time updates via SignalR.
*   **SignalR Chat:** Real-time chat implementation using SignalR (`SignalRChat.razor` and `NotificationHub.cs`).
*   **Interactive Components:** Includes components like `Counter`, `Weather`, and `StateManagement`.
*   **State Management:** Example of state management in Blazor Server components.
*   **Interactive Rendering Mode:** Use of `@rendermode InteractiveServer` for components with server-side interactivity.

## Prerequisites

*   [.NET SDK](https://dotnet.microsoft.com/download) (compatible version with the project, generally .NET 6 or higher).
*   Visual Studio, Visual Studio Code, or another C#-compatible editor.

## How to Run the Project

1.  **Clone or download the repository.**
2.  **Navigate to the project directory:**
    Open a terminal and run:
    ```bash
    cd "Blazor for Front-End Development/BlazorServerApp/BlazorServerApp"
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

*   `Components/Pages/`: Contains the Razor pages and components of the application:
    *   `Home.razor`: Home page.
    *   `Counter.razor`: Interactive counter example.
    *   `Weather.razor`: Weather data display example.
    *   `SignalRChat.razor`: Real-time chat implementation with SignalR.
    *   `StateManagement.razor`: State management example.
    *   `Error.razor`: Error page.
*   `Components/Layout/`: Contains shared layout components (like `MainLayout` and `NavMenu`).
*   `Hubs/`: Contains SignalR hubs:
    *   `NotificationHub.cs`: Hub for real-time chat communication.
*   `wwwroot/`: Static files like CSS, JavaScript, and images.
*   `Program.cs`: Application entry point and service configuration (including SignalR).

## Featured Functionalities

### SignalR Chat

The `SignalRChat.razor` component demonstrates how to implement a real-time chat:
*   Connection to the SignalR hub (`NotificationHub`).
*   Sending and receiving messages in real-time.
*   Connection status indicator.
*   Connection lifecycle management with `IAsyncDisposable`.

### State Management

The application shows how to manage state in Blazor Server components, maintaining data during user interactions.

## Technologies Used

*   **Blazor Server**: Framework for applications with server-side rendering and real-time updates.
*   **SignalR**: Library for real-time communication.
*   **ASP.NET Core**: Microsoft's web framework.
*   **C#**: Primary programming language.
*   **Razor**: Syntax for user interface components.

## License

This project is for educational use and is available for learning and reference.

---

**© 2026 Lawrence Babelonia. All rights reserved.**
