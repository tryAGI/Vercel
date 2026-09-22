
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9c06dfe8dd59ad6d
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant2, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant3, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant5>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant2, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant3, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant5> Delivery { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9c06dfe8dd59ad6dDisabledReasonJsonConverter))]
        public global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDisabledReason? DisabledReason { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9c06dfe8dd59ad6dSamplingItem>? Sampling { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared9c06dfe8dd59ad6dSchemas Schemas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared9c06dfe8dd59ad6dSourceVariant1, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dSourceVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared9c06dfe8dd59ad6dSourceVariant1, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dSourceVariant2> Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9c06dfe8dd59ad6dStatusJsonConverter))]
        public global::Vercel.AutoSDKShared9c06dfe8dd59ad6dStatus? Status { get; set; }

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
        public global::Vercel.AutoSDKShared9c06dfe8dd59ad6dFilterV2? FilterV2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9c06dfe8dd59ad6d" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9c06dfe8dd59ad6d(
            double createdAt,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant2, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant3, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant5> delivery,
            string id,
            string name,
            string ownerId,
            global::Vercel.AutoSDKShared9c06dfe8dd59ad6dSchemas schemas,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared9c06dfe8dd59ad6dSourceVariant1, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dSourceVariant2> source,
            double updatedAt,
            double? disabledAt,
            string? disabledBy,
            global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDisabledReason? disabledReason,
            double? firstErrorTimestamp,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9c06dfe8dd59ad6dSamplingItem>? sampling,
            global::Vercel.AutoSDKShared9c06dfe8dd59ad6dStatus? status,
            string? teamId,
            global::Vercel.AutoSDKShared9c06dfe8dd59ad6dFilterV2? filterV2)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9c06dfe8dd59ad6d" /> class.
        /// </summary>
        public AutoSDKShared9c06dfe8dd59ad6d()
        {
        }

    }
}