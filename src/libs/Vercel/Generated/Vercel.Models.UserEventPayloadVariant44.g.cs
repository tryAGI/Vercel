
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant44
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Cns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant44" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cns"></param>
        /// <param name="custom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant44(
            string id,
            global::System.Collections.Generic.IList<string> cns,
            bool custom)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Cns = cns ?? throw new global::System.ArgumentNullException(nameof(cns));
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant44" /> class.
        /// </summary>
        public UserEventPayloadVariant44()
        {
        }
    }
}