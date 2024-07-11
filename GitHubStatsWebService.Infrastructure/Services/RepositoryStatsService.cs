using GitHubStatsWebService.Application.DTOs;
using GitHubStatsWebService.Application.Interfaces;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace GitHubStatsWebService.Infrastructure.Services
{
    public class RepositoryStatsService : IRepositoryStatsService
    {
        private readonly HttpClient _client;

        public RepositoryStatsService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<RepositoryStatsDto> GetRepositoryStatsAsync(string owner, string repoName)
        {
            // Fetch commits count
            HttpResponseMessage commitsResponse = await _client.GetAsync($"repos/{owner}/{repoName}/commits");
            commitsResponse.EnsureSuccessStatusCode();
            var commits = await JsonSerializer.DeserializeAsync<List<object>>(await commitsResponse.Content.ReadAsStreamAsync());

            // Fetch contributors count
            HttpResponseMessage contributorsResponse = await _client.GetAsync($"repos/{owner}/{repoName}/contributors");
            contributorsResponse.EnsureSuccessStatusCode();
            var contributors = await JsonSerializer.DeserializeAsync<List<object>>(await contributorsResponse.Content.ReadAsStreamAsync());

            // Fetch open issues count
            HttpResponseMessage issuesResponse = await _client.GetAsync($"repos/{owner}/{repoName}/issues?state=open");
            issuesResponse.EnsureSuccessStatusCode();
            var openIssues = await JsonSerializer.DeserializeAsync<List<object>>(await issuesResponse.Content.ReadAsStreamAsync());

            return new RepositoryStatsDto
            {
                Commits = commits.Count,
                Contributors = contributors.Count,
                OpenIssues = openIssues.Count
            };
        }
    }
}
