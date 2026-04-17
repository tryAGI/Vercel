
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The target envs on the current project that may be accessed.
    /// </summary>
    public sealed partial class UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1
    {
        /// <summary>
        /// System environment slugs (`production`, `preview`) and/or custom environment slugs defined on the referenced project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slugs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Slugs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1PresetJsonConverter))]
        public global::Vercel.UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset? Preset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1" /> class.
        /// </summary>
        /// <param name="slugs">
        /// System environment slugs (`production`, `preview`) and/or custom environment slugs defined on the referenced project.
        /// </param>
        /// <param name="preset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1(
            global::System.Collections.Generic.IList<string> slugs,
            global::Vercel.UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset? preset)
        {
            this.Slugs = slugs ?? throw new global::System.ArgumentNullException(nameof(slugs));
            this.Preset = preset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1" /> class.
        /// </summary>
        public UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1()
        {
        }
    }
}