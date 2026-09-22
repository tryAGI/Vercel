
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The access scopes granted to the token.
    /// </summary>
    public sealed partial class AuthTokenScopeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthTokenScopeVariant2OriginJsonConverter))]
        public global::Vercel.AuthTokenScopeVariant2Origin? Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthTokenScopeVariant2TypeJsonConverter))]
        public global::Vercel.AuthTokenScopeVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokenScopeVariant2" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="teamId"></param>
        /// <param name="expiresAt"></param>
        /// <param name="origin"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthTokenScopeVariant2(
            double createdAt,
            string teamId,
            double? expiresAt,
            global::Vercel.AuthTokenScopeVariant2Origin? origin,
            global::Vercel.AuthTokenScopeVariant2Type type)
        {
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Origin = origin;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokenScopeVariant2" /> class.
        /// </summary>
        public AuthTokenScopeVariant2()
        {
        }

    }
}