
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The source envs on the trusted project that are allowed to access `to`.
    /// </summary>
    public sealed partial class GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant2PresetJsonConverter))]
        public global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant2Preset Preset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant2" /> class.
        /// </summary>
        /// <param name="preset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant2(
            global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant2Preset preset)
        {
            this.Preset = preset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant2" /> class.
        /// </summary>
        public GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant2()
        {
        }
    }
}