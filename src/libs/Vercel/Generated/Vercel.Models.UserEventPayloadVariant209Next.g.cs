
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
        [global::System.Text.Json.Serialization.JsonPropertyName("skewProtectionBoundaryAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SkewProtectionBoundaryAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant209Next" /> class.
        /// </summary>
        /// <param name="skewProtectionBoundaryAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant209Next(
            double skewProtectionBoundaryAt)
        {
            this.SkewProtectionBoundaryAt = skewProtectionBoundaryAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant209Next" /> class.
        /// </summary>
        public UserEventPayloadVariant209Next()
        {
        }
    }
}