using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GitHubStatsWebService.Application.DTOs
{
    public class ContributorDto
    {
        [JsonProperty("login")]
        public string UserName { get; set; }

        [JsonProperty("contributions")]
        public int Contributions { get; set; }
    }
}
