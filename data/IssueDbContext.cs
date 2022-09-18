using System;
using IssueTracking.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracking.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options) :base(options)
        {
        }


        public DbSet<Issue> Issues { get; set; }
    }
}

/* To run migrations
 * dotnet ef migrations add {createddatabase}
 * dotnet ef migrations add createddatabase -o Data/Migrations
 */