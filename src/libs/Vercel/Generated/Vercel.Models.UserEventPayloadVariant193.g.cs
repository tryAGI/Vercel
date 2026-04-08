
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant193
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionsAllowlist")]
        public global::Vercel.UserEventPayloadVariant193OptionsAllowlist? OptionsAllowlist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldOptionsAllowlist")]
        public global::Vercel.UserEventPayloadVariant193OldOptionsAllowlist? OldOptionsAllowlist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant193" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="optionsAllowlist"></param>
        /// <param name="oldOptionsAllowlist"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant193(
            string projectId,
            string projectName,
            global::Vercel.UserEventPayloadVariant193OptionsAllowlist? optionsAllowlist,
            global::Vercel.UserEventPayloadVariant193OldOptionsAllowlist? oldOptionsAllowlist)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.OptionsAllowlist = optionsAllowlist;
            this.OldOptionsAllowlist = oldOptionsAllowlist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant193" /> class.
        /// </summary>
        public UserEventPayloadVariant193()
        {
        }
    }
}