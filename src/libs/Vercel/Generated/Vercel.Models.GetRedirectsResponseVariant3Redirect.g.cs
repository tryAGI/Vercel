
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetRedirectsResponseVariant3Redirect
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caseSensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Destination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permanent")]
        public bool? Permanent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserveQueryParams")]
        public bool? PreserveQueryParams { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public bool? Query { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensitive")]
        public bool? Sensitive { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRedirectsResponseVariant3Redirect" /> class.
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="source"></param>
        /// <param name="caseSensitive"></param>
        /// <param name="permanent"></param>
        /// <param name="preserveQueryParams"></param>
        /// <param name="query"></param>
        /// <param name="sensitive"></param>
        /// <param name="statusCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRedirectsResponseVariant3Redirect(
            string destination,
            string source,
            bool? caseSensitive,
            bool? permanent,
            bool? preserveQueryParams,
            bool? query,
            bool? sensitive,
            double? statusCode)
        {
            this.CaseSensitive = caseSensitive;
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.Permanent = permanent;
            this.PreserveQueryParams = preserveQueryParams;
            this.Query = query;
            this.Sensitive = sensitive;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRedirectsResponseVariant3Redirect" /> class.
        /// </summary>
        public GetRedirectsResponseVariant3Redirect()
        {
        }

    }
}