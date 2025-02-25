﻿namespace FluentHub.Octokit.Queries.Repositories
{
    public class ReleaseQueries
    {
        public async Task<List<Release>> GetAllAsync(string owner, string name)
        {
            OctokitGraphQLCore.Arg<OctokitGraphQLModel.ReleaseOrder> releaseOrder =
                new(new OctokitGraphQLModel.ReleaseOrder
                {
                    Direction = OctokitGraphQLModel.OrderDirection.Desc}
                );

            var query = new Query()
                .Repository(name, owner)
                .Releases(null, null, 20, null, releaseOrder)
                .Nodes
                .Select(x => new Release
                {
                    Author = x.Author.Select(author => new User
                    {
                        Login = author.Login,
                        AvatarUrl = author.AvatarUrl(100),
                    })
                    .Single(),

                    DescriptionHTML = x.DescriptionHTML,
                    IsDraft = x.IsDraft,
                    IsLatest = x.IsLatest,
                    IsPrerelease = x.IsPrerelease,
                    Name = x.Name,
                    PublishedAt = x.PublishedAt,
                })
                .Compile();

            var response = await App.Connection.Run(query);

            return response.ToList();
        }
    }
}
