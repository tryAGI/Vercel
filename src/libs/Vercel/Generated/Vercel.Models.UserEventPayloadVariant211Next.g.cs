
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant211Next
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skewProtectionMaxAge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SkewProtectionMaxAge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant211Next" /> class.
        /// </summary>
        /// <param name="skewProtectionMaxAge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant211Next(
            double skewProtectionMaxAge)
        {
            this.SkewProtectionMaxAge = skewProtectionMaxAge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant211Next" /> class.
        /// </summary>
        public UserEventPayloadVariant211Next()
        {
        }
    }
}