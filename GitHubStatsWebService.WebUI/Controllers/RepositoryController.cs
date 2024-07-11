using GitHubStatsWebService.Application.DTOs;
using GitHubStatsWebService.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitHubStatsWebService.WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RepositoryController : ControllerBase
    {
        private readonly IRepositoryStatsService _repositoryStatsService;
        private readonly ICommitService _commitService;
        private readonly IContributorService _contributorService;
        private readonly IIssueService _issueService;

        public RepositoryController(
            IRepositoryStatsService repositoryStatsService,
            ICommitService commitService,
            IContributorService contributorService,
            IIssueService issueService)
        {
            _repositoryStatsService = repositoryStatsService;
            _commitService = commitService;
            _contributorService = contributorService;
            _issueService = issueService;
        }

        // API endpoint to retrieve repository statistics
        [HttpGet("{owner}/{repoName}")]
        public async Task<IActionResult> GetRepositoryStats(string owner, string repoName)
        {
            try
            {
                var stats = await _repositoryStatsService.GetRepositoryStatsAsync(owner, repoName);
                return Ok(stats); // Return JSON object containing repository stats
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate error response
                return BadRequest(new { message = ex.Message });
            }
        }

        // API endpoint to refresh repository statistics
        [HttpPost("{owner}/{repoName}/refresh")]
        public async Task<IActionResult> RefreshRepositoryStats(string owner, string repoName)
        {
            try
            {
                var stats = await _repositoryStatsService.GetRepositoryStatsAsync(owner, repoName);
                // Optionally update the cache if caching is implemented
                return Ok(new { message = "Repository statistics refreshed successfully." });
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate error response
                return BadRequest(new { message = ex.Message });
            }
        }

        // API endpoint to retrieve repository contributors
        [HttpGet("{owner}/{repoName}/contributors")]
        public async Task<IActionResult> GetContributors(string owner, string repoName)
        {
            try
            {
                var contributors = await _contributorService.GetContributorsAsync(owner, repoName);
                return Ok(contributors); // Return JSON array containing contributors
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate error response
                return BadRequest(new { message = ex.Message });
            }
        }

        // Additional endpoint to provide repository statistics for third-party clients
        [HttpGet("{owner}/{repoName}/statistics")]
        public async Task<IActionResult> GetRepositoryStatistics(string owner, string repoName)
        {
            try
            {
                var stats = await _repositoryStatsService.GetRepositoryStatsAsync(owner, repoName);
                return Ok(stats); // Return JSON object containing repository statistics
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate error response
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
