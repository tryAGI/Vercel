
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant209Next
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skewProtectionAllowedDomains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SkewProtectionAllowedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant209Next" /> class.
        /// </summary>
        /// <param name="skewProtectionAllowedDomains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant209Next(
            global::System.Collections.Generic.IList<string> skewProtectionAllowedDomains)
        {
            this.SkewProtectionAllowedDomains = skewProtectionAllowedDomains ?? throw new global::System.ArgumentNullException(nameof(skewProtectionAllowedDomains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant209Next" /> class.
        /// </summary>
        public UserEventPayloadVariant209Next()
        {
        }
    }
}