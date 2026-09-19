
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The target envs on the current project that may be accessed.
    /// </summary>
    public sealed partial class UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2PresetJsonConverter))]
        public global::Vercel.UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2Preset Preset { get; set; }

        /// <summary>
        /// System environment slugs (`production`, `preview`) and/or custom environment slugs defined on the referenced project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slugs")]
        public global::System.Collections.Generic.IList<string>? Slugs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2" /> class.
        /// </summary>
        /// <param name="preset"></param>
        /// <param name="slugs">
        /// System environment slugs (`production`, `preview`) and/or custom environment slugs defined on the referenced project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2(
            global::Vercel.UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2Preset preset,
            global::System.Collections.Generic.IList<string>? slugs)
        {
            this.Preset = preset;
            this.Slugs = slugs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2" /> class.
        /// </summary>
        public UploadProjectAvatarResponseTrustedSourcesOidcProviderToVariant2()
        {
        }

    }
}