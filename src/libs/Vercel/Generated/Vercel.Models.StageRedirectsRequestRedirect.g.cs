
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StageRedirectsRequestRedirect
    {
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>))]
        public global::Vercel.OneOf<double?, string>? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permanent")]
        public bool? Permanent { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StageRedirectsRequestRedirect" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="statusCode"></param>
        /// <param name="permanent"></param>
        /// <param name="caseSensitive"></param>
        /// <param name="query"></param>
        /// <param name="preserveQueryParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StageRedirectsRequestRedirect(
            string source,
            string destination,
            global::Vercel.OneOf<double?, string>? statusCode,
            bool? permanent,
            bool? caseSensitive,
            bool? query,
            bool? preserveQueryParams)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.StatusCode = statusCode;
            this.Permanent = permanent;
            this.CaseSensitive = caseSensitive;
            this.Query = query;
            this.PreserveQueryParams = preserveQueryParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StageRedirectsRequestRedirect" /> class.
        /// </summary>
        public StageRedirectsRequestRedirect()
        {
        }
    }
}