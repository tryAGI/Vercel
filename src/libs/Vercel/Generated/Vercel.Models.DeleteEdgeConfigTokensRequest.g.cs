
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
        public global::System.Collections.Generic.IList<string>? Tokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<string>? Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEdgeConfigTokensRequest" /> class.
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="ids"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteEdgeConfigTokensRequest(
            global::System.Collections.Generic.IList<string>? tokens,
            global::System.Collections.Generic.IList<string>? ids)
        {
            this.Tokens = tokens;
            this.Ids = ids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEdgeConfigTokensRequest" /> class.
        /// </summary>
        public DeleteEdgeConfigTokensRequest()
        {
        }
    }
}