
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Options
    {
        /// <summary>
        /// The price intervals to add to the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add")]
        public global::System.Collections.Generic.IList<object>? Add { get; set; }

        /// <summary>
        /// The adjustment intervals to add to the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addAdjustments")]
        public global::System.Collections.Generic.IList<object>? AddAdjustments { get; set; }

        /// <summary>
        /// Whether to allow invoice credit or void
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowInvoiceCreditOrVoid")]
        public bool? AllowInvoiceCreditOrVoid { get; set; }

        /// <summary>
        /// The price intervals to edit on the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit")]
        public global::System.Collections.Generic.IList<object>? Edit { get; set; }

        /// <summary>
        /// The adjustment intervals to edit on the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editAdjustments")]
        public global::System.Collections.Generic.IList<object>? EditAdjustments { get; set; }

        /// <summary>
        /// The ID of the Orb subscription to modify price intervals for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbSubscriptionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbSubscriptionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Options" /> class.
        /// </summary>
        /// <param name="orbSubscriptionId">
        /// The ID of the Orb subscription to modify price intervals for
        /// </param>
        /// <param name="add">
        /// The price intervals to add to the subscription
        /// </param>
        /// <param name="addAdjustments">
        /// The adjustment intervals to add to the subscription
        /// </param>
        /// <param name="allowInvoiceCreditOrVoid">
        /// Whether to allow invoice credit or void
        /// </param>
        /// <param name="edit">
        /// The price intervals to edit on the subscription
        /// </param>
        /// <param name="editAdjustments">
        /// The adjustment intervals to edit on the subscription
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Options(
            string orbSubscriptionId,
            global::System.Collections.Generic.IList<object>? add,
            global::System.Collections.Generic.IList<object>? addAdjustments,
            bool? allowInvoiceCreditOrVoid,
            global::System.Collections.Generic.IList<object>? edit,
            global::System.Collections.Generic.IList<object>? editAdjustments)
        {
            this.Add = add;
            this.AddAdjustments = addAdjustments;
            this.AllowInvoiceCreditOrVoid = allowInvoiceCreditOrVoid;
            this.Edit = edit;
            this.EditAdjustments = editAdjustments;
            this.OrbSubscriptionId = orbSubscriptionId ?? throw new global::System.ArgumentNullException(nameof(orbSubscriptionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Options" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Options()
        {
        }

    }
}