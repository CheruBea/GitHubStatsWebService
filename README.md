# GitHub Stats Web Service

Welcome to the GitHub Stats Web Service project! This project provides insights into GitHub repositories, allowing developers to quickly access detailed information about repository activity, contributions, and overall project health.

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Inspiration](#inspiration)
- [Technology Stack](#technology-stack)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Introduction

The GitHub Stats Web Service offers a user-friendly interface to search for GitHub repositories and gain insights into their activity and contributors. This project aims to help developers make informed decisions about which projects to contribute to or use as dependencies.

## Features

- **Repository Search**: Quickly search for GitHub repositories by name and get detailed information including stars, forks, and issues.
- **Commit History**: View the commit history of a repository to understand its development progress and activity.
- **Contributor Insights**: Analyze the contributors of a repository to see who has been contributing the most and understand team dynamics.

## Inspiration

This project was inspired by my passion for enhancing developer productivity and understanding project dynamics through GitHub repositories. Transparent and insightful data helps developers make informed decisions, whether it's choosing dependencies or contributing to projects.

## Technology Stack

- **Backend**: ASP.NET Core, C#
- **Frontend**: HTML, CSS, Bootstrap
- **Database**: SQL Server
- **API**: GitHub API
- **Deployment**: Heroku

## Installation

To set up this project locally, follow these steps:

1. **Clone the repository**:
    ```bash
    git clone https://github.com/CheruBea/GitHubStatsWebService.git
    cd GitHubStatsWebService
    ```

2. **Set up the database**:
   - Ensure SQL Server is installed and running.
   - Update the connection string in `appsettings.json` with your SQL Server details.

3. **Install dependencies**:
    ```bash
    dotnet restore
    ```

4. **Apply database migrations**:
    ```bash
    dotnet ef database update
    ```

5. **Run the application**:
    ```bash
    dotnet run
    ```

6. **Open the application**:
    Open your web browser and navigate to `http://localhost:5000`.

## Usage

- Navigate to the home page to explore the features of the GitHub Stats Web Service.
- Use the search functionality to find repositories by name.
- View the commit history and contributor insights of the repositories you are interested in.

## Contributing

Contributions are welcome! If you have any suggestions or improvements, please create an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Contact

Beatrice Cheruto

- [LinkedIn](https://www.linkedin.com/in/beatrice-cheruto-bc061096/)
- [GitHub](https://github.com/CheruBea/GitHubStatsWebService)
- [Twitter](https://x.com/Cheruubea)

Feel free to reach out if you have any questions or need further assistance!
