
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
    /// </summary>
    public sealed partial class AuthUserResourceConfigBuildEntitlements
    {
        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhancedBuilds")]
        public bool? EnhancedBuilds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserResourceConfigBuildEntitlements" /> class.
        /// </summary>
        /// <param name="enhancedBuilds">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserResourceConfigBuildEntitlements(
            bool? enhancedBuilds)
        {
            this.EnhancedBuilds = enhancedBuilds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserResourceConfigBuildEntitlements" /> class.
        /// </summary>
        public AuthUserResourceConfigBuildEntitlements()
        {
        }
    }
}