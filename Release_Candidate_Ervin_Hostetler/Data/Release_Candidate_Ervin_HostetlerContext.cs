using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Release_Candidate_Ervin_Hostetler.Models;

namespace Release_Candidate_Ervin_Hostetler.Models
{
    public class Release_Candidate_Ervin_HostetlerContext : DbContext
    {
        public Release_Candidate_Ervin_HostetlerContext (DbContextOptions<Release_Candidate_Ervin_HostetlerContext> options)
            : base(options)
        {
        }

        public DbSet<Release_Candidate_Ervin_Hostetler.Models.Customer> Customer { get; set; }

        public DbSet<Release_Candidate_Ervin_Hostetler.Models.Labor> Labor { get; set; }

        public DbSet<Release_Candidate_Ervin_Hostetler.Models.Purchase> Purchase { get; set; }

        public DbSet<Release_Candidate_Ervin_Hostetler.Models.Quote> Quote { get; set; }

        public DbSet<Release_Candidate_Ervin_Hostetler.Models.Report> Report { get; set; }
    }
}
