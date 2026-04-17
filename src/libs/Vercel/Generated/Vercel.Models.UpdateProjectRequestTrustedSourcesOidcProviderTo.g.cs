
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A set of environments, expressed as explicit slugs, a named preset, or both. At least one of `slugs` or `preset` must be set.
    /// </summary>
    public sealed partial class UpdateProjectRequestTrustedSourcesOidcProviderTo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slugs")]
        public global::System.Collections.Generic.IList<string>? Slugs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestTrustedSourcesOidcProviderToPresetJsonConverter))]
        public global::Vercel.UpdateProjectRequestTrustedSourcesOidcProviderToPreset? Preset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSourcesOidcProviderTo" /> class.
        /// </summary>
        /// <param name="slugs"></param>
        /// <param name="preset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestTrustedSourcesOidcProviderTo(
            global::System.Collections.Generic.IList<string>? slugs,
            global::Vercel.UpdateProjectRequestTrustedSourcesOidcProviderToPreset? preset)
        {
            this.Slugs = slugs;
            this.Preset = preset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSourcesOidcProviderTo" /> class.
        /// </summary>
        public UpdateProjectRequestTrustedSourcesOidcProviderTo()
        {
        }
    }
}