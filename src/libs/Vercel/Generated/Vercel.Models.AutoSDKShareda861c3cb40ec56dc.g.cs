
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda861c3cb40ec56dc
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant2, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant3, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant4, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant5>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant2, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant3, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant4, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant5> Delivery { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda861c3cb40ec56dcDisabledReasonJsonConverter))]
        public global::Vercel.AutoSDKShareda861c3cb40ec56dcDisabledReason? DisabledReason { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda861c3cb40ec56dcSamplingItem>? Sampling { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShareda861c3cb40ec56dcSchemas Schemas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShareda861c3cb40ec56dcSourceVariant1, global::Vercel.AutoSDKShareda861c3cb40ec56dcSourceVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShareda861c3cb40ec56dcSourceVariant1, global::Vercel.AutoSDKShareda861c3cb40ec56dcSourceVariant2> Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda861c3cb40ec56dcStatusJsonConverter))]
        public global::Vercel.AutoSDKShareda861c3cb40ec56dcStatus? Status { get; set; }

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
        public global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryStats? DeliveryStats { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterV2")]
        public global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2? FilterV2 { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1, global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1, global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2>? ProjectAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dc" /> class.
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
        public AutoSDKShareda861c3cb40ec56dc(
            double createdAt,
            global::Vercel.OneOf<global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant2, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant3, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant4, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant5> delivery,
            string id,
            string name,
            string ownerId,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcSchemas schemas,
            global::Vercel.OneOf<global::Vercel.AutoSDKShareda861c3cb40ec56dcSourceVariant1, global::Vercel.AutoSDKShareda861c3cb40ec56dcSourceVariant2> source,
            double updatedAt,
            double? disabledAt,
            string? disabledBy,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcDisabledReason? disabledReason,
            double? firstErrorTimestamp,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda861c3cb40ec56dcSamplingItem>? sampling,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcStatus? status,
            string? teamId,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryStats? deliveryStats,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2? filterV2,
            string? integrationConfigurationUri,
            string? integrationIcon,
            string? integrationWebsite,
            global::Vercel.OneOf<global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1, global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2>? projectAccess)
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
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dc" /> class.
        /// </summary>
        public AutoSDKShareda861c3cb40ec56dc()
        {
        }

    }
}