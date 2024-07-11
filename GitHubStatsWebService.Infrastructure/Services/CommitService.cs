using GitHubStatsWebService.Application.DTOs;
using GitHubStatsWebService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace GitHubStatsWebService.Infrastructure.Services
{
    public class CommitService : ICommitService
    {
        private readonly HttpClient _client;

        public CommitService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<List<CommitDto>> GetCommitsAsync(string owner, string repoName)
        {
            HttpResponseMessage response = await _client.GetAsync($"repos/{owner}/{repoName}/commits");

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var commits = await JsonSerializer.DeserializeAsync<List<CommitDto>>(responseStream);
                return commits;
            }
            else
            {
                // Handle error cases, e.g., log or throw custom exception
                throw new HttpRequestException($"Failed to retrieve data: {response.StatusCode}");
            }
        }
    }
}
