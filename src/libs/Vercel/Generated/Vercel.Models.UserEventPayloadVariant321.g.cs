
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant321
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorTokenId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorTokenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant321OriginJsonConverter))]
        public global::Vercel.UserEventPayloadVariant321Origin? Origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaked")]
        public bool? Leaked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked")]
        public bool? Revoked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geolocation")]
        public global::Vercel.UserEventPayloadVariant321Geolocation? Geolocation { get; set; }

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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant321" /> class.
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="tokenType"></param>
        /// <param name="tokenName"></param>
        /// <param name="actorTokenId"></param>
        /// <param name="origin"></param>
        /// <param name="teamId"></param>
        /// <param name="expired"></param>
        /// <param name="leaked"></param>
        /// <param name="revoked"></param>
        /// <param name="ip"></param>
        /// <param name="geolocation"></param>
        /// <param name="userAgent"></param>
        /// <param name="reqId"></param>
        /// <param name="reqUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant321(
            string tokenId,
            string tokenType,
            string tokenName,
            string actorTokenId,
            global::Vercel.UserEventPayloadVariant321Origin? origin,
            string? teamId,
            bool? expired,
            bool? leaked,
            bool? revoked,
            string? ip,
            global::Vercel.UserEventPayloadVariant321Geolocation? geolocation,
            string? userAgent,
            string? reqId,
            string? reqUrl)
        {
            this.TokenId = tokenId ?? throw new global::System.ArgumentNullException(nameof(tokenId));
            this.TokenType = tokenType ?? throw new global::System.ArgumentNullException(nameof(tokenType));
            this.TokenName = tokenName ?? throw new global::System.ArgumentNullException(nameof(tokenName));
            this.ActorTokenId = actorTokenId ?? throw new global::System.ArgumentNullException(nameof(actorTokenId));
            this.Origin = origin;
            this.TeamId = teamId;
            this.Expired = expired;
            this.Leaked = leaked;
            this.Revoked = revoked;
            this.Ip = ip;
            this.Geolocation = geolocation;
            this.UserAgent = userAgent;
            this.ReqId = reqId;
            this.ReqUrl = reqUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant321" /> class.
        /// </summary>
        public UserEventPayloadVariant321()
        {
        }
    }
}