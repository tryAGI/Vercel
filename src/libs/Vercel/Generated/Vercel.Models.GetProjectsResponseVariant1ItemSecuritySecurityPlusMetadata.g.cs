
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1ItemSecuritySecurityPlusMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Timestamp when the feature was first enabled. Never changes after initial enablement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstEnabledAt")]
        public double? FirstEnabledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecuritySecurityPlusMetadata" /> class.
        /// </summary>
        /// <param name="updatedAt"></param>
        /// <param name="firstEnabledAt">
        /// Timestamp when the feature was first enabled. Never changes after initial enablement.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant1ItemSecuritySecurityPlusMetadata(
            double updatedAt,
            double? firstEnabledAt)
        {
            this.UpdatedAt = updatedAt;
            this.FirstEnabledAt = firstEnabledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecuritySecurityPlusMetadata" /> class.
        /// </summary>
        public GetProjectsResponseVariant1ItemSecuritySecurityPlusMetadata()
        {
        }
    }
}