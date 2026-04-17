
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The target envs on the current project that may be accessed.
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectTrustedSourcesOidcProviderToVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectTrustedSourcesOidcProviderToVariant2PresetJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectTrustedSourcesOidcProviderToVariant2Preset Preset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectTrustedSourcesOidcProviderToVariant2" /> class.
        /// </summary>
        /// <param name="preset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectTrustedSourcesOidcProviderToVariant2(
            global::Vercel.GetProjectsResponseVariant3ProjectTrustedSourcesOidcProviderToVariant2Preset preset)
        {
            this.Preset = preset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectTrustedSourcesOidcProviderToVariant2" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectTrustedSourcesOidcProviderToVariant2()
        {
        }
    }
}