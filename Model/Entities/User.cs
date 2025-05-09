﻿namespace TaskTrackerApi.Model.Entities;

public class User
{
    public Guid Id { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public List<TrackerTask> TrackerTasks = [];
}
