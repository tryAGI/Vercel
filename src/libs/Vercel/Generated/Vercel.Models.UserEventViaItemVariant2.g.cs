
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metadata for {@link viaIds}.
    /// </summary>
    public sealed partial class UserEventViaItemVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventViaItemVariant2TypeJsonConverter))]
        public global::Vercel.UserEventViaItemVariant2Type Type { get; set; }

        /// <summary>
        /// The backing Vercel App ID. When absent, defaults to `clientId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The OAuth 2.0 client ID, which may be a CIMD URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventViaItemVariant2" /> class.
        /// </summary>
        /// <param name="clientId">
        /// The OAuth 2.0 client ID, which may be a CIMD URL.
        /// </param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="id">
        /// The backing Vercel App ID. When absent, defaults to `clientId`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventViaItemVariant2(
            string clientId,
            string name,
            global::Vercel.UserEventViaItemVariant2Type type,
            string? id)
        {
            this.Type = type;
            this.Id = id;
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventViaItemVariant2" /> class.
        /// </summary>
        public UserEventViaItemVariant2()
        {
        }

    }
}