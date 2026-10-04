# DiveHub Logbook

**Developed: 2026**

A modern cross-platform scuba diving logbook application built with **.NET 10, .NET MAUI, MVVM, and SQLite**.

The application allows divers to store, manage, search, and review their dive history locally on the device. It also provides dashboard statistics such as total dives, maximum depth, total bottom time, and the most recent dive.

This project represents a modern continuation of the digital logbook concept originally included in the legacy Dive Hub Android application.

## Features

- Add new dive records
- View all recorded dives
- Search dive records
- View detailed dive information
- Edit existing dives
- Delete dives
- Local offline data storage
- Dashboard statistics
- Cross-platform .NET MAUI architecture

## Dashboard

The dashboard provides an overview of diving activity, including:

- Total number of dives
- Maximum recorded depth
- Total accumulated bottom time
- Most recent dive site
- Most recent dive date

## Dive Information

Each dive record can store:

- Dive number
- Dive date
- Dive site
- Maximum depth
- Bottom time
- Water temperature
- Exposure suit type
- Suit length
- Suit thickness
- Weight
- Dive buddy
- Notes

## Search

Dive records can be searched using information such as:

- Dive site
- Dive buddy
- Notes

## Technology Stack

- C#
- .NET 10
- .NET MAUI
- XAML
- MVVM
- CommunityToolkit.Mvvm
- SQLite
- sqlite-net-pcl
- Dependency Injection
- Async/Await
- LINQ

## Architecture

The application follows an MVVM-based structure:

.NET MAUI Application
        |
        |-- Views
        |
        |-- ViewModels
        |
        |-- Models
        |
        |-- Data Layer
        |
        `-- SQLite Database

The user interface is implemented with XAML, while application logic is separated into ViewModels and data persistence is handled locally with SQLite.

## Project Structure

- `Views/` — Application screens
- `ViewModels/` — Presentation and application logic
- `Models/` — Dive data models
- `Data/` — SQLite database access
- `Resources/` — Images, icons, fonts, and application assets
- `Platforms/` — Platform-specific configuration

## Platforms

The project is configured for:

- Android
- Windows
- iOS
- Mac Catalyst

Primary development and testing has focused on Android and Windows.

## Offline-First Design

Dive data is stored locally using SQLite.

The application does not require a remote server or internet connection for normal logbook operations, making it suitable for use in diving environments where network access may be limited.

## Project Status

This project is actively developed as a portfolio application and as a modern implementation of a digital scuba diving logbook.

Current core functionality includes complete dive record CRUD operations, search, detailed dive views, and dashboard statistics.

## Background

Dive Hub previously had a native Java Android application that included an early digital dive logbook.

This project revisits that idea using a modern .NET stack and a cleaner application architecture.

Legacy architecture:

Java Android App
        |
        `-- SQLite Logbook

Modern architecture:

.NET MAUI
    |
    |-- MVVM
    |
    |-- Dependency Injection
    |
    `-- SQLite

## Author

**Hakan Berat Demircan**
