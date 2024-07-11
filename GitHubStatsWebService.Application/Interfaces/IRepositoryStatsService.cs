using GitHubStatsWebService.Application.DTOs;
using System.Threading.Tasks;

namespace GitHubStatsWebService.Application.Interfaces
{
    public interface IRepositoryStatsService
    {
        Task<RepositoryStatsDto> GetRepositoryStatsAsync(string owner, string repoName);
    }
}
