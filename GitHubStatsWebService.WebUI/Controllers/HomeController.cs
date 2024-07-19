using Microsoft.AspNetCore.Mvc;

namespace GitHubStatsWebService.WebUI.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string repoDetails)
        {
            // Validate and extract owner and repo name from the input
            string owner, repoName;

            if (repoDetails.StartsWith("https://github.com/"))
            {
                // Extract owner and repo name from URL
                var parts = repoDetails.Replace("https://github.com/", "").Split('/');
                if (parts.Length >= 2)
                {
                    owner = parts[0];
                    repoName = parts[1];
                }
                else
                {
                    // Handle invalid input
                    ViewData["Error"] = "Invalid repository URL.";
                    return View("Index");
                }
            }
            else if (repoDetails.Contains("/"))
            {
                // Extract owner and repo name from owner/repo format
                var parts = repoDetails.Split('/');
                if (parts.Length >= 2)
                {
                    owner = parts[0];
                    repoName = parts[1];
                }
                else
                {
                    // Handle invalid input
                    ViewData["Error"] = "Invalid repository format.";
                    return View("Index");
                }
            }
            else
            {
                // Handle invalid input
                ViewData["Error"] = "Invalid repository format.";
                return View("Index");
            }

            // Redirect to RepositoryStatistics action with parameters
            return RedirectToAction("RepositoryStatistics", "Home", new { owner, repoName });
        }

        [HttpGet]
        public IActionResult RepositoryStatistics(string owner, string repoName)
        {
            ViewData["Owner"] = owner;
            ViewData["RepoName"] = repoName;
            return View();
        }
    }
}
