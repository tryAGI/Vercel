
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectTokenRequest
    {
        /// <summary>
        /// The source that is calling the endpoint.<br/>
        /// Example: vercel-cli:pull
        /// </summary>
        /// <example>vercel-cli:pull</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectTokenRequest" /> class.
        /// </summary>
        /// <param name="source">
        /// The source that is calling the endpoint.<br/>
        /// Example: vercel-cli:pull
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectTokenRequest(
            string? source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectTokenRequest" /> class.
        /// </summary>
        public GetProjectTokenRequest()
        {
        }

    }
}