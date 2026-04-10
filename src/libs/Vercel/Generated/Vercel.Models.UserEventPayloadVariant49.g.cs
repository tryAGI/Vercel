
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant49
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
        [global::System.Text.Json.Serialization.JsonPropertyName("cn")]
        public string? Cn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cns")]
        public global::System.Collections.Generic.IList<string>? Cns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant49" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cn"></param>
        /// <param name="cns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant49(
            string id,
            string? cn,
            global::System.Collections.Generic.IList<string>? cns)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Cn = cn;
            this.Cns = cns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant49" /> class.
        /// </summary>
        public UserEventPayloadVariant49()
        {
        }
    }
}