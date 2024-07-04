using GitHubStatsWebService.Application.Interfaces;
using GitHubStatsWebService.Infrastructure.Services;

namespace GitHubStatsWebService.Application.Services
{
    public class RepositoryService : IRepositoryService
    {
        private readonly HttpClient _client;

        public RepositoryService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<RepositoryDto> GetRepositoryAsync(string owner, string repoName)
        {
            // Example implementation (replace with actual logic to fetch data from GitHub API or database)
            // For demonstration, creating a mock RepositoryDto
            var repository = new RepositoryDto
            {
                Owner = owner,
                RepoName = repoName,
                Description = "Sample repository description",
                Stars = 100,
                Forks = 50
            };

            // Simulate asynchronous operation (replace with actual async logic)
            await Task.Delay(TimeSpan.FromSeconds(1)); // Simulate delay

            return repository;
        }

        Task<DTOs.RepositoryDto> IRepositoryService.GetRepositoryAsync(string owner, string repoName)
        {
            throw new NotImplementedException();
        }
    }
}
