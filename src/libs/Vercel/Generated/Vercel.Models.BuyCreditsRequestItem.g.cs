
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyCreditsRequestItem
    {
        /// <summary>
        /// The type of item to purchase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsRequestItemTypeJsonConverter))]
        public global::Vercel.BuyCreditsRequestItemType Type { get; set; }

        /// <summary>
        /// The type of credits to purchase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creditType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsRequestItemCreditTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsRequestItemCreditType CreditType { get; set; }

        /// <summary>
        /// The amount of credits to purchase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsRequestItem" /> class.
        /// </summary>
        /// <param name="creditType">
        /// The type of credits to purchase.
        /// </param>
        /// <param name="amount">
        /// The amount of credits to purchase.
        /// </param>
        /// <param name="type">
        /// The type of item to purchase.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsRequestItem(
            global::Vercel.BuyCreditsRequestItemCreditType creditType,
            int amount,
            global::Vercel.BuyCreditsRequestItemType type)
        {
            this.Type = type;
            this.CreditType = creditType;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsRequestItem" /> class.
        /// </summary>
        public BuyCreditsRequestItem()
        {
        }
    }
}