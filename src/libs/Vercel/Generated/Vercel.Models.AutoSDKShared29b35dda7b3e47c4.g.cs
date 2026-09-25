
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared29b35dda7b3e47c4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuredBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared29b35dda7b3e47c4ConfiguredByJsonConverter))]
        public global::Vercel.AutoSDKShared29b35dda7b3e47c4ConfiguredBy? ConfiguredBy { get; set; }

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
        public global::Vercel.AutoSDKShared8422af433e1bf486? Deployment { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared29b35dda7b3e47c4EnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared29b35dda7b3e47c4Environment Environment { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared29b35dda7b3e47c4TargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared29b35dda7b3e47c4Target Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared29b35dda7b3e47c4" /> class.
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
        public AutoSDKShared29b35dda7b3e47c4(
            string domain,
            global::Vercel.AutoSDKShared29b35dda7b3e47c4Environment environment,
            global::Vercel.AutoSDKShared29b35dda7b3e47c4Target target,
            global::Vercel.AutoSDKShared29b35dda7b3e47c4ConfiguredBy? configuredBy,
            double? configuredChangedAt,
            double? createdAt,
            global::Vercel.AutoSDKShared8422af433e1bf486? deployment,
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
        /// Initializes a new instance of the <see cref="AutoSDKShared29b35dda7b3e47c4" /> class.
        /// </summary>
        public AutoSDKShared29b35dda7b3e47c4()
        {
        }

    }
}