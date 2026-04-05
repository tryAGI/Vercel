
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant3OrbSubscriptionIntent
    {
        /// <summary>
        /// The ID of the Orb subscription intent with the format `orbsubint_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4> Configuration { get; set; }

        /// <summary>
        /// The ISO 8601 date-time that the intent was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The Orb subscription ID this intent is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbSubscriptionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbSubscriptionId { get; set; }

        /// <summary>
        /// The owner ID for this intent (e.g., team or user ID).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// The status of the Orb subscription intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant3OrbSubscriptionIntentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentStatus Status { get; set; }

        /// <summary>
        /// The ISO 8601 date-time that the intent was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Optional purchase intent ID if this is associated with a purchase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseIntentId")]
        public string? PurchaseIntentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntent" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the Orb subscription intent with the format `orbsubint_`.
        /// </param>
        /// <param name="configuration"></param>
        /// <param name="createdAt">
        /// The ISO 8601 date-time that the intent was created.
        /// </param>
        /// <param name="orbSubscriptionId">
        /// The Orb subscription ID this intent is associated with.
        /// </param>
        /// <param name="ownerId">
        /// The owner ID for this intent (e.g., team or user ID).
        /// </param>
        /// <param name="status">
        /// The status of the Orb subscription intent.
        /// </param>
        /// <param name="updatedAt">
        /// The ISO 8601 date-time that the intent was last updated.
        /// </param>
        /// <param name="purchaseIntentId">
        /// Optional purchase intent ID if this is associated with a purchase.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant3OrbSubscriptionIntent(
            string id,
            global::Vercel.OneOf<global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4> configuration,
            string createdAt,
            string orbSubscriptionId,
            string ownerId,
            global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentStatus status,
            string updatedAt,
            string? purchaseIntentId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Configuration = configuration;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.OrbSubscriptionId = orbSubscriptionId ?? throw new global::System.ArgumentNullException(nameof(orbSubscriptionId));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Status = status;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.PurchaseIntentId = purchaseIntentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntent" /> class.
        /// </summary>
        public BuyCreditsResponseVariant3OrbSubscriptionIntent()
        {
        }
    }
}