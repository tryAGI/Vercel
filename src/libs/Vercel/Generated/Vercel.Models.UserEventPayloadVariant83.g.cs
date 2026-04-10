
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant83
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customNameservers")]
        public global::System.Collections.Generic.IList<string>? CustomNameservers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevCustomNameservers")]
        public global::System.Collections.Generic.IList<string>? PrevCustomNameservers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant83" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="customNameservers"></param>
        /// <param name="prevCustomNameservers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant83(
            string domain,
            global::System.Collections.Generic.IList<string>? customNameservers,
            global::System.Collections.Generic.IList<string>? prevCustomNameservers)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.CustomNameservers = customNameservers;
            this.PrevCustomNameservers = prevCustomNameservers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant83" /> class.
        /// </summary>
        public UserEventPayloadVariant83()
        {
        }
    }
}