
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant312
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DeletedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorTokenId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorTokenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geolocation")]
        public global::Vercel.UserEventPayloadVariant312Geolocation? Geolocation { get; set; }

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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant312" /> class.
        /// </summary>
        /// <param name="deletedCount"></param>
        /// <param name="actorTokenId"></param>
        /// <param name="ip"></param>
        /// <param name="geolocation"></param>
        /// <param name="userAgent"></param>
        /// <param name="reqId"></param>
        /// <param name="reqUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant312(
            double deletedCount,
            string actorTokenId,
            string? ip,
            global::Vercel.UserEventPayloadVariant312Geolocation? geolocation,
            string? userAgent,
            string? reqId,
            string? reqUrl)
        {
            this.DeletedCount = deletedCount;
            this.ActorTokenId = actorTokenId ?? throw new global::System.ArgumentNullException(nameof(actorTokenId));
            this.Ip = ip;
            this.Geolocation = geolocation;
            this.UserAgent = userAgent;
            this.ReqId = reqId;
            this.ReqUrl = reqUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant312" /> class.
        /// </summary>
        public UserEventPayloadVariant312()
        {
        }
    }
}