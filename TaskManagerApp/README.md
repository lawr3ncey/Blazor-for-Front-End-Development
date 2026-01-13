# TaskManagerApp

This is a Blazor WebAssembly web application project designed to demonstrate communication between parent and child components using parameters and events.

**Author:** Lawrence Babelonia

## Description

`TaskManagerApp` is a demonstration application that illustrates the fundamental concepts of component communication in Blazor. The project shows how a parent component (`ParentTaskManager`) can pass data to child components (`ChildTaskDisplay`) and how child components can notify events back to the parent using `EventCallback`. It's ideal for learning component communication patterns in Blazor.

## Features

*   **Blazor WebAssembly:** Client-side execution using WebAssembly.
*   **Parent-Child Communication:** Demonstration of passing data from parent to child using `[Parameter]` parameters.
*   **Child-Parent Communication:** Use of `EventCallback<T>` to notify events from child to parent.
*   **Components:**
    *   `ParentTaskManager.razor`: Parent component that manages a list of tasks.
    *   `ChildTaskDisplay.razor`: Child component that displays an individual task and allows marking it as completed.
*   **Dynamic Rendering:** Use of `@foreach` to render multiple instances of the child component.
*   **State Management:** UI updates using `StateHasChanged()`.
*   **Standard Components:** Includes example components like `Counter` and `Home`.

## Prerequisites

*   [.NET SDK](https://dotnet.microsoft.com/download) (compatible version with the project, generally .NET 6 or higher).
*   Visual Studio, Visual Studio Code, or another C#-compatible editor.

## How to Run the Project

1.  **Clone or download the repository.**
2.  **Navigate to the project directory:**
    Open a terminal and run:
    ```bash
    cd "Blazor for Front-End Development/TaskManagerApp"
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
6.  **Navigate to the tasks page:**
    Access `/parent-task-manager` to view the task manager.

## Project Structure

*   `Pages/`: Contains Razor pages and components:
    *   `ParentTaskManager.razor`: Parent component that manages the task list and handles events from child components.
    *   `ChildTaskDisplay.razor`: Child component that displays an individual task with a button to mark it as completed.
    *   `Counter.razor`, `Home.razor`: Additional example components.
*   `Layout/`: Contains shared layout components.
*   `wwwroot/`: Static files like CSS and images.
*   `Program.cs`: Application entry point and service configuration.

## Featured Functionalities

### Parent → Child Communication

The `ParentTaskManager` component passes data to the `ChildTaskDisplay` component via the `TaskName` parameter:

```razor
<ChildTaskDisplay TaskName="@task" OnTaskCompleted="HandleTaskCompleted"/>
```

The child component receives the data through:

```csharp
[Parameter]
public string TaskName { get; set; } = "Unnamed task";
```

### Child → Parent Communication

The `ChildTaskDisplay` component notifies the parent when a task is completed using `EventCallback`:

```csharp
[Parameter]
public EventCallback<string> OnTaskCompleted { get; set; }

private async Task MarkAsCompleted()
{
    await OnTaskCompleted.InvokeAsync(TaskName);
}
```

The parent component handles the event:

```csharp
private void HandleTaskCompleted(string completedTask)
{
    TaskList.Remove(completedTask);
    StateHasChanged();
}
```

## Technologies Used

*   **Blazor WebAssembly**: Framework for running .NET applications in the browser using WebAssembly.
*   **C#**: Primary programming language.
*   **Razor**: Syntax for user interface components.

## License

This project is for educational use and is available for learning and reference.

---

**© 2026 Lawrence Babelonia. All rights reserved.**
