
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant85
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
        [global::System.Text.Json.Serialization.JsonPropertyName("fromId")]
        public string? FromId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromName")]
        public string? FromName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant85" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fromId"></param>
        /// <param name="fromName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant85(
            string name,
            string? fromId,
            string? fromName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FromId = fromId;
            this.FromName = fromName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant85" /> class.
        /// </summary>
        public UserEventPayloadVariant85()
        {
        }
    }
}