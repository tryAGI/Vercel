
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd5d6c9ab94c25f66
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant2, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant3, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant5>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant2, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant3, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant5> Delivery { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledAt")]
        public double? DisabledAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledBy")]
        public string? DisabledBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd5d6c9ab94c25f66DisabledReasonJsonConverter))]
        public global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DisabledReason? DisabledReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstErrorTimestamp")]
        public double? FirstErrorTimestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        public global::System.Collections.Generic.IList<string>? ProjectIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66SamplingItem>? Sampling { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedd5d6c9ab94c25f66Schemas Schemas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66SourceVariant1, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66SourceVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66SourceVariant1, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66SourceVariant2> Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd5d6c9ab94c25f66StatusJsonConverter))]
        public global::Vercel.AutoSDKSharedd5d6c9ab94c25f66Status? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Delivery health of a drain over the last 24 hours: `failing` when more than 5 delivery attempts and at least 1% of all attempts did not succeed, `healthy` otherwise, and `unknown` when there were no attempts or the stats could not be loaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveryStats")]
        public global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryStats? DeliveryStats { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterV2")]
        public global::Vercel.AutoSDKSharedd5d6c9ab94c25f66FilterV2? FilterV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationConfigurationUri")]
        public string? IntegrationConfigurationUri { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIcon")]
        public string? IntegrationIcon { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationWebsite")]
        public string? IntegrationWebsite { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectAccess")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant1, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant2>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant1, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant2>? ProjectAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd5d6c9ab94c25f66" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="delivery"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="ownerId"></param>
        /// <param name="schemas"></param>
        /// <param name="source"></param>
        /// <param name="updatedAt"></param>
        /// <param name="disabledAt"></param>
        /// <param name="disabledBy"></param>
        /// <param name="disabledReason"></param>
        /// <param name="firstErrorTimestamp"></param>
        /// <param name="projectIds"></param>
        /// <param name="sampling"></param>
        /// <param name="status"></param>
        /// <param name="teamId"></param>
        /// <param name="deliveryStats">
        /// Delivery health of a drain over the last 24 hours: `failing` when more than 5 delivery attempts and at least 1% of all attempts did not succeed, `healthy` otherwise, and `unknown` when there were no attempts or the stats could not be loaded.
        /// </param>
        /// <param name="filterV2"></param>
        /// <param name="integrationConfigurationUri"></param>
        /// <param name="integrationIcon"></param>
        /// <param name="integrationWebsite"></param>
        /// <param name="projectAccess"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd5d6c9ab94c25f66(
            double createdAt,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant2, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant3, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant4, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant5> delivery,
            string id,
            string name,
            string ownerId,
            global::Vercel.AutoSDKSharedd5d6c9ab94c25f66Schemas schemas,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66SourceVariant1, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66SourceVariant2> source,
            double updatedAt,
            double? disabledAt,
            string? disabledBy,
            global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DisabledReason? disabledReason,
            double? firstErrorTimestamp,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66SamplingItem>? sampling,
            global::Vercel.AutoSDKSharedd5d6c9ab94c25f66Status? status,
            string? teamId,
            global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryStats? deliveryStats,
            global::Vercel.AutoSDKSharedd5d6c9ab94c25f66FilterV2? filterV2,
            string? integrationConfigurationUri,
            string? integrationIcon,
            string? integrationWebsite,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant1, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant2>? projectAccess)
        {
            this.CreatedAt = createdAt;
            this.Delivery = delivery;
            this.DisabledAt = disabledAt;
            this.DisabledBy = disabledBy;
            this.DisabledReason = disabledReason;
            this.FirstErrorTimestamp = firstErrorTimestamp;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ProjectIds = projectIds;
            this.Sampling = sampling;
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.Source = source;
            this.Status = status;
            this.TeamId = teamId;
            this.UpdatedAt = updatedAt;
            this.DeliveryStats = deliveryStats;
            this.FilterV2 = filterV2;
            this.IntegrationConfigurationUri = integrationConfigurationUri;
            this.IntegrationIcon = integrationIcon;
            this.IntegrationWebsite = integrationWebsite;
            this.ProjectAccess = projectAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd5d6c9ab94c25f66" /> class.
        /// </summary>
        public AutoSDKSharedd5d6c9ab94c25f66()
        {
        }

    }
}