using GitHubStatsWebService.Application.DTOs;
using System.Threading.Tasks;

namespace GitHubStatsWebService.Application.Interfaces
{
    public interface IRepositoryService
    {
        Task<RepositoryDto> GetRepositoryAsync(string owner, string repoName);
    }
}
