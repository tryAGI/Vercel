
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant125Prev
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackEnvironment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FallbackEnvironment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant125Prev" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="fallbackEnvironment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant125Prev(
            string name,
            string slug,
            string fallbackEnvironment)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.FallbackEnvironment = fallbackEnvironment ?? throw new global::System.ArgumentNullException(nameof(fallbackEnvironment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant125Prev" /> class.
        /// </summary>
        public UserEventPayloadVariant125Prev()
        {
        }
    }
}