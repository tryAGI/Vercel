
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkoutSessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckoutSessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkoutSessionUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckoutSessionUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant1" /> class.
        /// </summary>
        /// <param name="checkoutSessionId"></param>
        /// <param name="checkoutSessionUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant1(
            string checkoutSessionId,
            string checkoutSessionUrl)
        {
            this.CheckoutSessionId = checkoutSessionId ?? throw new global::System.ArgumentNullException(nameof(checkoutSessionId));
            this.CheckoutSessionUrl = checkoutSessionUrl ?? throw new global::System.ArgumentNullException(nameof(checkoutSessionUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant1" /> class.
        /// </summary>
        public BuyCreditsResponseVariant1()
        {
        }
    }
}