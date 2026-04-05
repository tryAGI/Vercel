
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveProjectDomainRequest
    {
        /// <summary>
        /// Whether to remove all domains from this project that redirect to the domain being removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeRedirects")]
        public bool? RemoveRedirects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveProjectDomainRequest" /> class.
        /// </summary>
        /// <param name="removeRedirects">
        /// Whether to remove all domains from this project that redirect to the domain being removed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveProjectDomainRequest(
            bool? removeRedirects)
        {
            this.RemoveRedirects = removeRedirects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveProjectDomainRequest" /> class.
        /// </summary>
        public RemoveProjectDomainRequest()
        {
        }
    }
}