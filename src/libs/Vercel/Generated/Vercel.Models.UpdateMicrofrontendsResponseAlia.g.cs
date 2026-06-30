
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseAlia
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuredBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateMicrofrontendsResponseAliaConfiguredByJsonConverter))]
        public global::Vercel.UpdateMicrofrontendsResponseAliaConfiguredBy? ConfiguredBy { get; set; }

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
        public global::Vercel.UpdateMicrofrontendsResponseAliaDeployment? Deployment { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateMicrofrontendsResponseAliaEnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateMicrofrontendsResponseAliaEnvironment Environment { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateMicrofrontendsResponseAliaTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateMicrofrontendsResponseAliaTarget Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseAlia" /> class.
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
        public UpdateMicrofrontendsResponseAlia(
            string domain,
            global::Vercel.UpdateMicrofrontendsResponseAliaEnvironment environment,
            global::Vercel.UpdateMicrofrontendsResponseAliaTarget target,
            global::Vercel.UpdateMicrofrontendsResponseAliaConfiguredBy? configuredBy,
            double? configuredChangedAt,
            double? createdAt,
            global::Vercel.UpdateMicrofrontendsResponseAliaDeployment? deployment,
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
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseAlia" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseAlia()
        {
        }

    }
}