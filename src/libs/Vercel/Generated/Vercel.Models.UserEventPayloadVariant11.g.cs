
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public global::Vercel.UserEventPayloadVariant11Deployment? Deployment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleCount")]
        public double? RuleCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentUrl")]
        public string? DeploymentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasId")]
        public string? AliasId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldDeploymentId")]
        public string? OldDeploymentId { get; set; }

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
        public string? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public bool? System { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasUpdatedAt")]
        public double? AliasUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant11" /> class.
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="deployment"></param>
        /// <param name="ruleCount"></param>
        /// <param name="deploymentUrl"></param>
        /// <param name="aliasId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="oldDeploymentId"></param>
        /// <param name="redirect"></param>
        /// <param name="redirectStatusCode"></param>
        /// <param name="target"></param>
        /// <param name="system"></param>
        /// <param name="aliasUpdatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant11(
            string? alias,
            global::Vercel.UserEventPayloadVariant11Deployment? deployment,
            double? ruleCount,
            string? deploymentUrl,
            string? aliasId,
            string? deploymentId,
            string? oldDeploymentId,
            string? redirect,
            double? redirectStatusCode,
            string? target,
            bool? system,
            double? aliasUpdatedAt)
        {
            this.Alias = alias;
            this.Deployment = deployment;
            this.RuleCount = ruleCount;
            this.DeploymentUrl = deploymentUrl;
            this.AliasId = aliasId;
            this.DeploymentId = deploymentId;
            this.OldDeploymentId = oldDeploymentId;
            this.Redirect = redirect;
            this.RedirectStatusCode = redirectStatusCode;
            this.Target = target;
            this.System = system;
            this.AliasUpdatedAt = aliasUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant11" /> class.
        /// </summary>
        public UserEventPayloadVariant11()
        {
        }
    }
}