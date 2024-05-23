# ConsoleSysMonitor

ConsoleSysMonitor is a command-line application for monitoring system processes and services. It allows you to list all running processes and services and provides detailed CPU and memory utilization metrics for a selected process.

## Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Features

- List all running processes with basic information.
- List all running services with basic information.
- Display detailed CPU and memory usage for a selected process.
- Simple console animation while gathering information.

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 3.1 or later)

## Installation

1. Clone the repository:

    ```sh
    git clone https://github.com/yourusername/SystemMonitorCLI.git
    cd ConsoleSysMonitor
    ```

2. Build the project:

    ```sh
    dotnet build
    ```

## Usage

1. Run the application:

    ```sh
    dotnet run --project MyPlayGround
    ```

2. The application will display all running processes and services.

3. Enter the process ID to get detailed CPU and memory usage for the selected process.

## Project Structure

```plaintext
SystemMonitorCLI/
│
├── MyPlayGround/
│   ├── Interfaces/
│   │   └── IPerformanceMetricsDisplay.cs
│   ├── Models/
│   │   ├── MyProcess.cs
│   │   ├── PerformanceMetrics.cs
│   │   └── MyService.cs
│   ├── Program.cs
│   └── ConsoleAnimation.cs
│
├── SystemMonitorCLI.sln
└── README.md
