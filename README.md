# My ASP.NET MVC App

A simple ASP.NET MVC application built with .NET.
This app demonstrates Models, Views, Controllers, routing, and validation.

---

## Prerequisites

* [.NET SDK](https://dotnet.microsoft.com/en-us/download) (version 6 or higher recommended)
* Visual Studio, VS Code, or another C# IDE
* (Optional) Git for version control

---

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/your-username/your-repo-name.git
cd your-repo-name
```

### 2. Restore dependencies

```bash
dotnet restore
```

### 3. Build the project

```bash
dotnet build
```

### 4. Run the app

```bash
dotnet run
```

The app will start and provide a URL in the terminal, usually:

```
https://localhost:5001
http://localhost:5000
```

Open your browser and navigate to the URL.

---

## Features

* Display a list of books
* Book details page
* Data validation using Data Annotations
* Routing (conventional and attribute routing)
* Images displayed from URLs

---

## Project Structure

```
/Controllers      - MVC Controllers
/Models           - Data models and validation
/Views            - Razor views
/wwwroot          - Static files (css, js, images)
/Program.cs       - Entry point
/Startup.cs       - (if using .NET Core 3.x) Configuration
```

---

## Notes

* The app currently uses in-memory data, no database required.
* Images are loaded from URLs. No async needed in controllers for this.
* Validation ensures correct input for title, author, year, and optional image URL.

---

## License

This project is open-source and free to use.
