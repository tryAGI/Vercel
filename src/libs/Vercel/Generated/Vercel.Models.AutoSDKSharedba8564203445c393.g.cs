
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedba8564203445c393
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Vercel.AutoSDKShared1aa9bcb064b99411? Config { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharedba8564203445c393" /> class.
        /// </summary>
        /// <param name="use"></param>
        /// <param name="config"></param>
        /// <param name="src"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedba8564203445c393(
            string use,
            global::Vercel.AutoSDKShared1aa9bcb064b99411? config,
            string? src)
        {
            this.Config = config;
            this.Src = src;
            this.Use = use ?? throw new global::System.ArgumentNullException(nameof(use));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedba8564203445c393" /> class.
        /// </summary>
        public AutoSDKSharedba8564203445c393()
        {
        }

    }
}