
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1TypeJsonConverter))]
        public global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1Project? Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log")]
        public global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1Log? Log { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1Deployment? Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="project"></param>
        /// <param name="log"></param>
        /// <param name="deployment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1(
            global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1Type type,
            global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1Project? project,
            global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1Log? log,
            global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1Deployment? deployment)
        {
            this.Type = type;
            this.Project = project;
            this.Log = log;
            this.Deployment = deployment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1" /> class.
        /// </summary>
        public GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1()
        {
        }
    }
}