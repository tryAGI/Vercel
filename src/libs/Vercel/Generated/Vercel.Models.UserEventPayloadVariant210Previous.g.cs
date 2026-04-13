
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant210Previous
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skewProtectionMaxAge")]
        public double? SkewProtectionMaxAge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant210Previous" /> class.
        /// </summary>
        /// <param name="skewProtectionMaxAge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant210Previous(
            double? skewProtectionMaxAge)
        {
            this.SkewProtectionMaxAge = skewProtectionMaxAge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant210Previous" /> class.
        /// </summary>
        public UserEventPayloadVariant210Previous()
        {
        }
    }
}