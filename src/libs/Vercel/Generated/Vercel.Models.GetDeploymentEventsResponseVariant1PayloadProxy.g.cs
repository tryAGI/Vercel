
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentEventsResponseVariant1PayloadProxy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAgent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> UserAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Referer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientIp")]
        public string? ClientIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheme")]
        public string? Scheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseByteSize")]
        public double? ResponseByteSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheId")]
        public string? CacheId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelId")]
        public string? VercelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelCache")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentEventsResponseVariant1PayloadProxyVercelCacheJsonConverter))]
        public global::Vercel.GetDeploymentEventsResponseVariant1PayloadProxyVercelCache? VercelCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lambdaRegion")]
        public string? LambdaRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wafAction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentEventsResponseVariant1PayloadProxyWafActionJsonConverter))]
        public global::Vercel.GetDeploymentEventsResponseVariant1PayloadProxyWafAction? WafAction { get; set; }

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
        /// Initializes a new instance of the <see cref="GetDeploymentEventsResponseVariant1PayloadProxy" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="method"></param>
        /// <param name="host"></param>
        /// <param name="path"></param>
        /// <param name="userAgent"></param>
        /// <param name="referer"></param>
        /// <param name="region"></param>
        /// <param name="statusCode"></param>
        /// <param name="clientIp"></param>
        /// <param name="scheme"></param>
        /// <param name="responseByteSize"></param>
        /// <param name="cacheId"></param>
        /// <param name="pathType"></param>
        /// <param name="pathTypeVariant"></param>
        /// <param name="vercelId"></param>
        /// <param name="vercelCache"></param>
        /// <param name="lambdaRegion"></param>
        /// <param name="wafAction"></param>
        /// <param name="wafRuleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentEventsResponseVariant1PayloadProxy(
            double timestamp,
            string method,
            string host,
            string path,
            global::System.Collections.Generic.IList<string> userAgent,
            string referer,
            string region,
            double? statusCode,
            string? clientIp,
            string? scheme,
            double? responseByteSize,
            string? cacheId,
            string? pathType,
            string? pathTypeVariant,
            string? vercelId,
            global::Vercel.GetDeploymentEventsResponseVariant1PayloadProxyVercelCache? vercelCache,
            string? lambdaRegion,
            global::Vercel.GetDeploymentEventsResponseVariant1PayloadProxyWafAction? wafAction,
            string? wafRuleId)
        {
            this.Timestamp = timestamp;
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.StatusCode = statusCode;
            this.UserAgent = userAgent ?? throw new global::System.ArgumentNullException(nameof(userAgent));
            this.Referer = referer ?? throw new global::System.ArgumentNullException(nameof(referer));
            this.ClientIp = clientIp;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Scheme = scheme;
            this.ResponseByteSize = responseByteSize;
            this.CacheId = cacheId;
            this.PathType = pathType;
            this.PathTypeVariant = pathTypeVariant;
            this.VercelId = vercelId;
            this.VercelCache = vercelCache;
            this.LambdaRegion = lambdaRegion;
            this.WafAction = wafAction;
            this.WafRuleId = wafRuleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentEventsResponseVariant1PayloadProxy" /> class.
        /// </summary>
        public GetDeploymentEventsResponseVariant1PayloadProxy()
        {
        }
    }
}