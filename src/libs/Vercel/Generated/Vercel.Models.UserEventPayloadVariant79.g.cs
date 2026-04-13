
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant79
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
        [global::System.Text.Json.Serialization.JsonPropertyName("cdnEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CdnEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant79" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cdnEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant79(
            string name,
            bool cdnEnabled)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CdnEnabled = cdnEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant79" /> class.
        /// </summary>
        public UserEventPayloadVariant79()
        {
        }
    }
}