
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant89
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DestinationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DestinationName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant89" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="destinationId"></param>
        /// <param name="destinationName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant89(
            string name,
            string destinationId,
            string destinationName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DestinationId = destinationId ?? throw new global::System.ArgumentNullException(nameof(destinationId));
            this.DestinationName = destinationName ?? throw new global::System.ArgumentNullException(nameof(destinationName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant89" /> class.
        /// </summary>
        public UserEventPayloadVariant89()
        {
        }
    }
}