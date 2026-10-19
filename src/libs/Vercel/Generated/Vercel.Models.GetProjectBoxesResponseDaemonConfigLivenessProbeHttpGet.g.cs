
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGet
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
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGetHttpHeader>? HttpHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGetSchemeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGetScheme Scheme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGet" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="port"></param>
        /// <param name="scheme"></param>
        /// <param name="host"></param>
        /// <param name="httpHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGet(
            string path,
            double port,
            global::Vercel.GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGetScheme scheme,
            string? host,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGetHttpHeader>? httpHeaders)
        {
            this.Host = host;
            this.HttpHeaders = httpHeaders;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Port = port;
            this.Scheme = scheme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGet" /> class.
        /// </summary>
        public GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGet()
        {
        }

    }
}