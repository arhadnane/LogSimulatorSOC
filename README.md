# LogSimulatorSOC

LogSimulatorSOC is a log generation simulation application for a Security Operations Center (SOC). It uses Serilog to generate and record various types of security logs.

## Prerequisites

- .NET 9
- Visual Studio 2022

## Installation

1. Clone the repository: `git clone https://github.com/your-username/LogSimulatorSOC.git`

2. Open the solution in Visual Studio 2022.

3. Ensure the following NuGet packages are installed:
    - `Serilog`
    - `Serilog.Sinks.Console`
    - `Serilog.Sinks.File`
    - `xUnit` (for unit tests)

    You can install these packages via the NuGet Package Manager Console:
        - `Install-Package Serilog`
        - `Install-Package Serilog.Sinks.Console`
        - `Install-Package Serilog.Sinks.File`
        - `Install-Package xUnit`

## Usage

1. Run the `LogSimulatorSOC` project to start log generation: `dotnet run --project LogSimulatorSOC`

2. The application will start generating logs and will record them in the console and in a file located at `logs/simulator.log`.

3. To stop the application, press `Ctrl + C`.

## Project Structure

- `LogSimulatorSOC/LogSimulatorSOC.cs`: Contains the main logic for log generation.
- `LogSimulatorSOC.Tests/LogSimulatorSOCTest.cs`: Contains unit tests for the log generation methods.

## Tests

To run the unit tests, use the following command: `dotnet test`

## Log Generation Methods

The application generates different types of security logs:

- `GenerateNormalSystemLog`: Generates a log indicating the successful start of a system process.
- `GenerateNormalNetworkLog`: Generates a log indicating the establishment of a network connection.
- `GenerateBruteForceAttemptLog`: Generates a log indicating a brute force login attempt.
- `GeneratePortScanLog`: Generates a log indicating a port scan detection.
- `GenerateFraudulentSSHConnectionLog`: Generates a log indicating an unauthorized SSH connection attempt.
## Contributing

Contributions are welcome! Please submit a pull request or open an issue to discuss the changes you wish to make.

## License

This project is licensed under the MIT License: https://opensource.org/license/mit

