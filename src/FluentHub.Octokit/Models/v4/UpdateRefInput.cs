namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UpdateRef
    /// </summary>
    public class UpdateRefInput
    {
        /// <summary>
        /// The Node ID of the Ref to be updated.
        /// </summary>
        public ID RefId { get; set; }

        /// <summary>
        /// The GitObjectID that the Ref shall be updated to target.
        /// </summary>
        public string Oid { get; set; }

        /// <summary>
        /// Permit updates of branch Refs that are not fast-forwards?
        /// </summary>
        public bool? Force { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}