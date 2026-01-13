# FeedbackApp

This is a Blazor WebAssembly web application project designed to collect and manage user feedback through validated forms.

**Author:** Lawrence Babelonia

## Description

`FeedbackApp` is a demonstration application that illustrates how to create a feedback collection system using Blazor WebAssembly. The application allows users to submit feedback through a validated form and view all submitted feedback in a list. It uses data validation with Data Annotations and state management through a singleton service.

## Features

*   **Blazor WebAssembly:** Client-side execution using WebAssembly.
*   **Feedback Form:** `FeedbackForm.razor` component with fields for name, email, and comments.
*   **Form Validation:** Client-side validation using Data Annotations:
    *   `Name` field required.
    *   `Email` field with email format validation.
    *   `Comment` field with 500-character limit.
*   **Feedback Service:** `FeedbackService` implemented as a singleton to store and retrieve feedback.
*   **Feedback List:** `FeedbackList.razor` component to display all submitted feedback.
*   **Data Model:** `Feedback` class with validated properties.

## Prerequisites

*   [.NET SDK](https://dotnet.microsoft.com/download) (compatible version with the project, generally .NET 6 or higher).
*   Visual Studio, Visual Studio Code, or another C#-compatible editor.

## How to Run the Project

1.  **Clone or download the repository.**
2.  **Navigate to the project directory:**
    Open a terminal and run:
    ```bash
    cd "Blazor for Front-End Development/FeedbackApp/FeedbackApp"
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

*   `Models/`: Contains data models:
    *   `Feedback.cs`: Model with `Name`, `Email`, and `Comment` properties, including validation attributes.
*   `Services/`: Contains application services:
    *   `FeedbackService.cs`: Singleton service to manage the feedback list with `AddFeedback()` and `GetFeedback()` methods.
*   `Pages/`: Contains Razor pages and components:
    *   `FeedbackForm.razor`: Form to submit feedback (main page `/`).
    *   `FeedbackList.razor`: List of all submitted feedback.
    *   `Counter.razor`, `Weather.razor`, `Home.razor`: Additional example components.
*   `Layout/`: Contains shared layout components.
*   `wwwroot/`: Static files like CSS and images.
*   `Program.cs`: Application entry point and service configuration.

## Featured Functionalities

### Form Validation

The `Feedback` model uses Data Annotations to validate data:
*   `[Required]`: Required field for name.
*   `[EmailAddress]`: Email format validation.
*   `[StringLength(500)]`: Character limit for comments.

### State Management

The `FeedbackService` is registered as a singleton in `Program.cs`, allowing the feedback list to be shared between different components during the application session.

## Technologies Used

*   **Blazor WebAssembly**: Framework for running .NET applications in the browser using WebAssembly.
*   **C#**: Primary programming language.
*   **Razor**: Syntax for user interface components.
*   **Data Annotations**: For model validation.

## License

This project is for educational use and is available for learning and reference.

---

**© 2026 Lawrence Babelonia. All rights reserved.**
