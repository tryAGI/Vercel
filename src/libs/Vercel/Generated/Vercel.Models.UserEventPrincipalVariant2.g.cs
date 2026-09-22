
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metadata for {@link principalId}.
    /// </summary>
    public sealed partial class UserEventPrincipalVariant2
    {
        /// <summary>
        /// The OAuth 2.0 client ID, which may be a CIMD URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// The backing Vercel App ID. When absent, defaults to `clientId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPrincipalVariant2TypeJsonConverter))]
        public global::Vercel.UserEventPrincipalVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPrincipalVariant2" /> class.
        /// </summary>
        /// <param name="clientId">
        /// The OAuth 2.0 client ID, which may be a CIMD URL.
        /// </param>
        /// <param name="name"></param>
        /// <param name="id">
        /// The backing Vercel App ID. When absent, defaults to `clientId`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPrincipalVariant2(
            string clientId,
            string name,
            string? id,
            global::Vercel.UserEventPrincipalVariant2Type type)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPrincipalVariant2" /> class.
        /// </summary>
        public UserEventPrincipalVariant2()
        {
        }

    }
}