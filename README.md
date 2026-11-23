# Dive Hub Logbook

A personal scuba diving logbook built with **C#, .NET 10 and .NET MAUI**. Record dives, manage equipment details, search your history and review diving statistics—all with local SQLite storage.

Developed by **Hakan Berat Demircan**, a scuba diving instructor and former dive center co-owner.

## Overview

Dive Hub Logbook brings essential dive records into a single application: where you dived, how deep you went, how long you stayed and the equipment you used.

The application uses a shared MAUI codebase, an MVVM structure and a local database. Core logbook operations do not require an account, backend server or internet connection.

## Features

### Dive Management

- Add new dive records.
- Browse dives ordered by date, newest first.
- View individual dive details.
- Edit existing records.
- Delete dives with a confirmation prompt.
- Return to the logbook after saving a new dive.

### Dive Record Fields

| Category | Fields |
|---|---|
| Identification | Dive number, date and dive site |
| Dive profile | Maximum depth, bottom time and water temperature |
| Exposure protection | Suit type, length and thickness |
| Weighting | Weight carried in kilograms |
| Additional details | Dive buddy and notes |

Suit length and thickness fields are conditional on the selected suit type. Selecting a dry suit clears these wetsuit-specific values.

### Search

Search the logbook by:

- Dive site
- Dive buddy
- Notes

Search is case-insensitive and updates as the search text changes.

### Dashboard

View statistics calculated from your saved records:

- Total recorded dives
- Maximum recorded depth
- Total bottom time, displayed in hours and minutes
- Most recent dive date and site

### Local Storage

Dive records are stored in a SQLite database named `divelogbook.db3` within the application's data directory.

The database and dive table are created automatically when first accessed. No external database installation is required.

## Technology Stack

| Area | Technology |
|---|---|
| Language | C# |
| Framework | .NET 10 / .NET MAUI |
| Interface | XAML |
| Application structure | MVVM |
| MVVM tooling | CommunityToolkit.Mvvm |
| Persistence | SQLite through sqlite-net-pcl |
| Navigation | MAUI Shell |
| Dependency injection | Microsoft.Extensions.DependencyInjection |

## Architecture

The application separates responsibilities across four main areas:

| Area | Responsibility |
|---|---|
| `Models` | Dive record structure and SQLite mapping |
| `Views` | XAML screens, bindings and page-level interactions |
| `ViewModels` | Observable state, commands, filtering and statistics |
| `Data` | Asynchronous database initialization and CRUD operations |

`MauiProgram.cs` registers the database service, pages and view models with the dependency injection container.

`DiveDatabase` is registered as a singleton. Pages and view models are registered as transient services.

MAUI Shell provides three main tabs:

- **Dashboard** — statistics and latest dive information
- **Logbook** — searchable dive history
- **Add Dive** — new dive entry

Dive details and editing are separate routes. Selected records are passed between pages using their database IDs.

## Project Guide

| Path | Contents |
|---|---|
| `Models/Dive.cs` | Dive entity and SQLite attributes |
| `Data/DiveDatabase.cs` | SQLite initialization, queries, inserts, updates and deletion |
| `ViewModels/` | View models for dashboard, logbook, creation, details and editing |
| `Views/` | Application pages |
| `Resources/` | Styles, fonts, images, icons and splash assets |
| `Platforms/` | Platform-specific configuration and entry points |
| `AppShell.xaml.cs` | Tabs and navigation routes |
| `MauiProgram.cs` | Application configuration and service registration |
| `DiveHubLogbook.csproj` | Target frameworks and package references |
| `global.json` | Pinned .NET SDK version |

## Platform Targets

The project configuration includes:

| Platform | Target Framework |
|---|---|
| Android | `net10.0-android` |
| Windows | `net10.0-windows10.0.19041.0` |
| iOS | `net10.0-ios` |
| Mac Catalyst | `net10.0-maccatalyst` |

Windows targeting is enabled on Windows hosts. iOS and Mac Catalyst targets are excluded on Linux hosts.

These are configured build targets; they do not establish that every platform has been tested. Each platform requires its corresponding development tools and workloads.

## Getting Started

### Requirements

- .NET SDK **10.0.300**, as specified in `global.json`
- Appropriate .NET MAUI workloads
- Android SDK and an emulator or physical device for Android development
- Windows development tools for the Windows target

### Clone the Repository

```bash
git clone https://github.com/hakanberat/DiveHub-Logbook-MAUI.git
cd DiveHub-Logbook-MAUI
```

### Restore Workloads and Dependencies

Run these commands from the project directory:

```bash
dotnet workload restore DiveHubLogbook.csproj
dotnet restore DiveHubLogbook.csproj
```

Workload restoration depends on the host operating system and may require additional platform tooling.

### Build for Android

```bash
dotnet build DiveHubLogbook.csproj -f net10.0-android -c Debug
```

### Run on Android

Start an Android emulator or connect a device with USB debugging enabled, then run:

```bash
dotnet build DiveHubLogbook.csproj -t:Run -f net10.0-android -c Debug
```

### Run on Windows

From a Windows development environment:

```powershell
dotnet build DiveHubLogbook.csproj -t:Run -f net10.0-windows10.0.19041.0 -c Debug
```

## Using the Application

1. Open **Add Dive** and enter the dive information.
2. Save the record to return to **Logbook**.
3. Select a dive to view its details.
4. Use the detail screen to edit or delete the record.
5. Use the search field to find entries by site, buddy or notes.
6. Open **Dashboard** to review the accumulated statistics.

## Current Scope

The current implementation focuses on manually entered dive records stored on a single device.

Cloud synchronization, account management, data export/import and dive computer integration are not implemented. No automated test project is included in this repository.

## Author

**Hakan Berat Demircan**

Software developer, PADI IDC Staff Instructor and former dive center co-owner.

This project combines my diving background with application development using C#, .NET MAUI, MVVM and SQLite.

[GitHub Profile](https://github.com/hakanberat)
