
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDrainRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDrainRequestProjectsJsonConverter))]
        public global::Vercel.UpdateDrainRequestProjects? Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        public global::System.Collections.Generic.IList<string>? ProjectIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.UpdateDrainRequestFilter>))]
        public global::Vercel.OneOf<string, global::Vercel.UpdateDrainRequestFilter>? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateDrainRequestSchemas2>? Schemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateDrainRequestDeliveryVariant1, global::Vercel.UpdateDrainRequestDeliveryVariant2>))]
        public global::Vercel.OneOf<global::Vercel.UpdateDrainRequestDeliveryVariant1, global::Vercel.UpdateDrainRequestDeliveryVariant2>? Delivery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateDrainRequestSamplingItem>? Sampling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transforms")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateDrainRequestTransform>? Transforms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDrainRequestStatusJsonConverter))]
        public global::Vercel.UpdateDrainRequestStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.OneOf<global::Vercel.UpdateDrainRequestSourceVariant1, global::Vercel.UpdateDrainRequestSourceVariant2, global::Vercel.UpdateDrainRequestSourceVariant3>?, global::Vercel.UpdateDrainRequestSource2>))]
        public global::Vercel.OneOf<global::Vercel.OneOf<global::Vercel.UpdateDrainRequestSourceVariant1, global::Vercel.UpdateDrainRequestSourceVariant2, global::Vercel.UpdateDrainRequestSourceVariant3>?, global::Vercel.UpdateDrainRequestSource2>? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projects"></param>
        /// <param name="projectIds"></param>
        /// <param name="filter"></param>
        /// <param name="schemas"></param>
        /// <param name="delivery"></param>
        /// <param name="sampling"></param>
        /// <param name="transforms"></param>
        /// <param name="status"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDrainRequest(
            string? name,
            global::Vercel.UpdateDrainRequestProjects? projects,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::Vercel.OneOf<string, global::Vercel.UpdateDrainRequestFilter>? filter,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateDrainRequestSchemas2>? schemas,
            global::Vercel.OneOf<global::Vercel.UpdateDrainRequestDeliveryVariant1, global::Vercel.UpdateDrainRequestDeliveryVariant2>? delivery,
            global::System.Collections.Generic.IList<global::Vercel.UpdateDrainRequestSamplingItem>? sampling,
            global::System.Collections.Generic.IList<global::Vercel.UpdateDrainRequestTransform>? transforms,
            global::Vercel.UpdateDrainRequestStatus? status,
            global::Vercel.OneOf<global::Vercel.OneOf<global::Vercel.UpdateDrainRequestSourceVariant1, global::Vercel.UpdateDrainRequestSourceVariant2, global::Vercel.UpdateDrainRequestSourceVariant3>?, global::Vercel.UpdateDrainRequestSource2>? source)
        {
            this.Name = name;
            this.Projects = projects;
            this.ProjectIds = projectIds;
            this.Filter = filter;
            this.Schemas = schemas;
            this.Delivery = delivery;
            this.Sampling = sampling;
            this.Transforms = transforms;
            this.Status = status;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainRequest" /> class.
        /// </summary>
        public UpdateDrainRequest()
        {
        }
    }
}