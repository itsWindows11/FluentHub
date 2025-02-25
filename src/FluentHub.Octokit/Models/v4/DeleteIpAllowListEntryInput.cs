namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of DeleteIpAllowListEntry
    /// </summary>
    public class DeleteIpAllowListEntryInput
    {
        /// <summary>
        /// The ID of the IP allow list entry to delete.
        /// </summary>
        public ID IpAllowListEntryId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}