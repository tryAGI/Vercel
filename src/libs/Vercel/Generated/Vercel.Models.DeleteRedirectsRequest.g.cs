
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteRedirectsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The redirects to delete. The source of the redirect is used to match the redirect to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Redirects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRedirectsRequest" /> class.
        /// </summary>
        /// <param name="redirects">
        /// The redirects to delete. The source of the redirect is used to match the redirect to delete.
        /// </param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteRedirectsRequest(
            global::System.Collections.Generic.IList<string> redirects,
            string? name)
        {
            this.Name = name;
            this.Redirects = redirects ?? throw new global::System.ArgumentNullException(nameof(redirects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRedirectsRequest" /> class.
        /// </summary>
        public DeleteRedirectsRequest()
        {
        }
    }
}