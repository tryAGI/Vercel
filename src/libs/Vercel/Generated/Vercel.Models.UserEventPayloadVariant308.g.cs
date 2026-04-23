
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant308
    {
        /// <summary>
        /// The token's public ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenId { get; set; }

        /// <summary>
        /// User-supplied name of the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenName { get; set; }

        /// <summary>
        /// How the token was issued. Always `'manual'` for explicit PAT creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant308OriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant308Origin Origin { get; set; }

        /// <summary>
        /// Scope of the token: - `'user'`: full-account token (not tied to any team). - `'team'`: scoped to a single team. - `'project'`: scoped to a single project within a team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant308ScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant308Scope Scope { get; set; }

        /// <summary>
        /// Present when `scope` is `'team'` or `'project'`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Present when `scope` is `'team'` or `'project'`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamSlug")]
        public string? TeamSlug { get; set; }

        /// <summary>
        /// Present when `scope` is `'project'`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Unix epoch milliseconds. Absent when the token never expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        /// Whether the token was issued with RFC 9396 authorization details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasAuthorizationDetails")]
        public bool? HasAuthorizationDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geolocation")]
        public global::Vercel.UserEventPayloadVariant308Geolocation? Geolocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAgent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reqId")]
        public string? ReqId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reqUrl")]
        public string? ReqUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant308" /> class.
        /// </summary>
        /// <param name="tokenId">
        /// The token's public ID.
        /// </param>
        /// <param name="tokenName">
        /// User-supplied name of the token.
        /// </param>
        /// <param name="origin">
        /// How the token was issued. Always `'manual'` for explicit PAT creation.
        /// </param>
        /// <param name="scope">
        /// Scope of the token: - `'user'`: full-account token (not tied to any team). - `'team'`: scoped to a single team. - `'project'`: scoped to a single project within a team.
        /// </param>
        /// <param name="teamId">
        /// Present when `scope` is `'team'` or `'project'`.
        /// </param>
        /// <param name="teamSlug">
        /// Present when `scope` is `'team'` or `'project'`.
        /// </param>
        /// <param name="projectId">
        /// Present when `scope` is `'project'`.
        /// </param>
        /// <param name="expiresAt">
        /// Unix epoch milliseconds. Absent when the token never expires.
        /// </param>
        /// <param name="hasAuthorizationDetails">
        /// Whether the token was issued with RFC 9396 authorization details.
        /// </param>
        /// <param name="ip"></param>
        /// <param name="geolocation"></param>
        /// <param name="userAgent"></param>
        /// <param name="reqId"></param>
        /// <param name="reqUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant308(
            string tokenId,
            string tokenName,
            global::Vercel.UserEventPayloadVariant308Origin origin,
            global::Vercel.UserEventPayloadVariant308Scope scope,
            string? teamId,
            string? teamSlug,
            string? projectId,
            double? expiresAt,
            bool? hasAuthorizationDetails,
            string? ip,
            global::Vercel.UserEventPayloadVariant308Geolocation? geolocation,
            string? userAgent,
            string? reqId,
            string? reqUrl)
        {
            this.TokenId = tokenId ?? throw new global::System.ArgumentNullException(nameof(tokenId));
            this.TokenName = tokenName ?? throw new global::System.ArgumentNullException(nameof(tokenName));
            this.Origin = origin;
            this.Scope = scope;
            this.TeamId = teamId;
            this.TeamSlug = teamSlug;
            this.ProjectId = projectId;
            this.ExpiresAt = expiresAt;
            this.HasAuthorizationDetails = hasAuthorizationDetails;
            this.Ip = ip;
            this.Geolocation = geolocation;
            this.UserAgent = userAgent;
            this.ReqId = reqId;
            this.ReqUrl = reqUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant308" /> class.
        /// </summary>
        public UserEventPayloadVariant308()
        {
        }
    }
}