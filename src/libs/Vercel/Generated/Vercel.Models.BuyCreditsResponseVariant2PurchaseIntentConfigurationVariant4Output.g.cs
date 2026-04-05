
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Output
    {
        /// <summary>
        /// The ID of the pending subscription change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pendingSubscriptionChangeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PendingSubscriptionChangeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Output" /> class.
        /// </summary>
        /// <param name="pendingSubscriptionChangeId">
        /// The ID of the pending subscription change
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Output(
            string pendingSubscriptionChangeId)
        {
            this.PendingSubscriptionChangeId = pendingSubscriptionChangeId ?? throw new global::System.ArgumentNullException(nameof(pendingSubscriptionChangeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Output" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Output()
        {
        }
    }
}