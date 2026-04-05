
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectDomainsResponseVariant1Pagination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public double? Next { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev")]
        public double? Prev { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDomainsResponseVariant1Pagination" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="next"></param>
        /// <param name="prev"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectDomainsResponseVariant1Pagination(
            double count,
            double? next,
            double? prev)
        {
            this.Count = count;
            this.Next = next;
            this.Prev = prev;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDomainsResponseVariant1Pagination" /> class.
        /// </summary>
        public GetProjectDomainsResponseVariant1Pagination()
        {
        }
    }
}