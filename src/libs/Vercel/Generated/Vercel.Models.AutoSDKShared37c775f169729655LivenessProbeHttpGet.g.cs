
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared37c775f169729655LivenessProbeHttpGet
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        public string? Host { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpHeaders")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared37c775f169729655LivenessProbeHttpGetHttpHeader>? HttpHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Port { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared37c775f169729655LivenessProbeHttpGetSchemeJsonConverter))]
        public global::Vercel.AutoSDKShared37c775f169729655LivenessProbeHttpGetScheme? Scheme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared37c775f169729655LivenessProbeHttpGet" /> class.
        /// </summary>
        /// <param name="port"></param>
        /// <param name="host"></param>
        /// <param name="httpHeaders"></param>
        /// <param name="path"></param>
        /// <param name="scheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared37c775f169729655LivenessProbeHttpGet(
            double port,
            string? host,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared37c775f169729655LivenessProbeHttpGetHttpHeader>? httpHeaders,
            string? path,
            global::Vercel.AutoSDKShared37c775f169729655LivenessProbeHttpGetScheme? scheme)
        {
            this.Host = host;
            this.HttpHeaders = httpHeaders;
            this.Path = path;
            this.Port = port;
            this.Scheme = scheme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared37c775f169729655LivenessProbeHttpGet" /> class.
        /// </summary>
        public AutoSDKShared37c775f169729655LivenessProbeHttpGet()
        {
        }

    }
}