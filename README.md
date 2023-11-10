# Test Results Analysis Tool

## Overview

This tool processes a JSON file containing results from executed test cases, converts the data into a CSV format, exports it to a specified location, and calculates various metrics based on the test results.

## Requirements

- .NET 6.0 SDK or compatible version installed on your machine.

## Installation

No installation is required. Simply build the project using the .NET CLI with the command `dotnet build`, and then run the produced executable.

## Usage

Execute the program in a command-line interface (CLI) after building like so:

```console
dotnet run
```

Follow the on-screen prompts to provide the input JSON file path and the output CSV file path. For instance:

```console
Please enter the full path to the JSON data file:
> C:\path\to\your\testResults.json
Please enter the full path for the CSV output file (including file name):
> C:\path\to\your\output.csv
```

To exit the application at any time, type `exit`.

## Input File Format

> **_NOTE:_** A sample .json file can be found in the Sample folder of the project.

The application expects a JSON file with an array of test case objects. Each test case should have the following structure:

```json
{
  "TestCaseName": "NameOfTheTest",
  "Status": "Pass/Fail",
  "ExecutionTime": 123, // Execution time in milliseconds
  "Timestamp": "YYYY-MM-DDTHH:MM:SSZ" // ISO 8601 format
}
```

Example:

```json
[
  {
    "TestCaseName": "LoginTest",
    "Status": "Pass",
    "ExecutionTime": 150,
    "Timestamp": "2023-11-08T09:00:00Z"
  },
  // ... more test cases
]
```

## Metrics Calculated

The tool calculates and displays the following metrics:

- Total number of test cases executed.
- Number of test cases passed.
- Number of test cases failed.
- Average execution time for all test cases.
- Minimum execution time among all test cases.
- Maximum execution time among all test cases.

## Troubleshooting

If you encounter any issues with file paths, ensure that the paths are correct and that the files exist at the specified locations.

## Support

For support, questions, or to report issues, please contact [Martin Sorani](mailto:martin.sorani@gmail.com).

## License

MIT License

Copyright (c) 2023 Martin Sorani

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
