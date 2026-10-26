
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateProjectResponseVercelFlags
    {
        /// <summary>
        /// When Flags were enabled for the project, taken from the Flags settings row's `createdAt`. Recorded by `@api/api-feature-flags` on flags sync.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledAt")]
        public double? EnabledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseVercelFlags" /> class.
        /// </summary>
        /// <param name="enabledAt">
        /// When Flags were enabled for the project, taken from the Flags settings row's `createdAt`. Recorded by `@api/api-feature-flags` on flags sync.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseVercelFlags(
            double? enabledAt)
        {
            this.EnabledAt = enabledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseVercelFlags" /> class.
        /// </summary>
        public UpdateProjectResponseVercelFlags()
        {
        }

    }
}