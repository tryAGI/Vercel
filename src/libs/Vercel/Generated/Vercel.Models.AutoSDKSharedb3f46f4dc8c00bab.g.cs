
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedb3f46f4dc8c00bab
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Vercel.AutoSDKShared4fe620b22113d16c? Config { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharedb3f46f4dc8c00bab" /> class.
        /// </summary>
        /// <param name="use"></param>
        /// <param name="config"></param>
        /// <param name="src"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedb3f46f4dc8c00bab(
            string use,
            global::Vercel.AutoSDKShared4fe620b22113d16c? config,
            string? src)
        {
            this.Config = config;
            this.Src = src;
            this.Use = use ?? throw new global::System.ArgumentNullException(nameof(use));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb3f46f4dc8c00bab" /> class.
        /// </summary>
        public AutoSDKSharedb3f46f4dc8c00bab()
        {
        }

    }
}