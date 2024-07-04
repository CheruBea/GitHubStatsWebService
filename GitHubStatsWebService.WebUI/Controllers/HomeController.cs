using GitHubStatsWebService.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GitHubStatsWebService.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositoryService _repositoryService;

        public HomeController(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Example action using IRepositoryService
        public async Task<IActionResult> GetRepository(string owner, string repo)
        {
            var repository = await _repositoryService.GetRepositoryAsync(owner, repo);
            return View(repository);
        }
    }
}
