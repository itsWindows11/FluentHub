namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of AddProjectCard
    /// </summary>
    public class AddProjectCardInput
    {
        /// <summary>
        /// The Node ID of the ProjectColumn.
        /// </summary>
        public ID ProjectColumnId { get; set; }

        /// <summary>
        /// The content of the card. Must be a member of the ProjectCardItem union
        /// </summary>
        public ID? ContentId { get; set; }

        /// <summary>
        /// The note on the card.
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}