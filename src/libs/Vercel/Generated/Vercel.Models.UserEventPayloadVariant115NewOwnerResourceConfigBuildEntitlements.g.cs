
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant115NewOwnerResourceConfigBuildEntitlements
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhancedBuilds")]
        public bool? EnhancedBuilds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerResourceConfigBuildEntitlements" /> class.
        /// </summary>
        /// <param name="enhancedBuilds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant115NewOwnerResourceConfigBuildEntitlements(
            bool? enhancedBuilds)
        {
            this.EnhancedBuilds = enhancedBuilds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerResourceConfigBuildEntitlements" /> class.
        /// </summary>
        public UserEventPayloadVariant115NewOwnerResourceConfigBuildEntitlements()
        {
        }
    }
}