# SystemMonitorCLI

SystemMonitorCLI is a command-line application for monitoring system processes and services. It allows you to list all running processes and services and provides detailed CPU and memory utilization metrics for a selected process.

## Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

## Features

- List all running processes with basic information.
- List all running services with basic information.
- Display detailed CPU and memory usage for a selected process.
- Simple console animation while gathering information.

## Prerequisites

- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)

## Installation

1. Clone the repository:

    ```sh
    git clone https://github.com/yourusername/SystemMonitorCLI.git
    cd SystemMonitorCLI
    ```

2. Open the solution file (`SystemMonitorCLI.sln`) in Visual Studio.

3. Build the project:
    - In Visual Studio, select **Build** > **Build Solution** from the menu.

## Usage

1. Run the application:
    - In Visual Studio, set `MyPlayGround` as the startup project.
    - Press `F5` to start debugging or `Ctrl+F5` to run without debugging.

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
