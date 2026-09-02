
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Cursor for the next page.
    /// </summary>
    public sealed partial class ConnectPagination
    {
        /// <summary>
        /// Opaque value to pass as `cursor` on the next request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectPagination" /> class.
        /// </summary>
        /// <param name="next">
        /// Opaque value to pass as `cursor` on the next request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectPagination(
            string? next)
        {
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectPagination" /> class.
        /// </summary>
        public ConnectPagination()
        {
        }

    }
}