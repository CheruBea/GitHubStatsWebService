using GitHubStatsWebService.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitHubStatsWebService.Application.Interfaces
{
    public interface IIssueService
    {
        Task<List<IssueDto>> GetIssuesAsync(string owner, string repoName);
    }
}
