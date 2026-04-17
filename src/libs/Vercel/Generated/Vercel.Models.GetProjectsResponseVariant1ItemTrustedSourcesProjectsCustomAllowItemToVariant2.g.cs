
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The target envs on the current project that may be accessed.
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant2PresetJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant2Preset Preset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant2" /> class.
        /// </summary>
        /// <param name="preset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant2(
            global::Vercel.GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant2Preset preset)
        {
            this.Preset = preset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant2" /> class.
        /// </summary>
        public GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant2()
        {
        }
    }
}