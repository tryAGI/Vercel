
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDrainRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainRequestProjectsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDrainRequestProjects Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        public global::System.Collections.Generic.IList<string>? ProjectIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CreateDrainRequestFilter>))]
        public global::Vercel.OneOf<string, global::Vercel.CreateDrainRequestFilter>? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateDrainRequestSchemas2> Schemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateDrainRequestDeliveryVariant1, global::Vercel.CreateDrainRequestDeliveryVariant2>))]
        public global::Vercel.OneOf<global::Vercel.CreateDrainRequestDeliveryVariant1, global::Vercel.CreateDrainRequestDeliveryVariant2>? Delivery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateDrainRequestSamplingItem>? Sampling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transforms")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateDrainRequestTransform>? Transforms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.OneOf<global::Vercel.CreateDrainRequestSourceVariant1, global::Vercel.CreateDrainRequestSourceVariant2, global::Vercel.CreateDrainRequestSourceVariant3>?, global::Vercel.CreateDrainRequestSource2>))]
        public global::Vercel.OneOf<global::Vercel.OneOf<global::Vercel.CreateDrainRequestSourceVariant1, global::Vercel.CreateDrainRequestSourceVariant2, global::Vercel.CreateDrainRequestSourceVariant3>?, global::Vercel.CreateDrainRequestSource2>? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projects"></param>
        /// <param name="schemas"></param>
        /// <param name="projectIds"></param>
        /// <param name="filter"></param>
        /// <param name="delivery"></param>
        /// <param name="sampling"></param>
        /// <param name="transforms"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDrainRequest(
            string name,
            global::Vercel.CreateDrainRequestProjects projects,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateDrainRequestSchemas2> schemas,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::Vercel.OneOf<string, global::Vercel.CreateDrainRequestFilter>? filter,
            global::Vercel.OneOf<global::Vercel.CreateDrainRequestDeliveryVariant1, global::Vercel.CreateDrainRequestDeliveryVariant2>? delivery,
            global::System.Collections.Generic.IList<global::Vercel.CreateDrainRequestSamplingItem>? sampling,
            global::System.Collections.Generic.IList<global::Vercel.CreateDrainRequestTransform>? transforms,
            global::Vercel.OneOf<global::Vercel.OneOf<global::Vercel.CreateDrainRequestSourceVariant1, global::Vercel.CreateDrainRequestSourceVariant2, global::Vercel.CreateDrainRequestSourceVariant3>?, global::Vercel.CreateDrainRequestSource2>? source)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Projects = projects;
            this.ProjectIds = projectIds;
            this.Filter = filter;
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.Delivery = delivery;
            this.Sampling = sampling;
            this.Transforms = transforms;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainRequest" /> class.
        /// </summary>
        public CreateDrainRequest()
        {
        }
    }
}