namespace GitHubStatsWebService.Domain.Entities
{
    public class Repository
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }
        public int Forks { get; set; }
    }
}
