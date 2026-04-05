
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An object describing the reason why the team is being deleted.
    /// </summary>
    public sealed partial class DeleteTeamRequestReason
    {
        /// <summary>
        /// Idenitifier slug of the reason why the team is being deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Description of the reason why the team is being deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTeamRequestReason" /> class.
        /// </summary>
        /// <param name="slug">
        /// Idenitifier slug of the reason why the team is being deleted.
        /// </param>
        /// <param name="description">
        /// Description of the reason why the team is being deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTeamRequestReason(
            string slug,
            string description)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTeamRequestReason" /> class.
        /// </summary>
        public DeleteTeamRequestReason()
        {
        }
    }
}