
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant293
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant293GrantTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant293GrantType GrantType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant293AuthMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant293AuthMethod AuthMethod { get; set; }

        /// <summary>
        /// optional since entries prior to 2025-10-13 do not contain app information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::Vercel.UserEventPayloadVariant293App? App { get; set; }

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
        /// optional since entries prior to 2025-10-13 do not contain this field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant293" /> class.
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
        /// <param name="sessionId">
        /// optional since entries prior to 2025-10-13 do not contain this field
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant293(
            global::Vercel.UserEventPayloadVariant293GrantType grantType,
            string appName,
            double atTTL,
            string scope,
            global::Vercel.UserEventPayloadVariant293AuthMethod authMethod,
            double? rtTTL,
            global::Vercel.UserEventPayloadVariant293App? app,
            bool? includesRefreshToken,
            string? publicId,
            string? sessionId)
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
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant293" /> class.
        /// </summary>
        public UserEventPayloadVariant293()
        {
        }
    }
}