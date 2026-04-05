
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The redirect object to edit. The source field is used to match the redirect to modify.
    /// </summary>
    public sealed partial class EditRedirectRequestRedirect
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
        public string? Destination { get; set; }

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
        /// Initializes a new instance of the <see cref="EditRedirectRequestRedirect" /> class.
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
        public EditRedirectRequestRedirect(
            string source,
            string? destination,
            double? statusCode,
            bool? permanent,
            bool? caseSensitive,
            bool? query,
            bool? preserveQueryParams)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Destination = destination;
            this.StatusCode = statusCode;
            this.Permanent = permanent;
            this.CaseSensitive = caseSensitive;
            this.Query = query;
            this.PreserveQueryParams = preserveQueryParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRedirectRequestRedirect" /> class.
        /// </summary>
        public EditRedirectRequestRedirect()
        {
        }
    }
}