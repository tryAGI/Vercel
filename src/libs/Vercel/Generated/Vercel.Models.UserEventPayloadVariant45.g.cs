
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant45
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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant45" /> class.
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="cns"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant45(
            string? cn,
            global::System.Collections.Generic.IList<string>? cns,
            string? id)
        {
            this.Cn = cn;
            this.Cns = cns;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant45" /> class.
        /// </summary>
        public UserEventPayloadVariant45()
        {
        }
    }
}