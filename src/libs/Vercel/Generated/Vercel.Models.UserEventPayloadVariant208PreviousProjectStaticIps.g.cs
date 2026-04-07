
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant208PreviousProjectStaticIps
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        public bool? Builds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        public global::System.Collections.Generic.IList<string>? Regions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant208PreviousProjectStaticIps" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="builds"></param>
        /// <param name="regions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant208PreviousProjectStaticIps(
            bool enabled,
            bool? builds,
            global::System.Collections.Generic.IList<string>? regions)
        {
            this.Builds = builds;
            this.Enabled = enabled;
            this.Regions = regions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant208PreviousProjectStaticIps" /> class.
        /// </summary>
        public UserEventPayloadVariant208PreviousProjectStaticIps()
        {
        }
    }
}