
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0001bb8e789a120e
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedfa633702cac2aa68JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedfa633702cac2aa68 Delivery { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0001bb8e789a120eDisabledReasonJsonConverter))]
        public global::Vercel.AutoSDKShared0001bb8e789a120eDisabledReason? DisabledReason { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0001bb8e789a120eSamplingItem>? Sampling { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared0001bb8e789a120eSchemas Schemas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared0001bb8e789a120eSourceVariant1, global::Vercel.AutoSDKShared0001bb8e789a120eSourceVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared0001bb8e789a120eSourceVariant1, global::Vercel.AutoSDKShared0001bb8e789a120eSourceVariant2> Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0001bb8e789a120eStatusJsonConverter))]
        public global::Vercel.AutoSDKShared0001bb8e789a120eStatus? Status { get; set; }

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
        /// Delivery health of a drain over the last 24 hours, counted on finished deliveries (a delivery saved by an automatic retry counts once, as delivered): `failing` when more than 5 deliveries failed and they are at least 1% of all finished deliveries, `healthy` otherwise, and `unknown` when no delivery finished in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveryStats")]
        public global::Vercel.AutoSDKShared0001bb8e789a120eDeliveryStats? DeliveryStats { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterV2")]
        public global::Vercel.AutoSDKShared0001bb8e789a120eFilterV2? FilterV2 { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared0001bb8e789a120eProjectAccessVariant1, global::Vercel.AutoSDKShared0001bb8e789a120eProjectAccessVariant2>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKShared0001bb8e789a120eProjectAccessVariant1, global::Vercel.AutoSDKShared0001bb8e789a120eProjectAccessVariant2>? ProjectAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0001bb8e789a120e" /> class.
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
        /// Delivery health of a drain over the last 24 hours, counted on finished deliveries (a delivery saved by an automatic retry counts once, as delivered): `failing` when more than 5 deliveries failed and they are at least 1% of all finished deliveries, `healthy` otherwise, and `unknown` when no delivery finished in the window.
        /// </param>
        /// <param name="filterV2"></param>
        /// <param name="integrationConfigurationUri"></param>
        /// <param name="integrationIcon"></param>
        /// <param name="integrationWebsite"></param>
        /// <param name="projectAccess"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0001bb8e789a120e(
            double createdAt,
            global::Vercel.AutoSDKSharedfa633702cac2aa68 delivery,
            string id,
            string name,
            string ownerId,
            global::Vercel.AutoSDKShared0001bb8e789a120eSchemas schemas,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared0001bb8e789a120eSourceVariant1, global::Vercel.AutoSDKShared0001bb8e789a120eSourceVariant2> source,
            double updatedAt,
            double? disabledAt,
            string? disabledBy,
            global::Vercel.AutoSDKShared0001bb8e789a120eDisabledReason? disabledReason,
            double? firstErrorTimestamp,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0001bb8e789a120eSamplingItem>? sampling,
            global::Vercel.AutoSDKShared0001bb8e789a120eStatus? status,
            string? teamId,
            global::Vercel.AutoSDKShared0001bb8e789a120eDeliveryStats? deliveryStats,
            global::Vercel.AutoSDKShared0001bb8e789a120eFilterV2? filterV2,
            string? integrationConfigurationUri,
            string? integrationIcon,
            string? integrationWebsite,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared0001bb8e789a120eProjectAccessVariant1, global::Vercel.AutoSDKShared0001bb8e789a120eProjectAccessVariant2>? projectAccess)
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
        /// Initializes a new instance of the <see cref="AutoSDKShared0001bb8e789a120e" /> class.
        /// </summary>
        public AutoSDKShared0001bb8e789a120e()
        {
        }

    }
}