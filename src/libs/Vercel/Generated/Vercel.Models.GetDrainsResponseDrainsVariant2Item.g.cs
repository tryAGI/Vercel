
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDrainsResponseDrainsVariant2Item
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant1, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant3, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant4, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant5>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant1, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant3, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant4, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant5> Delivery { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainsResponseDrainsVariant2ItemDisabledReasonJsonConverter))]
        public global::Vercel.GetDrainsResponseDrainsVariant2ItemDisabledReason? DisabledReason { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.GetDrainsResponseDrainsVariant2ItemSamplingItem>? Sampling { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDrainsResponseDrainsVariant2ItemSchemas Schemas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetDrainsResponseDrainsVariant2ItemSourceVariant1, global::Vercel.GetDrainsResponseDrainsVariant2ItemSourceVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.GetDrainsResponseDrainsVariant2ItemSourceVariant1, global::Vercel.GetDrainsResponseDrainsVariant2ItemSourceVariant2> Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainsResponseDrainsVariant2ItemStatusJsonConverter))]
        public global::Vercel.GetDrainsResponseDrainsVariant2ItemStatus? Status { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterV2")]
        public global::Vercel.GetDrainsResponseDrainsVariant2ItemFilterV2? FilterV2 { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetDrainsResponseDrainsVariant2ItemProjectAccessVariant1, global::Vercel.GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2>))]
        public global::Vercel.OneOf<global::Vercel.GetDrainsResponseDrainsVariant2ItemProjectAccessVariant1, global::Vercel.GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2>? ProjectAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant2Item" /> class.
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
        /// <param name="filterV2"></param>
        /// <param name="integrationConfigurationUri"></param>
        /// <param name="integrationIcon"></param>
        /// <param name="integrationWebsite"></param>
        /// <param name="projectAccess"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDrainsResponseDrainsVariant2Item(
            double createdAt,
            global::Vercel.OneOf<global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant1, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant3, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant4, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant5> delivery,
            string id,
            string name,
            string ownerId,
            global::Vercel.GetDrainsResponseDrainsVariant2ItemSchemas schemas,
            global::Vercel.OneOf<global::Vercel.GetDrainsResponseDrainsVariant2ItemSourceVariant1, global::Vercel.GetDrainsResponseDrainsVariant2ItemSourceVariant2> source,
            double updatedAt,
            double? disabledAt,
            string? disabledBy,
            global::Vercel.GetDrainsResponseDrainsVariant2ItemDisabledReason? disabledReason,
            double? firstErrorTimestamp,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::Vercel.GetDrainsResponseDrainsVariant2ItemSamplingItem>? sampling,
            global::Vercel.GetDrainsResponseDrainsVariant2ItemStatus? status,
            string? teamId,
            global::Vercel.GetDrainsResponseDrainsVariant2ItemFilterV2? filterV2,
            string? integrationConfigurationUri,
            string? integrationIcon,
            string? integrationWebsite,
            global::Vercel.OneOf<global::Vercel.GetDrainsResponseDrainsVariant2ItemProjectAccessVariant1, global::Vercel.GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2>? projectAccess)
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
            this.FilterV2 = filterV2;
            this.IntegrationConfigurationUri = integrationConfigurationUri;
            this.IntegrationIcon = integrationIcon;
            this.IntegrationWebsite = integrationWebsite;
            this.ProjectAccess = projectAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant2Item" /> class.
        /// </summary>
        public GetDrainsResponseDrainsVariant2Item()
        {
        }

    }
}