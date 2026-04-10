
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Note that not all historical events have this field.
    /// </summary>
    public sealed partial class UserEventPayloadVariant30App
    {
        /// <summary>
        /// The App's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The App's name at the moment this even was published (it may have changed since then).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant30App" /> class.
        /// </summary>
        /// <param name="id">
        /// The App's ID.
        /// </param>
        /// <param name="name">
        /// The App's name at the moment this even was published (it may have changed since then).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant30App(
            string id,
            string name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant30App" /> class.
        /// </summary>
        public UserEventPayloadVariant30App()
        {
        }
    }
}