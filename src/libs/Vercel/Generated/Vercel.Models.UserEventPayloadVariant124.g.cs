
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant124
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant124Integration Integration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationTeamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DestinationTeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationTeamName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DestinationTeamName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant124" /> class.
        /// </summary>
        /// <param name="integration"></param>
        /// <param name="destinationTeamId"></param>
        /// <param name="destinationTeamName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant124(
            global::Vercel.UserEventPayloadVariant124Integration integration,
            string destinationTeamId,
            string destinationTeamName)
        {
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
            this.DestinationTeamId = destinationTeamId ?? throw new global::System.ArgumentNullException(nameof(destinationTeamId));
            this.DestinationTeamName = destinationTeamName ?? throw new global::System.ArgumentNullException(nameof(destinationTeamName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant124" /> class.
        /// </summary>
        public UserEventPayloadVariant124()
        {
        }
    }
}