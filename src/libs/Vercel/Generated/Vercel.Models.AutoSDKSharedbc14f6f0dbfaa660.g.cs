
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedbc14f6f0dbfaa660
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuredBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedbc14f6f0dbfaa660ConfiguredByJsonConverter))]
        public global::Vercel.AutoSDKSharedbc14f6f0dbfaa660ConfiguredBy? ConfiguredBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuredChangedAt")]
        public double? ConfiguredChangedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public global::Vercel.AutoSDKShared290e0be6a2cc986e? Deployment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedbc14f6f0dbfaa660EnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedbc14f6f0dbfaa660Environment Environment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public string? Redirect { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectStatusCode")]
        public double? RedirectStatusCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedbc14f6f0dbfaa660TargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedbc14f6f0dbfaa660Target Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbc14f6f0dbfaa660" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="environment"></param>
        /// <param name="target"></param>
        /// <param name="configuredBy"></param>
        /// <param name="configuredChangedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="deployment"></param>
        /// <param name="gitBranch"></param>
        /// <param name="redirect"></param>
        /// <param name="redirectStatusCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedbc14f6f0dbfaa660(
            string domain,
            global::Vercel.AutoSDKSharedbc14f6f0dbfaa660Environment environment,
            global::Vercel.AutoSDKSharedbc14f6f0dbfaa660Target target,
            global::Vercel.AutoSDKSharedbc14f6f0dbfaa660ConfiguredBy? configuredBy,
            double? configuredChangedAt,
            double? createdAt,
            global::Vercel.AutoSDKShared290e0be6a2cc986e? deployment,
            string? gitBranch,
            string? redirect,
            double? redirectStatusCode)
        {
            this.ConfiguredBy = configuredBy;
            this.ConfiguredChangedAt = configuredChangedAt;
            this.CreatedAt = createdAt;
            this.Deployment = deployment;
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Environment = environment;
            this.GitBranch = gitBranch;
            this.Redirect = redirect;
            this.RedirectStatusCode = redirectStatusCode;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbc14f6f0dbfaa660" /> class.
        /// </summary>
        public AutoSDKSharedbc14f6f0dbfaa660()
        {
        }

    }
}