
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Custom environments available on the project. This list can include environments where the connector is not enabled.
    /// </summary>
    public sealed partial class ConnectProjectConnectionProjectCustomEnvironment
    {
        /// <summary>
        /// Stable custom environment ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Current human-readable custom environment slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectProjectConnectionProjectCustomEnvironment" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable custom environment ID.
        /// </param>
        /// <param name="slug">
        /// Current human-readable custom environment slug.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectProjectConnectionProjectCustomEnvironment(
            string id,
            string slug)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectProjectConnectionProjectCustomEnvironment" /> class.
        /// </summary>
        public ConnectProjectConnectionProjectCustomEnvironment()
        {
        }

    }
}