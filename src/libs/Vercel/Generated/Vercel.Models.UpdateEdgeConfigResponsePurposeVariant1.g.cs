
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateEdgeConfigResponsePurposeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateEdgeConfigResponsePurposeVariant1TypeJsonConverter))]
        public global::Vercel.UpdateEdgeConfigResponsePurposeVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEdgeConfigResponsePurposeVariant1" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEdgeConfigResponsePurposeVariant1(
            string projectId,
            global::Vercel.UpdateEdgeConfigResponsePurposeVariant1Type type)
        {
            this.Type = type;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEdgeConfigResponsePurposeVariant1" /> class.
        /// </summary>
        public UpdateEdgeConfigResponsePurposeVariant1()
        {
        }
    }
}