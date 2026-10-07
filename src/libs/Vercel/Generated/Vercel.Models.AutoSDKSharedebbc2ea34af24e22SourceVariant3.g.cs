
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedebbc2ea34af24e22SourceVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalCheckName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalCheckName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedebbc2ea34af24e22SourceVariant3KindJsonConverter))]
        public global::Vercel.AutoSDKSharedebbc2ea34af24e22SourceVariant3Kind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedebbc2ea34af24e22SourceVariant3ProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedebbc2ea34af24e22SourceVariant3Provider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedebbc2ea34af24e22SourceVariant3" /> class.
        /// </summary>
        /// <param name="externalCheckName"></param>
        /// <param name="provider"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedebbc2ea34af24e22SourceVariant3(
            string externalCheckName,
            global::Vercel.AutoSDKSharedebbc2ea34af24e22SourceVariant3Provider provider,
            global::Vercel.AutoSDKSharedebbc2ea34af24e22SourceVariant3Kind kind)
        {
            this.ExternalCheckName = externalCheckName ?? throw new global::System.ArgumentNullException(nameof(externalCheckName));
            this.Kind = kind;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedebbc2ea34af24e22SourceVariant3" /> class.
        /// </summary>
        public AutoSDKSharedebbc2ea34af24e22SourceVariant3()
        {
        }

    }
}