
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant180
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldProjectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OldProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldProjectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OldProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newProjectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newProjectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant180" /> class.
        /// </summary>
        /// <param name="oldProjectId"></param>
        /// <param name="oldProjectName"></param>
        /// <param name="newProjectId"></param>
        /// <param name="newProjectName"></param>
        /// <param name="domain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant180(
            string oldProjectId,
            string oldProjectName,
            string newProjectId,
            string newProjectName,
            string domain)
        {
            this.OldProjectId = oldProjectId ?? throw new global::System.ArgumentNullException(nameof(oldProjectId));
            this.OldProjectName = oldProjectName ?? throw new global::System.ArgumentNullException(nameof(oldProjectName));
            this.NewProjectId = newProjectId ?? throw new global::System.ArgumentNullException(nameof(newProjectId));
            this.NewProjectName = newProjectName ?? throw new global::System.ArgumentNullException(nameof(newProjectName));
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant180" /> class.
        /// </summary>
        public UserEventPayloadVariant180()
        {
        }
    }
}