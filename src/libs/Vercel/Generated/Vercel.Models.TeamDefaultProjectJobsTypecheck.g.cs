
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default job configuration applied to new projects created in this team.
    /// </summary>
    public sealed partial class TeamDefaultProjectJobsTypecheck
    {
        /// <summary>
        /// Default job configuration applied to new projects created in this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDefaultProjectJobsTypecheck" /> class.
        /// </summary>
        /// <param name="targets">
        /// Default job configuration applied to new projects created in this team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamDefaultProjectJobsTypecheck(
            global::System.Collections.Generic.IList<string> targets)
        {
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDefaultProjectJobsTypecheck" /> class.
        /// </summary>
        public TeamDefaultProjectJobsTypecheck()
        {
        }
    }
}