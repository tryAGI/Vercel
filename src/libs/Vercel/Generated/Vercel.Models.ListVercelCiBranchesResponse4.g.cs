
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVercelCiBranchesResponse4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListVercelCiBranchesResponseError3 Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiBranchesResponse4" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVercelCiBranchesResponse4(
            global::Vercel.ListVercelCiBranchesResponseError3 error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiBranchesResponse4" /> class.
        /// </summary>
        public ListVercelCiBranchesResponse4()
        {
        }

    }
}