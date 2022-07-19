namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of UpdateProjectV2
    /// </summary>
    public class UpdateProjectV2Payload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The updated Project.
        /// </summary>
        public ProjectV2 ProjectV2 { get; set; }
    }
}