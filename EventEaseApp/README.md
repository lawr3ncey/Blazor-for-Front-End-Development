# EventEaseApp

EventEaseApp is a modern event management application built with **Blazor WebAssembly** and **.NET 9**. It allows users to explore events, register, and manage their attendance efficiently.

**Author:** Lawrence Babelonia

## Features

- **Event Listing**: Optimized event display using virtualization for high performance.
- **Event Registration**: Simple and intuitive registration form for attendees.
- **Attendance Tracking**: System to record and monitor event attendance.
- **Session Management**: User session state handling for a personalized experience.

## Technologies Used

- **.NET 9.0**: Microsoft's latest development framework version.
- **Blazor WebAssembly**: For building interactive client-side web interfaces with C#.
- **Bootstrap**: For responsive and modern design.

## Getting Started

Follow these steps to set up and run the project locally.

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

### Installation

1. Clone the repository:
   ```bash
   git clone <REPOSITORY_URL>
   ```
2. Navigate to the project directory:
   ```bash
   cd EventEaseApp
   ```
3. Restore dependencies:
   ```bash
   dotnet restore
   ```

### Running

To start the application in development mode:

```bash
cd EventEaseApp
dotnet watch
```

The application will typically be available at `http://localhost:5000` or `https://localhost:5001` (check console output for the exact URL).

## Project Structure

- **Pages**: Contains the Razor pages (views) of the application (`Events.razor`, `EventRegister.razor`, etc.).
- **Components**: Reusable UI components.
- **Services**: Business logic and services (`AttendanceService`, `UserSessionState`).
- **Models**: Data definitions and models (`Event`, `Registration`).
- **wwwroot**: Static files (CSS, images, JS).

## License

This project is for educational use and is available for learning and reference.

---

Developed with ❤️ using Blazor.

**© 2026 Lawrence Babelonia. All rights reserved.**
