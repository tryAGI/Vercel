
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedcdaac4bd3d3c6643ProjectSettingsVercelFlags
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
        /// Initializes a new instance of the <see cref="AutoSDKSharedcdaac4bd3d3c6643ProjectSettingsVercelFlags" /> class.
        /// </summary>
        /// <param name="enabledAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedcdaac4bd3d3c6643ProjectSettingsVercelFlags(
            double? enabledAt)
        {
            this.EnabledAt = enabledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedcdaac4bd3d3c6643ProjectSettingsVercelFlags" /> class.
        /// </summary>
        public AutoSDKSharedcdaac4bd3d3c6643ProjectSettingsVercelFlags()
        {
        }

    }
}