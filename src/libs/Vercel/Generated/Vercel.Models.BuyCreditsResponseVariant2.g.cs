
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2
    {
        /// <summary>
        /// The created purchase intent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseIntent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant2PurchaseIntent PurchaseIntent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2" /> class.
        /// </summary>
        /// <param name="purchaseIntent">
        /// The created purchase intent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2(
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntent purchaseIntent)
        {
            this.PurchaseIntent = purchaseIntent ?? throw new global::System.ArgumentNullException(nameof(purchaseIntent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2()
        {
        }
    }
}