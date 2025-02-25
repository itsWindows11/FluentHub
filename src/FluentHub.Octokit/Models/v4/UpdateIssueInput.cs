namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UpdateIssue
    /// </summary>
    public class UpdateIssueInput
    {
        /// <summary>
        /// The ID of the Issue to modify.
        /// </summary>
        public ID Id { get; set; }

        /// <summary>
        /// The title for the issue.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The body for the issue description.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// An array of Node IDs of users for this issue.
        /// </summary>
        public List<ID> AssigneeIds { get; set; }

        /// <summary>
        /// The Node ID of the milestone for this issue.
        /// </summary>
        public ID? MilestoneId { get; set; }

        /// <summary>
        /// An array of Node IDs of labels for this issue.
        /// </summary>
        public List<ID> LabelIds { get; set; }

        /// <summary>
        /// The desired issue state.
        /// </summary>
        public IssueState? State { get; set; }

        /// <summary>
        /// An array of Node IDs for projects associated with this issue.
        /// </summary>
        public List<ID> ProjectIds { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}