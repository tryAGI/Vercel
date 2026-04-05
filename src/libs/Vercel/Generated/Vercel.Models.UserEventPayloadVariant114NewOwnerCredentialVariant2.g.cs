
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant114NewOwnerCredentialVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant114NewOwnerCredentialVariant2TypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant114NewOwnerCredentialVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerCredentialVariant2" /> class.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant114NewOwnerCredentialVariant2(
            string host,
            string id,
            global::Vercel.UserEventPayloadVariant114NewOwnerCredentialVariant2Type type)
        {
            this.Type = type;
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerCredentialVariant2" /> class.
        /// </summary>
        public UserEventPayloadVariant114NewOwnerCredentialVariant2()
        {
        }
    }
}