
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSandboxesV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.Sandbox> Sandboxes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSandboxesV1ResponsePagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSandboxesV1Response" /> class.
        /// </summary>
        /// <param name="sandboxes"></param>
        /// <param name="pagination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSandboxesV1Response(
            global::System.Collections.Generic.IList<global::Vercel.Sandbox> sandboxes,
            global::Vercel.GetSandboxesV1ResponsePagination pagination)
        {
            this.Sandboxes = sandboxes ?? throw new global::System.ArgumentNullException(nameof(sandboxes));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSandboxesV1Response" /> class.
        /// </summary>
        public GetSandboxesV1Response()
        {
        }
    }
}