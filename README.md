# CalculadoraContaminacionRios

## Overview
CalculadoraContaminacionRios is an ASP.NET Core web application designed to calculate river contamination levels using various numerical integration methods. The application provides a user-friendly interface for inputting data and visualizing results.

## Project Structure
The project is organized into several key directories:

- **Controllers**: Contains the controllers that handle HTTP requests and responses.
- **Models**: Defines the data structures used in the application.
- **Views**: Contains the Razor views for rendering the user interface.
- **Services**: Implements business logic and numerical integration methods.
- **Data**: Manages database connections and entity configurations.
- **wwwroot**: Contains static files such as CSS and JavaScript.
- **Tests**: Includes unit tests to ensure the functionality of the application.

## Features
- Input forms for entering concentration and velocity values.
- Selection of numerical integration methods (Trapezoidal and Simpson's).
- Calculation of contamination levels based on user input.
- Result visualization for better understanding of contamination data.

## Setup Instructions
1. Clone the repository:
   ```
   git clone <repository-url>
   ```
2. Navigate to the project directory:
   ```
   cd CalculadoraContaminacionRios
   ```
3. Restore the dependencies:
   ```
   dotnet restore
   ```
4. Run the application:
   ```
   dotnet run
   ```
5. Open your web browser and navigate to `http://localhost:5000` to access the application.

## Usage Guidelines
- Enter the required values in the input fields.
- Select the desired numerical integration method.
- Click the "Calcular" button to perform the calculation.
- View the results displayed on the screen.

## Contributing
Contributions are welcome! Please submit a pull request or open an issue for any enhancements or bug fixes.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.