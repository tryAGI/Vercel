
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional expansions populated by `?include=...` on the list endpoint.
    /// </summary>
    public sealed partial class CreateConnectorResponseIncludes
    {
        /// <summary>
        /// Set by `?include=projects`. Capped at 100 per client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::Vercel.CreateConnectorResponseIncludesProjects? Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseIncludes" /> class.
        /// </summary>
        /// <param name="projects">
        /// Set by `?include=projects`. Capped at 100 per client.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorResponseIncludes(
            global::Vercel.CreateConnectorResponseIncludesProjects? projects)
        {
            this.Projects = projects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseIncludes" /> class.
        /// </summary>
        public CreateConnectorResponseIncludes()
        {
        }

    }
}