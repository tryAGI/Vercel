
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The source envs on the trusted project that are allowed to access `to`.
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectTrustedSourcesProjectsCustomAllowItemFromVariant1
    {
        /// <summary>
        /// System environment slugs (`production`, `preview`) and/or custom environment slugs defined on the referenced project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slugs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Slugs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectTrustedSourcesProjectsCustomAllowItemFromVariant1" /> class.
        /// </summary>
        /// <param name="slugs">
        /// System environment slugs (`production`, `preview`) and/or custom environment slugs defined on the referenced project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectTrustedSourcesProjectsCustomAllowItemFromVariant1(
            global::System.Collections.Generic.IList<string> slugs)
        {
            this.Slugs = slugs ?? throw new global::System.ArgumentNullException(nameof(slugs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectTrustedSourcesProjectsCustomAllowItemFromVariant1" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectTrustedSourcesProjectsCustomAllowItemFromVariant1()
        {
        }
    }
}