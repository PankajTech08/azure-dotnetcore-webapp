# Azure Functions Project

This project contains three Azure Functions: an HTTP Trigger, a Timer Trigger, and an Event Hub Trigger. Each function is designed to demonstrate different capabilities of Azure Functions.

## Project Structure

```
azure-functions-app
├── HttpTrigger
│   ├── function.json
│   └── index.js
├── TimerTrigger
│   ├── function.json
│   └── index.js
├── EventHubTrigger
│   ├── function.json
│   └── index.js
├── host.json
├── local.settings.json
└── README.md
```

## Function Descriptions

### HttpTrigger
- **function.json**: Configures the HTTP trigger function, specifying the trigger type and route.
- **index.js**: Exports a function that handles incoming HTTP requests and sends responses.

### TimerTrigger
- **function.json**: Configures the Timer trigger function, specifying the schedule for execution.
- **index.js**: Exports a function that runs on a specified schedule, executing the defined logic.

### EventHubTrigger
- **function.json**: Configures the Event Hub trigger function, specifying connection and event hub details.
- **index.js**: Exports a function that processes events from an Azure Event Hub.

## Configuration Files

- **host.json**: Contains global configuration options for all functions, such as logging and timeout settings.
- **local.settings.json**: Used for local development settings, including connection strings and application settings.

## Setup Instructions

1. Clone the repository to your local machine.
2. Navigate to the project directory.
3. Install the necessary dependencies.
4. Run the functions locally using the Azure Functions Core Tools.

## Usage

- The HTTP Trigger can be accessed via the specified route.
- The Timer Trigger will execute based on the defined schedule.
- The Event Hub Trigger will process events as they arrive in the specified Event Hub.

## License

This project is licensed under the MIT License.