
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseImagesLocalPattern
    {
        /// <summary>
        /// Can be literal or wildcard. Single `*` matches a single path segment. Double `**` matches any number of path segments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pathname")]
        public string? Pathname { get; set; }

        /// <summary>
        /// Can be literal query string such as `?v=1` or empty string meaning no query string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public string? Search { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseImagesLocalPattern" /> class.
        /// </summary>
        /// <param name="pathname">
        /// Can be literal or wildcard. Single `*` matches a single path segment. Double `**` matches any number of path segments.
        /// </param>
        /// <param name="search">
        /// Can be literal query string such as `?v=1` or empty string meaning no query string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseImagesLocalPattern(
            string? pathname,
            string? search)
        {
            this.Pathname = pathname;
            this.Search = search;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseImagesLocalPattern" /> class.
        /// </summary>
        public CreateDeploymentResponseImagesLocalPattern()
        {
        }
    }
}