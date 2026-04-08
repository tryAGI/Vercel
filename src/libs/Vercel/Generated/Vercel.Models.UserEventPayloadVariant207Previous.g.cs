
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant207Previous
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skewProtectionAllowedDomains")]
        public global::System.Collections.Generic.IList<string>? SkewProtectionAllowedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant207Previous" /> class.
        /// </summary>
        /// <param name="skewProtectionAllowedDomains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant207Previous(
            global::System.Collections.Generic.IList<string>? skewProtectionAllowedDomains)
        {
            this.SkewProtectionAllowedDomains = skewProtectionAllowedDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant207Previous" /> class.
        /// </summary>
        public UserEventPayloadVariant207Previous()
        {
        }
    }
}