namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UpdatePullRequestReview
    /// </summary>
    public class UpdatePullRequestReviewInput
    {
        /// <summary>
        /// The Node ID of the pull request review to modify.
        /// </summary>
        public ID PullRequestReviewId { get; set; }

        /// <summary>
        /// The contents of the pull request review body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}