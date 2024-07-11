namespace GitHubStatsWebService.Application.DTOs
{
    public class RepositoryStatsDto
    {
        public int Commits { get; set; }
        public int Contributors { get; set; }
        public int OpenIssues { get; set; }
    }
}
