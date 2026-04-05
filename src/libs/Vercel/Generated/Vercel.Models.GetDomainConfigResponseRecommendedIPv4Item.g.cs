
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Recommended IPv4s for the domain. rank=1 is the preferred value(s) to use. Only using 1 ip value is acceptable.
    /// </summary>
    public sealed partial class GetDomainConfigResponseRecommendedIPv4Item
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
        public required global::System.Collections.Generic.IList<string> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainConfigResponseRecommendedIPv4Item" /> class.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDomainConfigResponseRecommendedIPv4Item(
            double rank,
            global::System.Collections.Generic.IList<string> value)
        {
            this.Rank = rank;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainConfigResponseRecommendedIPv4Item" /> class.
        /// </summary>
        public GetDomainConfigResponseRecommendedIPv4Item()
        {
        }
    }
}