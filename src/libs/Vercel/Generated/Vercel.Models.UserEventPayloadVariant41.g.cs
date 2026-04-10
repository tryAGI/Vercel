
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant41
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
        public string? SubscriptionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productAliases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ProductAliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant41" /> class.
        /// </summary>
        /// <param name="productAliases"></param>
        /// <param name="subscriptionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant41(
            global::System.Collections.Generic.IList<string> productAliases,
            string? subscriptionId)
        {
            this.SubscriptionId = subscriptionId;
            this.ProductAliases = productAliases ?? throw new global::System.ArgumentNullException(nameof(productAliases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant41" /> class.
        /// </summary>
        public UserEventPayloadVariant41()
        {
        }
    }
}