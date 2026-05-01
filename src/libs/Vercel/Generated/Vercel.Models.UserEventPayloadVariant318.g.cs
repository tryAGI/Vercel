
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant318
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant318GrantTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant318GrantType GrantType { get; set; }

        /// <summary>
        /// the app's name at the time the event was published (it could have changed since then)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppName { get; set; }

        /// <summary>
        /// access_token TTL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atTTL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AtTTL { get; set; }

        /// <summary>
        /// refresh_token TTL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rtTTL")]
        public double? RtTTL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authMethod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant318AuthMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant318AuthMethod AuthMethod { get; set; }

        /// <summary>
        /// optional since entries prior to 2025-10-13 do not contain app information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::Vercel.UserEventPayloadVariant318App? App { get; set; }

        /// <summary>
        /// optional since entries prior to 2025-10-13 do not contain this field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includesRefreshToken")]
        public bool? IncludesRefreshToken { get; set; }

        /// <summary>
        /// optional since entries prior to 2025-10-13 do not contain this field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicId")]
        public string? PublicId { get; set; }

        /// <summary>
        /// optional since entries prior to 2026-04-23 do not contain this field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenPrefix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant318TokenPrefixJsonConverter))]
        public global::Vercel.UserEventPayloadVariant318TokenPrefix? TokenPrefix { get; set; }

        /// <summary>
        /// optional since entries prior to 2026-04-23 do not contain this field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenSuffix")]
        public string? TokenSuffix { get; set; }

        /// <summary>
        /// optional; only present when a refresh token was issued (offline_access).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshTokenPublicId")]
        public string? RefreshTokenPublicId { get; set; }

        /// <summary>
        /// optional; only present when a refresh token was issued (offline_access).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshTokenPrefix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant318RefreshTokenPrefixJsonConverter))]
        public global::Vercel.UserEventPayloadVariant318RefreshTokenPrefix? RefreshTokenPrefix { get; set; }

        /// <summary>
        /// optional; only present when a refresh token was issued (offline_access).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshTokenSuffix")]
        public string? RefreshTokenSuffix { get; set; }

        /// <summary>
        /// optional since entries prior to 2025-10-13 do not contain this field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// optional since entries prior to 2026-04-23 do not contain this field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// optional since entries prior to 2026-04-23 do not contain this field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geolocation")]
        public global::Vercel.UserEventPayloadVariant318Geolocation? Geolocation { get; set; }

        /// <summary>
        /// optional since entries prior to 2026-04-23 do not contain this field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAgent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant318" /> class.
        /// </summary>
        /// <param name="grantType"></param>
        /// <param name="appName">
        /// the app's name at the time the event was published (it could have changed since then)
        /// </param>
        /// <param name="atTTL">
        /// access_token TTL
        /// </param>
        /// <param name="scope"></param>
        /// <param name="authMethod"></param>
        /// <param name="rtTTL">
        /// refresh_token TTL
        /// </param>
        /// <param name="app">
        /// optional since entries prior to 2025-10-13 do not contain app information
        /// </param>
        /// <param name="includesRefreshToken">
        /// optional since entries prior to 2025-10-13 do not contain this field
        /// </param>
        /// <param name="publicId">
        /// optional since entries prior to 2025-10-13 do not contain this field
        /// </param>
        /// <param name="tokenPrefix">
        /// optional since entries prior to 2026-04-23 do not contain this field
        /// </param>
        /// <param name="tokenSuffix">
        /// optional since entries prior to 2026-04-23 do not contain this field
        /// </param>
        /// <param name="refreshTokenPublicId">
        /// optional; only present when a refresh token was issued (offline_access).
        /// </param>
        /// <param name="refreshTokenPrefix">
        /// optional; only present when a refresh token was issued (offline_access).
        /// </param>
        /// <param name="refreshTokenSuffix">
        /// optional; only present when a refresh token was issued (offline_access).
        /// </param>
        /// <param name="sessionId">
        /// optional since entries prior to 2025-10-13 do not contain this field
        /// </param>
        /// <param name="ip">
        /// optional since entries prior to 2026-04-23 do not contain this field
        /// </param>
        /// <param name="geolocation">
        /// optional since entries prior to 2026-04-23 do not contain this field
        /// </param>
        /// <param name="userAgent">
        /// optional since entries prior to 2026-04-23 do not contain this field
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant318(
            global::Vercel.UserEventPayloadVariant318GrantType grantType,
            string appName,
            double atTTL,
            string scope,
            global::Vercel.UserEventPayloadVariant318AuthMethod authMethod,
            double? rtTTL,
            global::Vercel.UserEventPayloadVariant318App? app,
            bool? includesRefreshToken,
            string? publicId,
            global::Vercel.UserEventPayloadVariant318TokenPrefix? tokenPrefix,
            string? tokenSuffix,
            string? refreshTokenPublicId,
            global::Vercel.UserEventPayloadVariant318RefreshTokenPrefix? refreshTokenPrefix,
            string? refreshTokenSuffix,
            string? sessionId,
            string? ip,
            global::Vercel.UserEventPayloadVariant318Geolocation? geolocation,
            string? userAgent)
        {
            this.GrantType = grantType;
            this.AppName = appName ?? throw new global::System.ArgumentNullException(nameof(appName));
            this.AtTTL = atTTL;
            this.RtTTL = rtTTL;
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.AuthMethod = authMethod;
            this.App = app;
            this.IncludesRefreshToken = includesRefreshToken;
            this.PublicId = publicId;
            this.TokenPrefix = tokenPrefix;
            this.TokenSuffix = tokenSuffix;
            this.RefreshTokenPublicId = refreshTokenPublicId;
            this.RefreshTokenPrefix = refreshTokenPrefix;
            this.RefreshTokenSuffix = refreshTokenSuffix;
            this.SessionId = sessionId;
            this.Ip = ip;
            this.Geolocation = geolocation;
            this.UserAgent = userAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant318" /> class.
        /// </summary>
        public UserEventPayloadVariant318()
        {
        }
    }
}