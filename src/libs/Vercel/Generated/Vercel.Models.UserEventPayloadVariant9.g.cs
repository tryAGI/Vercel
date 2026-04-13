
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessGroup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant9AccessGroup AccessGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant9Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant9NextRoleJsonConverter))]
        public global::Vercel.UserEventPayloadVariant9NextRole? NextRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant9PreviousRoleJsonConverter))]
        public global::Vercel.UserEventPayloadVariant9PreviousRole? PreviousRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant9" /> class.
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="project"></param>
        /// <param name="nextRole"></param>
        /// <param name="previousRole"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant9(
            global::Vercel.UserEventPayloadVariant9AccessGroup accessGroup,
            global::Vercel.UserEventPayloadVariant9Project project,
            global::Vercel.UserEventPayloadVariant9NextRole? nextRole,
            global::Vercel.UserEventPayloadVariant9PreviousRole? previousRole)
        {
            this.AccessGroup = accessGroup ?? throw new global::System.ArgumentNullException(nameof(accessGroup));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.NextRole = nextRole;
            this.PreviousRole = previousRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant9" /> class.
        /// </summary>
        public UserEventPayloadVariant9()
        {
        }
    }
}