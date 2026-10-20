
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede3c00aaf9d3a15beSourceVariant3
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede3c00aaf9d3a15beSourceVariant3KindJsonConverter))]
        public global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant3Kind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede3c00aaf9d3a15beSourceVariant3ProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant3Provider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede3c00aaf9d3a15beSourceVariant3" /> class.
        /// </summary>
        /// <param name="externalCheckName"></param>
        /// <param name="provider"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede3c00aaf9d3a15beSourceVariant3(
            string externalCheckName,
            global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant3Provider provider,
            global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant3Kind kind)
        {
            this.ExternalCheckName = externalCheckName ?? throw new global::System.ArgumentNullException(nameof(externalCheckName));
            this.Kind = kind;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede3c00aaf9d3a15beSourceVariant3" /> class.
        /// </summary>
        public AutoSDKSharede3c00aaf9d3a15beSourceVariant3()
        {
        }

    }
}