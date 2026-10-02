
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf435ee41818aa67d
    {
        /// <summary>
        /// Optional overrides for the default same-env-by-slug matching. Provide explicit rules to allow cross-env access or presets. An empty array denies all access and is only allowed for the current project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customAllow")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared31ad55d5a9d0e802Item>? CustomAllow { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharedf435ee41818aa67d" /> class.
        /// </summary>
        /// <param name="customAllow">
        /// Optional overrides for the default same-env-by-slug matching. Provide explicit rules to allow cross-env access or presets. An empty array denies all access and is only allowed for the current project.
        /// </param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf435ee41818aa67d(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared31ad55d5a9d0e802Item>? customAllow,
            string? label)
        {
            this.CustomAllow = customAllow;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf435ee41818aa67d" /> class.
        /// </summary>
        public AutoSDKSharedf435ee41818aa67d()
        {
        }

    }
}