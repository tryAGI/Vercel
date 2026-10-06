
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared12773eaec07789a9SourceVariant3
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared12773eaec07789a9SourceVariant3KindJsonConverter))]
        public global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant3Kind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared12773eaec07789a9SourceVariant3ProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant3Provider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared12773eaec07789a9SourceVariant3" /> class.
        /// </summary>
        /// <param name="externalCheckName"></param>
        /// <param name="provider"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared12773eaec07789a9SourceVariant3(
            string externalCheckName,
            global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant3Provider provider,
            global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant3Kind kind)
        {
            this.ExternalCheckName = externalCheckName ?? throw new global::System.ArgumentNullException(nameof(externalCheckName));
            this.Kind = kind;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared12773eaec07789a9SourceVariant3" /> class.
        /// </summary>
        public AutoSDKShared12773eaec07789a9SourceVariant3()
        {
        }

    }
}