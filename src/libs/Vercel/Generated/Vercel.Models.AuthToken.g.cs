
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Authentication token metadata.
    /// </summary>
    public sealed partial class AuthToken
    {
        /// <summary>
        /// Timestamp (in milliseconds) of when the token was most recently used.<br/>
        /// Example: 1632816536002L
        /// </summary>
        /// <example>1632816536002L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ActiveAt { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the token was created.<br/>
        /// Example: 1632816536002L
        /// </summary>
        /// <example>1632816536002L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the token expires.<br/>
        /// Example: 1632816536002L
        /// </summary>
        /// <example>1632816536002L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        /// The unique identifier of the token.<br/>
        /// Example: 5d9f2ebd38ddca62e5d51e9c1704c72530bdc8bfdd41e782a6687c48399e8391
        /// </summary>
        /// <example>5d9f2ebd38ddca62e5d51e9c1704c72530bdc8bfdd41e782a6687c48399e8391</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the token was marked as leaked.<br/>
        /// Example: 1632816536002L
        /// </summary>
        /// <example>1632816536002L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("leakedAt")]
        public double? LeakedAt { get; set; }

        /// <summary>
        /// URL where the token was discovered as leaked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leakedUrl")]
        public string? LeakedUrl { get; set; }

        /// <summary>
        /// The human-readable name of the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The origin of how the token was created.<br/>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        public string? Origin { get; set; }

        /// <summary>
        /// The token's prefix, for identification purposes.<br/>
        /// Example: vcp_
        /// </summary>
        /// <example>vcp_</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the token was revoked.<br/>
        /// Example: 1632816536002L
        /// </summary>
        /// <example>1632816536002L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("revokedAt")]
        public double? RevokedAt { get; set; }

        /// <summary>
        /// The access scopes granted to the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AuthTokenScopeVariant1, global::Vercel.AuthTokenScopeVariant2>>? Scopes { get; set; }

        /// <summary>
        /// The last few characters of the token, for identification purposes.<br/>
        /// Example: abc123
        /// </summary>
        /// <example>abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// The type of the token.<br/>
        /// Example: oauth2-token
        /// </summary>
        /// <example>oauth2-token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthToken" /> class.
        /// </summary>
        /// <param name="activeAt">
        /// Timestamp (in milliseconds) of when the token was most recently used.<br/>
        /// Example: 1632816536002L
        /// </param>
        /// <param name="createdAt">
        /// Timestamp (in milliseconds) of when the token was created.<br/>
        /// Example: 1632816536002L
        /// </param>
        /// <param name="id">
        /// The unique identifier of the token.<br/>
        /// Example: 5d9f2ebd38ddca62e5d51e9c1704c72530bdc8bfdd41e782a6687c48399e8391
        /// </param>
        /// <param name="name">
        /// The human-readable name of the token.
        /// </param>
        /// <param name="type">
        /// The type of the token.<br/>
        /// Example: oauth2-token
        /// </param>
        /// <param name="expiresAt">
        /// Timestamp (in milliseconds) of when the token expires.<br/>
        /// Example: 1632816536002L
        /// </param>
        /// <param name="leakedAt">
        /// Timestamp (in milliseconds) of when the token was marked as leaked.<br/>
        /// Example: 1632816536002L
        /// </param>
        /// <param name="leakedUrl">
        /// URL where the token was discovered as leaked.
        /// </param>
        /// <param name="origin">
        /// The origin of how the token was created.<br/>
        /// Example: github
        /// </param>
        /// <param name="prefix">
        /// The token's prefix, for identification purposes.<br/>
        /// Example: vcp_
        /// </param>
        /// <param name="revokedAt">
        /// Timestamp (in milliseconds) of when the token was revoked.<br/>
        /// Example: 1632816536002L
        /// </param>
        /// <param name="scopes">
        /// The access scopes granted to the token.
        /// </param>
        /// <param name="suffix">
        /// The last few characters of the token, for identification purposes.<br/>
        /// Example: abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthToken(
            double activeAt,
            double createdAt,
            string id,
            string name,
            string type,
            double? expiresAt,
            double? leakedAt,
            string? leakedUrl,
            string? origin,
            string? prefix,
            double? revokedAt,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AuthTokenScopeVariant1, global::Vercel.AuthTokenScopeVariant2>>? scopes,
            string? suffix)
        {
            this.ActiveAt = activeAt;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LeakedAt = leakedAt;
            this.LeakedUrl = leakedUrl;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Origin = origin;
            this.Prefix = prefix;
            this.RevokedAt = revokedAt;
            this.Scopes = scopes;
            this.Suffix = suffix;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthToken" /> class.
        /// </summary>
        public AuthToken()
        {
        }

    }
}