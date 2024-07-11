using GitHubStatsWebService.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitHubStatsWebService.Application.Interfaces
{
    public interface IContributorService
    {
        Task<List<ContributorDto>> GetContributorsAsync(string owner, string repoName);
    }
}
