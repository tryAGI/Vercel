
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedbe3f0c688bc34a31VercelFlags
    {
        /// <summary>
        /// When Flags were enabled for the project, taken from the Flags settings row's `createdAt`. Recorded by `@api/api-feature-flags` on flags sync.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledAt")]
        public double? EnabledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbe3f0c688bc34a31VercelFlags" /> class.
        /// </summary>
        /// <param name="enabledAt">
        /// When Flags were enabled for the project, taken from the Flags settings row's `createdAt`. Recorded by `@api/api-feature-flags` on flags sync.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedbe3f0c688bc34a31VercelFlags(
            double? enabledAt)
        {
            this.EnabledAt = enabledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbe3f0c688bc34a31VercelFlags" /> class.
        /// </summary>
        public AutoSDKSharedbe3f0c688bc34a31VercelFlags()
        {
        }

    }
}