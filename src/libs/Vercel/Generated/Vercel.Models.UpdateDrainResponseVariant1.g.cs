
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDrainResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        public global::System.Collections.Generic.IList<string>? ProjectIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDrainResponseVariant1StatusJsonConverter))]
        public global::Vercel.UpdateDrainResponseVariant1Status? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstErrorTimestamp")]
        public double? FirstErrorTimestamp { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDrainResponseVariant1DisabledReasonJsonConverter))]
        public global::Vercel.UpdateDrainResponseVariant1DisabledReason? DisabledReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateDrainResponseVariant1Schemas Schemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateDrainResponseVariant1DeliveryVariant1, global::Vercel.UpdateDrainResponseVariant1DeliveryVariant2, global::Vercel.UpdateDrainResponseVariant1DeliveryVariant3, global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.UpdateDrainResponseVariant1DeliveryVariant1, global::Vercel.UpdateDrainResponseVariant1DeliveryVariant2, global::Vercel.UpdateDrainResponseVariant1DeliveryVariant3, global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4> Delivery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateDrainResponseVariant1SamplingItem>? Sampling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateDrainResponseVariant1SourceVariant1, global::Vercel.UpdateDrainResponseVariant1SourceVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.UpdateDrainResponseVariant1SourceVariant1, global::Vercel.UpdateDrainResponseVariant1SourceVariant2> Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterV2")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateDrainResponseVariant1FilterV2Variant1, global::Vercel.UpdateDrainResponseVariant1FilterV2Variant2>))]
        public global::Vercel.OneOf<global::Vercel.UpdateDrainResponseVariant1FilterV2Variant1, global::Vercel.UpdateDrainResponseVariant1FilterV2Variant2>? FilterV2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainResponseVariant1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="name"></param>
        /// <param name="ownerId"></param>
        /// <param name="schemas"></param>
        /// <param name="delivery"></param>
        /// <param name="source"></param>
        /// <param name="projectIds"></param>
        /// <param name="teamId"></param>
        /// <param name="status"></param>
        /// <param name="firstErrorTimestamp"></param>
        /// <param name="disabledAt"></param>
        /// <param name="disabledBy"></param>
        /// <param name="disabledReason"></param>
        /// <param name="sampling"></param>
        /// <param name="filter"></param>
        /// <param name="filterV2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDrainResponseVariant1(
            string id,
            double createdAt,
            double updatedAt,
            string name,
            string ownerId,
            global::Vercel.UpdateDrainResponseVariant1Schemas schemas,
            global::Vercel.OneOf<global::Vercel.UpdateDrainResponseVariant1DeliveryVariant1, global::Vercel.UpdateDrainResponseVariant1DeliveryVariant2, global::Vercel.UpdateDrainResponseVariant1DeliveryVariant3, global::Vercel.UpdateDrainResponseVariant1DeliveryVariant4> delivery,
            global::Vercel.OneOf<global::Vercel.UpdateDrainResponseVariant1SourceVariant1, global::Vercel.UpdateDrainResponseVariant1SourceVariant2> source,
            global::System.Collections.Generic.IList<string>? projectIds,
            string? teamId,
            global::Vercel.UpdateDrainResponseVariant1Status? status,
            double? firstErrorTimestamp,
            double? disabledAt,
            string? disabledBy,
            global::Vercel.UpdateDrainResponseVariant1DisabledReason? disabledReason,
            global::System.Collections.Generic.IList<global::Vercel.UpdateDrainResponseVariant1SamplingItem>? sampling,
            string? filter,
            global::Vercel.OneOf<global::Vercel.UpdateDrainResponseVariant1FilterV2Variant1, global::Vercel.UpdateDrainResponseVariant1FilterV2Variant2>? filterV2)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectIds = projectIds;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TeamId = teamId;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Status = status;
            this.FirstErrorTimestamp = firstErrorTimestamp;
            this.DisabledAt = disabledAt;
            this.DisabledBy = disabledBy;
            this.DisabledReason = disabledReason;
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.Delivery = delivery;
            this.Sampling = sampling;
            this.Source = source;
            this.Filter = filter;
            this.FilterV2 = filterV2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainResponseVariant1" /> class.
        /// </summary>
        public UpdateDrainResponseVariant1()
        {
        }
    }
}