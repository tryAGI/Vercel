
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1ItemAlia
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuredBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant1ItemAliaConfiguredByJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant1ItemAliaConfiguredBy? ConfiguredBy { get; set; }

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
        public global::Vercel.GetProjectsResponseVariant1ItemAliaDeployment? Deployment { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant1ItemAliaEnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant1ItemAliaEnvironment Environment { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant1ItemAliaTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant1ItemAliaTarget Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemAlia" /> class.
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
        public GetProjectsResponseVariant1ItemAlia(
            string domain,
            global::Vercel.GetProjectsResponseVariant1ItemAliaEnvironment environment,
            global::Vercel.GetProjectsResponseVariant1ItemAliaTarget target,
            global::Vercel.GetProjectsResponseVariant1ItemAliaConfiguredBy? configuredBy,
            double? configuredChangedAt,
            double? createdAt,
            global::Vercel.GetProjectsResponseVariant1ItemAliaDeployment? deployment,
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
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemAlia" /> class.
        /// </summary>
        public GetProjectsResponseVariant1ItemAlia()
        {
        }
    }
}