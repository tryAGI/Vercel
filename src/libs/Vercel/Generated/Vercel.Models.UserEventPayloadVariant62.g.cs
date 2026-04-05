
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant62
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Suffix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant62" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="suffix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant62(
            string status,
            string suffix)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Suffix = suffix ?? throw new global::System.ArgumentNullException(nameof(suffix));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant62" /> class.
        /// </summary>
        public UserEventPayloadVariant62()
        {
        }
    }
}