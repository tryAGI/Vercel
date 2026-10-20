
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0c2476a65d8295caProjectSettingsVercelFlags
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledAt")]
        public double? EnabledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0c2476a65d8295caProjectSettingsVercelFlags" /> class.
        /// </summary>
        /// <param name="enabledAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0c2476a65d8295caProjectSettingsVercelFlags(
            double? enabledAt)
        {
            this.EnabledAt = enabledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0c2476a65d8295caProjectSettingsVercelFlags" /> class.
        /// </summary>
        public AutoSDKShared0c2476a65d8295caProjectSettingsVercelFlags()
        {
        }

    }
}