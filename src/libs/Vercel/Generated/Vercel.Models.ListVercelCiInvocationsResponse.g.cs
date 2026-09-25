
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVercelCiInvocationsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared3fd5b0acfe2f4f54> Invocations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Repositories { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListVercelCiInvocationsResponsePagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiInvocationsResponse" /> class.
        /// </summary>
        /// <param name="invocations"></param>
        /// <param name="repositories"></param>
        /// <param name="pagination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVercelCiInvocationsResponse(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared3fd5b0acfe2f4f54> invocations,
            object repositories,
            global::Vercel.ListVercelCiInvocationsResponsePagination pagination)
        {
            this.Invocations = invocations ?? throw new global::System.ArgumentNullException(nameof(invocations));
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiInvocationsResponse" /> class.
        /// </summary>
        public ListVercelCiInvocationsResponse()
        {
        }

    }
}