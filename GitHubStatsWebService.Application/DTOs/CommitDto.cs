using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubStatsWebService.Application.DTOs
{
    public class CommitDto
    {
        public required string Author { get; set; }
        public required string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
