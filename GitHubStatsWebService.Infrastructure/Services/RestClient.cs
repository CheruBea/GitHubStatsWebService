
namespace GitHubStatsWebService.Application.Services
{
    internal class RestClient
    {
        private string v;

        public RestClient(string v)
        {
            this.v = v;
        }

        internal async Task ExecuteAsync<T>(RestRequest request)
        {
            throw new NotImplementedException();
        }
    }
}