﻿namespace TaskTrackerApi.Model.Entities;

public class TrackerTask
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public DateTime startDate = DateTime.Now;
    public DateTime EndDate { get; set; }

    public int UserId { get; set; }
    public required User User { get; set; }
}
