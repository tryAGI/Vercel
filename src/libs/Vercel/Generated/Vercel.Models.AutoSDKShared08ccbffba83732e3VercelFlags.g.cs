
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Vercel Flags activation metadata copied from the project at deployment creation.
    /// </summary>
    public sealed partial class AutoSDKShared08ccbffba83732e3VercelFlags
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
        /// Initializes a new instance of the <see cref="AutoSDKShared08ccbffba83732e3VercelFlags" /> class.
        /// </summary>
        /// <param name="enabledAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared08ccbffba83732e3VercelFlags(
            double? enabledAt)
        {
            this.EnabledAt = enabledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared08ccbffba83732e3VercelFlags" /> class.
        /// </summary>
        public AutoSDKShared08ccbffba83732e3VercelFlags()
        {
        }

    }
}