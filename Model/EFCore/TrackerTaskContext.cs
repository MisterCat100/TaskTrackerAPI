using Microsoft.EntityFrameworkCore;
using TaskTrackerApi.Model.Entities;

namespace TaskTrackerApi.Model.EFCore;

public class TrackerTaskContext : DbContext
{
    public TrackerTaskContext(DbContextOptions<TrackerTaskContext> options)
        : base(options)
    {

    }

    public DbSet<TrackerTask> TrackerTasks { get; set; }
    public DbSet<User> Users { get; set; }
}
