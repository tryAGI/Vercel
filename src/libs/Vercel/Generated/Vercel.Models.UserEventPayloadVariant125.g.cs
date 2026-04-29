
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant125
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant125Integration Integration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originTeamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginTeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originTeamName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginTeamName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant125" /> class.
        /// </summary>
        /// <param name="integration"></param>
        /// <param name="originTeamId"></param>
        /// <param name="originTeamName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant125(
            global::Vercel.UserEventPayloadVariant125Integration integration,
            string originTeamId,
            string originTeamName)
        {
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
            this.OriginTeamId = originTeamId ?? throw new global::System.ArgumentNullException(nameof(originTeamId));
            this.OriginTeamName = originTeamName ?? throw new global::System.ArgumentNullException(nameof(originTeamName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant125" /> class.
        /// </summary>
        public UserEventPayloadVariant125()
        {
        }
    }
}