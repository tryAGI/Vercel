
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant43
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cn")]
        public string? Cn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cns")]
        public global::System.Collections.Generic.IList<string>? Cns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Custom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant43" /> class.
        /// </summary>
        /// <param name="custom"></param>
        /// <param name="cn"></param>
        /// <param name="cns"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant43(
            bool custom,
            string? cn,
            global::System.Collections.Generic.IList<string>? cns,
            string? id)
        {
            this.Cn = cn;
            this.Cns = cns;
            this.Custom = custom;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant43" /> class.
        /// </summary>
        public UserEventPayloadVariant43()
        {
        }
    }
}