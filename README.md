# My .NET Core Web Application

This is a simple .NET Core web application that demonstrates the use of MVC architecture. 

## Project Structure

- **Controllers**: Contains the controllers that handle user requests.
  - `HomeController.cs`: Manages the home page and its related actions.
  
- **Models**: Contains the data models used in the application.
  - `ExampleModel.cs`: Represents the data structure for the application.

- **Views**: Contains the Razor views for rendering HTML.
  - **Home**: Contains views related to the Home controller.
    - `Index.cshtml`: The main view for the home page.
  - **Shared**: Contains shared layout views.
    - `_Layout.cshtml`: The layout for the application.

- **wwwroot**: Contains static files such as CSS, JavaScript, and images.
  - **css**: Contains CSS files.
    - `site.css`: The main stylesheet for the application.

- **Configuration Files**:
  - `appsettings.json`: Configuration settings for the application.
  - `Program.cs`: The entry point of the application.
  - `Startup.cs`: Configures services and the request pipeline.

## Getting Started

1. Clone the repository or download the project files.
2. Open the project in your preferred code editor.
3. Restore the dependencies by running:
   ```
   dotnet restore
   ```
4. Run the application locally using:
   ```
   dotnet run
   ```
5. Navigate to `http://localhost:5000` in your web browser to view the application.

## Deployment

To deploy the application to Azure App Service, use the Azure App Service extension in your code editor. Follow the prompts to create a new App Service and deploy your application.

## License

This project is licensed under the MIT License.