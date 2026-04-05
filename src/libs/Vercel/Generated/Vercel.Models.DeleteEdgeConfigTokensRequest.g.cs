
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteEdgeConfigTokensRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEdgeConfigTokensRequest" /> class.
        /// </summary>
        /// <param name="tokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteEdgeConfigTokensRequest(
            global::System.Collections.Generic.IList<string> tokens)
        {
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEdgeConfigTokensRequest" /> class.
        /// </summary>
        public DeleteEdgeConfigTokensRequest()
        {
        }
    }
}