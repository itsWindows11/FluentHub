﻿namespace FluentHub.Octokit.Queries.Repositories
{
    public class ProjectQueries
    {
        public async Task<List<Project>> GetAllAsync(string owner, string name)
        {
            var query = new Query()
                .Repository(name, owner)
                .Projects(first: 30)
                .Nodes
                .Select(x => new Project
                {
                    Body = x.Body,
                    Closed = x.Closed,
                    Id = x.Id,
                    Name = x.Name,
                    Number = x.Number,
                    State = (ProjectState)x.State,
                    Url = x.Url,
                    ViewerCanUpdate = x.ViewerCanUpdate,

                    ClosedAt = x.ClosedAt,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt,

                    Progress = x.Progress.Select(y => new ProjectProgress
                    {
                        DoneCount = y.DoneCount,
                        DonePercentage = y.DonePercentage,
                        Enabled = y.Enabled,
                        InProgressCount = y.InProgressCount,
                        InProgressPercentage = y.InProgressPercentage,
                        TodoCount = y.TodoCount,
                        TodoPercentage = y.TodoPercentage,
                    })
                    .Single(),
                })
                .Compile();

            var response = await App.Connection.Run(query);

            return response.ToList();
        }

        public async Task<Project> GetAsync(string owner, string name, int number)
        {
            var query = new Query()
                .Repository(name, owner)
                .Project(number)
                .Select(x => new Project
                {
                    Body = x.Body,
                    Closed = x.Closed,
                    Id = x.Id,
                    Name = x.Name,
                    Number = x.Number,
                    State = (ProjectState)x.State,
                    Url = x.Url,
                    ViewerCanUpdate = x.ViewerCanUpdate,

                    ClosedAt = x.ClosedAt,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt,

                    Progress = x.Progress.Select(y => new ProjectProgress
                    {
                        DoneCount = y.DoneCount,
                        DonePercentage = y.DonePercentage,
                        Enabled = y.Enabled,
                        InProgressCount = y.InProgressCount,
                        InProgressPercentage = y.InProgressPercentage,
                        TodoCount = y.TodoCount,
                        TodoPercentage = y.TodoPercentage,
                    })
                    .Single(),
                })
                .Compile();

            var response = await App.Connection.Run(query);

            return response;
        }
    }
}
