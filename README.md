@{
    ViewData["Title"] = "Home Page";
}

<style>
    body {
        font-family: Arial, sans-serif;
        margin: 0;
        padding: 0;
        background-color: #f4f4f4;
        text-align: center; /* Center align body content */
    }

    header {
        background-color: #333;
        color: #fff;
        padding: 20px 0;
        text-align: center; /* Center align header content */
    }

    .cover, #features, #about {
        text-align: center; /* Center align main sections */
    }

    nav {
        margin: 20px 0;
        text-align: center;
    }

        nav a {
            margin: 0 15px;
            color: #fff; /* Text color */
            text-decoration: none;
            font-size: 1.2em;
        }

    .cover {
        padding: 50px 20px;
        background: url('/images/cover.jpg') no-repeat center center;
        background-size: cover;
        display: flex;
        justify-content: center;
        align-items: center;
        height: 80vh; /* Adjust height for better appearance */
        color: #333; /* Text color */
    }

        .cover h1,
        .cover p {
            margin: 0;
        }

    .feature {
        margin: 20px 0;
        background-color: #f8f9fa; /* Feature background color */
        padding: 20px;
        border-radius: 10px;
    }

        .feature img {
            max-width: 100%;
            height: auto;
            border-radius: 5px;
        }

        .feature h3 {
            font-size: 2em;
            margin: 10px 0;
        }

        .feature p {
            font-size: 1.2em;
        }

    #about {
        padding: 20px;
        background-color: #fff; /* About section background color */
    }

        #about h2 {
            font-size: 2.5em;
        }

        #about p {
            font-size: 1.2em;
            line-height: 1.5em;
            margin: 20px 0;
        }

    footer {
        background-color: #333;
        color: #fff;
        text-align: center;
        padding: 10px 0;
        position: absolute;
        bottom: 0;
        width: 100%;
    }

        footer p {
            margin: 0;
        }
</style>

<header>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <div class="container">
            <a class="navbar-brand" href="#home">GitHub Stats Web Service</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse justify-content-end" id="navbarNav">
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="#home">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#features">Features</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#about">About</a>
                    </li>
                    <li class="nav-item">
                        <a class="btn btn-primary" href="https://your-deployed-project-url.com">Go to Application</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
</header>

<section id="home" class="cover">
    <div class="container">
        <h1 class="display-4">GitHub Stats Web Service</h1>
        <p class="lead">Get insights into GitHub repositories</p>
        <a class="btn btn-primary btn-lg" href="#features">Explore Features</a>
    </div>
</section>

<section id="features" class="my-5">
    <div class="container">
        <h2>Key Features</h2>
        <div class="row justify-content-center">
            <div class="col-md-4 feature">
                <img src="https://via.placeholder.com/300" class="img-fluid" alt="Repository Search Image">
                <h3>Repository Search</h3>
                <p>Quickly search for GitHub repositories by name and get detailed information including stars, forks, and issues.</p>
            </div>
            <div class="col-md-4 feature">
                <img src="https://via.placeholder.com/300" class="img-fluid" alt="Commit History Image">
                <h3>Commit History</h3>
                <p>View the commit history of a repository to understand its development progress and activity.</p>
            </div>
            <div class="col-md-4 feature">
                <img src="https://via.placeholder.com/300" class="img-fluid" alt="Contributor Insights Image">
                <h3>Contributor Insights</h3>
                <p>Analyze the contributors of a repository to see who has been contributing the most and understand team dynamics.</p>
            </div>
        </div>
    </div>
</section>

<section id="about" class="my-5 bg-light">
    <div class="container">
        <h2>About the Project</h2>
        <p>This project was inspired by my passion for enhancing developer productivity and understanding project dynamics through GitHub repositories. We believe that transparent and insightful data helps developers make informed decisions, whether it's choosing dependencies or contributing to projects.</p>
        <p>This project is a Portfolio Project for Holberton School, aimed at showcasing my skills in software development and data analysis.</p>
        <p>Learn more about the project and its development on my <a href="https://github.com/CheruBea/GitHubStatsWebService">GitHub repository</a>.</p>
        <div class="row justify-content-center">
            <div class="col-md-4">
                <h3>Beatrice Cheruto</h3>
                <ul class="list-unstyled">
                    <li><a href="https://www.linkedin.com/in/beatrice-cheruto-bc061096/">LinkedIn</a></li>
                    <li><a href="https://github.com/CheruBea/GitHubStatsWebService">GitHub</a></li>
                    <li><a href="https://x.com/Cheruubea">X</a></li>
                </ul>
            </div>
        </div>
    </div>
</section>

<footer>
    <div class="container">
        <p>&copy; 2024 GitHub Stats. All rights reserved.</p>
    </div>
</footer>
</html>
