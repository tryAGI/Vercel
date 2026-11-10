
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ForkDriveV1Request
    {
        /// <summary>
        /// Name for the forked drive. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: workspace-fork
        /// </summary>
        /// <example>workspace-fork</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForkDriveV1Request" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the forked drive. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: workspace-fork
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForkDriveV1Request(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForkDriveV1Request" /> class.
        /// </summary>
        public ForkDriveV1Request()
        {
        }

    }
}