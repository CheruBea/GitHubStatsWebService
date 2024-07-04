using System.Threading.Tasks;
using GitHubStatsWebService.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GitHubStatsWebService.WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RepositoryController : ControllerBase
    {
        private readonly IRepositoryService _repositoryService;

        public RepositoryController(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }

        [HttpGet("{owner}/{repoName}")]
        public async Task<IActionResult> GetRepository(string owner, string repoName)
        {
            try
            {
                var repository = await _repositoryService.GetRepositoryAsync(owner, repoName);
                if (repository == null)
                {
                    return NotFound();
                }

                return Ok(repository);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
