
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Incrementally update project linking without specifying the full list
    /// </summary>
    public sealed partial class UpdateSharedEnvVariableRequestUpdatesProjectIdUpdates
    {
        /// <summary>
        /// Project IDs to add to this environment variable<br/>
        /// Example: [prj_2WjyKQmM8ZnGcJsPWMrHRHrE]
        /// </summary>
        /// <example>[prj_2WjyKQmM8ZnGcJsPWMrHRHrE]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public global::System.Collections.Generic.IList<string>? Link { get; set; }

        /// <summary>
        /// Project IDs to remove from this environment variable<br/>
        /// Example: [prj_2WjyKQmM8ZnGcJsPWMrHRCRV]
        /// </summary>
        /// <example>[prj_2WjyKQmM8ZnGcJsPWMrHRCRV]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unlink")]
        public global::System.Collections.Generic.IList<string>? Unlink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSharedEnvVariableRequestUpdatesProjectIdUpdates" /> class.
        /// </summary>
        /// <param name="link">
        /// Project IDs to add to this environment variable<br/>
        /// Example: [prj_2WjyKQmM8ZnGcJsPWMrHRHrE]
        /// </param>
        /// <param name="unlink">
        /// Project IDs to remove from this environment variable<br/>
        /// Example: [prj_2WjyKQmM8ZnGcJsPWMrHRCRV]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSharedEnvVariableRequestUpdatesProjectIdUpdates(
            global::System.Collections.Generic.IList<string>? link,
            global::System.Collections.Generic.IList<string>? unlink)
        {
            this.Link = link;
            this.Unlink = unlink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSharedEnvVariableRequestUpdatesProjectIdUpdates" /> class.
        /// </summary>
        public UpdateSharedEnvVariableRequestUpdatesProjectIdUpdates()
        {
        }
    }
}