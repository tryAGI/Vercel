
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede870b907cc1fb37eExpirationVariant1
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
        /// Initializes a new instance of the <see cref="AutoSDKSharede870b907cc1fb37eExpirationVariant1" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// Unix ms timestamp when the project is scheduled to expire.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede870b907cc1fb37eExpirationVariant1(
            double expiresAt)
        {
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede870b907cc1fb37eExpirationVariant1" /> class.
        /// </summary>
        public AutoSDKSharede870b907cc1fb37eExpirationVariant1()
        {
        }

    }
}