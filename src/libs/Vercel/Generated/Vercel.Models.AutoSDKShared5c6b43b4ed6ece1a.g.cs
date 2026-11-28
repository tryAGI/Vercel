
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared5c6b43b4ed6ece1a
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Vercel.AutoSDKShared09054c8276f30cbf? Config { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared5c6b43b4ed6ece1a" /> class.
        /// </summary>
        /// <param name="use"></param>
        /// <param name="config"></param>
        /// <param name="src"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared5c6b43b4ed6ece1a(
            string use,
            global::Vercel.AutoSDKShared09054c8276f30cbf? config,
            string? src)
        {
            this.Config = config;
            this.Src = src;
            this.Use = use ?? throw new global::System.ArgumentNullException(nameof(use));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared5c6b43b4ed6ece1a" /> class.
        /// </summary>
        public AutoSDKShared5c6b43b4ed6ece1a()
        {
        }

    }
}