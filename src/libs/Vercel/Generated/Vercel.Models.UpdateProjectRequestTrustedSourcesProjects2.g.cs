
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestTrustedSourcesProjects2
    {
        /// <summary>
        /// The label or description of the trusted source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Optional overrides for the default same-env-by-slug matching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customAllow")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItem>? CustomAllow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSourcesProjects2" /> class.
        /// </summary>
        /// <param name="label">
        /// The label or description of the trusted source
        /// </param>
        /// <param name="customAllow">
        /// Optional overrides for the default same-env-by-slug matching.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestTrustedSourcesProjects2(
            string? label,
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItem>? customAllow)
        {
            this.Label = label;
            this.CustomAllow = customAllow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSourcesProjects2" /> class.
        /// </summary>
        public UpdateProjectRequestTrustedSourcesProjects2()
        {
        }
    }
}