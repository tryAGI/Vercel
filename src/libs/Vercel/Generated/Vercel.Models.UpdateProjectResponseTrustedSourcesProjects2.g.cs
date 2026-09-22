
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateProjectResponseTrustedSourcesProjects2
    {
        /// <summary>
        /// Optional overrides for the default same-env-by-slug matching. Provide explicit rules to allow cross-env access or presets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customAllow")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateProjectResponseTrustedSourcesProjectsCustomAllowItem>? CustomAllow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseTrustedSourcesProjects2" /> class.
        /// </summary>
        /// <param name="customAllow">
        /// Optional overrides for the default same-env-by-slug matching. Provide explicit rules to allow cross-env access or presets.
        /// </param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseTrustedSourcesProjects2(
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectResponseTrustedSourcesProjectsCustomAllowItem>? customAllow,
            string? label)
        {
            this.CustomAllow = customAllow;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseTrustedSourcesProjects2" /> class.
        /// </summary>
        public UpdateProjectResponseTrustedSourcesProjects2()
        {
        }

    }
}