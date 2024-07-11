using GitHubStatsWebService.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitHubStatsWebService.Application.Interfaces
{
    public interface ICommitService
    {
        Task<List<CommitDto>> GetCommitsAsync(string owner, string repoName);
    }
}
