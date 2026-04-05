
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyCreditsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsRequestItem Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsRequest" /> class.
        /// </summary>
        /// <param name="item"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsRequest(
            global::Vercel.BuyCreditsRequestItem item)
        {
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsRequest" /> class.
        /// </summary>
        public BuyCreditsRequest()
        {
        }
    }
}