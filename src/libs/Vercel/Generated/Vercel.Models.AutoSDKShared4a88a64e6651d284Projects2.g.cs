
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared4a88a64e6651d284Projects2
    {
        /// <summary>
        /// Optional overrides for the default same-env-by-slug matching. Provide explicit rules to allow cross-env access or presets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customAllow")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItem>? CustomAllow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4a88a64e6651d284Projects2" /> class.
        /// </summary>
        /// <param name="customAllow">
        /// Optional overrides for the default same-env-by-slug matching. Provide explicit rules to allow cross-env access or presets.
        /// </param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared4a88a64e6651d284Projects2(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItem>? customAllow,
            string? label)
        {
            this.CustomAllow = customAllow;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4a88a64e6651d284Projects2" /> class.
        /// </summary>
        public AutoSDKShared4a88a64e6651d284Projects2()
        {
        }

    }
}