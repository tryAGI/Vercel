
#nullable enable

namespace Vercel
{
    /// <summary>
    /// This object contains information related to the pagination of the current request using continuation tokens. Since CosmosDB doesn't support going to previous pages, only count and next are provided.
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3Pagination
    {
        /// <summary>
        /// Amount of items in the current page.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Continuation token that must be used to request the next page. Base32 encoded for safe URL transmission.<br/>
        /// Example: JBSWY3DPEHPK3PXP
        /// </summary>
        /// <example>JBSWY3DPEHPK3PXP</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3Pagination" /> class.
        /// </summary>
        /// <param name="count">
        /// Amount of items in the current page.<br/>
        /// Example: 20
        /// </param>
        /// <param name="next">
        /// Continuation token that must be used to request the next page. Base32 encoded for safe URL transmission.<br/>
        /// Example: JBSWY3DPEHPK3PXP
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3Pagination(
            double count,
            string? next)
        {
            this.Count = count;
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3Pagination" /> class.
        /// </summary>
        public GetProjectsResponseVariant3Pagination()
        {
        }
    }
}