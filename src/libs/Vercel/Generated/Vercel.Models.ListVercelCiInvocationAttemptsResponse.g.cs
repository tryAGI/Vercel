
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVercelCiInvocationAttemptsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared3fd5b0acfe2f4f54> Attempts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Repositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiInvocationAttemptsResponse" /> class.
        /// </summary>
        /// <param name="attempts"></param>
        /// <param name="repositories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVercelCiInvocationAttemptsResponse(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared3fd5b0acfe2f4f54> attempts,
            object repositories)
        {
            this.Attempts = attempts ?? throw new global::System.ArgumentNullException(nameof(attempts));
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiInvocationAttemptsResponse" /> class.
        /// </summary>
        public ListVercelCiInvocationAttemptsResponse()
        {
        }

    }
}