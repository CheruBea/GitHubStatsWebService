namespace GitHubStatsWebService.Infrastructure.Services
{
    public class RepositoryDto
    {
        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public int Stars { get; internal set; }
        public int Forks { get; internal set; }
        public string Owner { get; internal set; }
        public string RepoName { get; internal set; }
    }
}