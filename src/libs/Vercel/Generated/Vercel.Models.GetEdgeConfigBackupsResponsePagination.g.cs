
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEdgeConfigBackupsResponsePagination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasNext")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupsResponsePagination" /> class.
        /// </summary>
        /// <param name="hasNext"></param>
        /// <param name="next"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEdgeConfigBackupsResponsePagination(
            bool hasNext,
            string? next)
        {
            this.HasNext = hasNext;
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupsResponsePagination" /> class.
        /// </summary>
        public GetEdgeConfigBackupsResponsePagination()
        {
        }
    }
}