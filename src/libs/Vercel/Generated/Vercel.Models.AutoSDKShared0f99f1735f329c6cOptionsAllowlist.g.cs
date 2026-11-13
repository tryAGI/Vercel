
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0f99f1735f329c6cOptionsAllowlist
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f99f1735f329c6cOptionsAllowlistPath> Paths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f99f1735f329c6cOptionsAllowlist" /> class.
        /// </summary>
        /// <param name="paths"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0f99f1735f329c6cOptionsAllowlist(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f99f1735f329c6cOptionsAllowlistPath> paths)
        {
            this.Paths = paths ?? throw new global::System.ArgumentNullException(nameof(paths));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f99f1735f329c6cOptionsAllowlist" /> class.
        /// </summary>
        public AutoSDKShared0f99f1735f329c6cOptionsAllowlist()
        {
        }

    }
}