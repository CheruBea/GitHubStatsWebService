using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubStatsWebService.Application.DTOs
{
    public class IssueDto
    {
        public int Number { get; set; }
        public required string Title { get; set; }
        public required string State { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ClosedAt { get; set; }
    }
}
