
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant19
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant19ActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant19Action Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant19" /> class.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="alias"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant19(
            string projectName,
            string alias,
            global::Vercel.UserEventPayloadVariant19Action action)
        {
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant19" /> class.
        /// </summary>
        public UserEventPayloadVariant19()
        {
        }
    }
}