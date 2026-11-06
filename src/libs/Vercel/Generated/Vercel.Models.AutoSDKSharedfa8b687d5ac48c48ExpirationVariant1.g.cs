
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedfa8b687d5ac48c48ExpirationVariant1
    {
        /// <summary>
        /// Unix ms timestamp when the project is scheduled to expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfa8b687d5ac48c48ExpirationVariant1" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// Unix ms timestamp when the project is scheduled to expire.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedfa8b687d5ac48c48ExpirationVariant1(
            double expiresAt)
        {
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfa8b687d5ac48c48ExpirationVariant1" /> class.
        /// </summary>
        public AutoSDKSharedfa8b687d5ac48c48ExpirationVariant1()
        {
        }

    }
}