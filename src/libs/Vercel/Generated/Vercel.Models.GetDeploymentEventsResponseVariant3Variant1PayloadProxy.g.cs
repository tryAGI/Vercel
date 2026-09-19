
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDeploymentEventsResponseVariant3Variant1PayloadProxy
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheId")]
        public string? CacheId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientIp")]
        public string? ClientIp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lambdaRegion")]
        public string? LambdaRegion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pathType")]
        public string? PathType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pathTypeVariant")]
        public string? PathTypeVariant { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referer")]
        public string? Referer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseByteSize")]
        public double? ResponseByteSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheme")]
        public string? Scheme { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAgent")]
        public global::System.Collections.Generic.IList<string>? UserAgent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelCache")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCacheJsonConverter))]
        public global::Vercel.GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache? VercelCache { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelId")]
        public string? VercelId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wafAction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafActionJsonConverter))]
        public global::Vercel.GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction? WafAction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wafRuleId")]
        public string? WafRuleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentEventsResponseVariant3Variant1PayloadProxy" /> class.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="method"></param>
        /// <param name="timestamp"></param>
        /// <param name="cacheId"></param>
        /// <param name="clientIp"></param>
        /// <param name="lambdaRegion"></param>
        /// <param name="path"></param>
        /// <param name="pathType"></param>
        /// <param name="pathTypeVariant"></param>
        /// <param name="referer"></param>
        /// <param name="region"></param>
        /// <param name="responseByteSize"></param>
        /// <param name="scheme"></param>
        /// <param name="statusCode"></param>
        /// <param name="userAgent"></param>
        /// <param name="vercelCache"></param>
        /// <param name="vercelId"></param>
        /// <param name="wafAction"></param>
        /// <param name="wafRuleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentEventsResponseVariant3Variant1PayloadProxy(
            string host,
            string method,
            double timestamp,
            string? cacheId,
            string? clientIp,
            string? lambdaRegion,
            string? path,
            string? pathType,
            string? pathTypeVariant,
            string? referer,
            string? region,
            double? responseByteSize,
            string? scheme,
            double? statusCode,
            global::System.Collections.Generic.IList<string>? userAgent,
            global::Vercel.GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache? vercelCache,
            string? vercelId,
            global::Vercel.GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction? wafAction,
            string? wafRuleId)
        {
            this.CacheId = cacheId;
            this.ClientIp = clientIp;
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.LambdaRegion = lambdaRegion;
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.Path = path;
            this.PathType = pathType;
            this.PathTypeVariant = pathTypeVariant;
            this.Referer = referer;
            this.Region = region;
            this.ResponseByteSize = responseByteSize;
            this.Scheme = scheme;
            this.StatusCode = statusCode;
            this.Timestamp = timestamp;
            this.UserAgent = userAgent;
            this.VercelCache = vercelCache;
            this.VercelId = vercelId;
            this.WafAction = wafAction;
            this.WafRuleId = wafRuleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentEventsResponseVariant3Variant1PayloadProxy" /> class.
        /// </summary>
        public GetDeploymentEventsResponseVariant3Variant1PayloadProxy()
        {
        }

    }
}