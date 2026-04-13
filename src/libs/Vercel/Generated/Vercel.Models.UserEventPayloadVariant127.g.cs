
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant127
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackEnvironment")]
        public string? FallbackEnvironment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant127Prev Prev { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant127" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prev"></param>
        /// <param name="slug"></param>
        /// <param name="name"></param>
        /// <param name="fallbackEnvironment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant127(
            string id,
            global::Vercel.UserEventPayloadVariant127Prev prev,
            string? slug,
            string? name,
            string? fallbackEnvironment)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug;
            this.Name = name;
            this.FallbackEnvironment = fallbackEnvironment;
            this.Prev = prev ?? throw new global::System.ArgumentNullException(nameof(prev));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant127" /> class.
        /// </summary>
        public UserEventPayloadVariant127()
        {
        }
    }
}