
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRedirectsResponseVariant2Redirect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permanent")]
        public bool? Permanent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensitive")]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caseSensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public bool? Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserveQueryParams")]
        public bool? PreserveQueryParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Destination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRedirectsResponseVariant2Redirect" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="statusCode"></param>
        /// <param name="permanent"></param>
        /// <param name="sensitive"></param>
        /// <param name="caseSensitive"></param>
        /// <param name="query"></param>
        /// <param name="preserveQueryParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRedirectsResponseVariant2Redirect(
            string source,
            string destination,
            double? statusCode,
            bool? permanent,
            bool? sensitive,
            bool? caseSensitive,
            bool? query,
            bool? preserveQueryParams)
        {
            this.StatusCode = statusCode;
            this.Permanent = permanent;
            this.Sensitive = sensitive;
            this.CaseSensitive = caseSensitive;
            this.Query = query;
            this.PreserveQueryParams = preserveQueryParams;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRedirectsResponseVariant2Redirect" /> class.
        /// </summary>
        public GetRedirectsResponseVariant2Redirect()
        {
        }
    }
}