
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectResponseTrustedSourcesProjects2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Optional overrides for the default same-env-by-slug matching. Provide explicit rules to allow cross-env access or presets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customAllow")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseTrustedSourcesProjectsCustomAllowItem>? CustomAllow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseTrustedSourcesProjects2" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="customAllow">
        /// Optional overrides for the default same-env-by-slug matching. Provide explicit rules to allow cross-env access or presets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectResponseTrustedSourcesProjects2(
            string? label,
            global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseTrustedSourcesProjectsCustomAllowItem>? customAllow)
        {
            this.Label = label;
            this.CustomAllow = customAllow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseTrustedSourcesProjects2" /> class.
        /// </summary>
        public CreateProjectResponseTrustedSourcesProjects2()
        {
        }
    }
}