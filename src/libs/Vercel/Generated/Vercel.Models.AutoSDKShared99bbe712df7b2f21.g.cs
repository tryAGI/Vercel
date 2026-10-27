
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Builder selected by the resolver.
    /// </summary>
    public sealed partial class AutoSDKShared99bbe712df7b2f21
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Vercel.AutoSDKShared7b4496b51f78123b? Config { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Use { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared99bbe712df7b2f21" /> class.
        /// </summary>
        /// <param name="use"></param>
        /// <param name="config"></param>
        /// <param name="src"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared99bbe712df7b2f21(
            string use,
            global::Vercel.AutoSDKShared7b4496b51f78123b? config,
            string? src)
        {
            this.Config = config;
            this.Src = src;
            this.Use = use ?? throw new global::System.ArgumentNullException(nameof(use));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared99bbe712df7b2f21" /> class.
        /// </summary>
        public AutoSDKShared99bbe712df7b2f21()
        {
        }

    }
}