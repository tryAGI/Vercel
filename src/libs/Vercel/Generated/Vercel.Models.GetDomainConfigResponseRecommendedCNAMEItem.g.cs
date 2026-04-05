
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Recommended CNAMEs for the domain. rank=1 is the preferred value to use.
    /// </summary>
    public sealed partial class GetDomainConfigResponseRecommendedCNAMEItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainConfigResponseRecommendedCNAMEItem" /> class.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDomainConfigResponseRecommendedCNAMEItem(
            double rank,
            string value)
        {
            this.Rank = rank;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainConfigResponseRecommendedCNAMEItem" /> class.
        /// </summary>
        public GetDomainConfigResponseRecommendedCNAMEItem()
        {
        }
    }
}