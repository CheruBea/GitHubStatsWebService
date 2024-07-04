using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubStatsWebService.Application.DTOs
{
    public class RepositoryDto
    {
        public string Owner { get; set; }
        public string RepoName { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }
        public int Forks { get; set; }
        // Add more properties as needed
    }
}

